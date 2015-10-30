Imports System.IO
'認証ファイルを設定


Public Class AttestationDataForm
    'Private NinshouFile As String = CommonConstant.NinshouFilePath & "\" & CommonConstant.NinshouFileName
    Private NinshouFile As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\" & CommonConstant.NinshouFileName
    Private hStream As System.IO.FileStream

    '登録ボタン押下時の処理
    Private Sub RegistrationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationButton.Click

        '入力内容のチェックを行う
        If (InputDataErrorCheck()) Then
            Exit Sub

        End If
        'メールアドレスを取得
        Dim mailAddress As String = InputMailAddress.Text
        'パスワードを取得
        Dim passWord As String = InputPassword.Text
        '利用者権限を取得
        Dim Authority As String = AuthorityList.SelectedItem
        '利用者権限をコード化
        Dim AuthorityCode As String = setAuthorityCode(Authority)
        '登録時刻を取得
        Dim Today As String = (Date.Now).ToString("yyyyMMdd")

        'ファイル設定値を生成
        Dim setData As String = mailAddress & "," & passWord & "," & AuthorityCode & "," & Today

        '今回登録情報の存在を確認する
        If (TourokuDataCheck(mailAddress, passWord, NinshouFile)) Then
            Call MsgBox("アドレス：" & mailAddress & _
                        "パスワード：" & passWord & vbCrLf & _
                        "は、すでに登録されています。再登録を行う場合は対象情報を一度削除してください。" _
                        , MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        '共通変数へセット
        gMailAddress = mailAddress.Clone
        gPassWord = passWord.Clone
        gAuthority = Authority.Clone
        gDlgHeaderMsg = CommonConstant.lblHeaderRegistration
        gDlgConfirmationMsg = CommonConstant.lblConfirmationRegistration

        '登録情報を認証ファイルへ追加する
        '確認ダイアログのインスタンス生成
        Dim dlgConfirmation As New dlgConfirmation

        dlgConfirmation.ShowDialog()
        dlgConfirmation.Dispose()

        ' オッズ発表時間ダイアログ操作結果
        'MsgBox(dlgConfirmation.DialogResult)
        If dlgConfirmation.DialogResult = DialogResult.OK Then
            'MsgBox("okが押された")
            Try
                '認証ファイル書き込み
                NinshouFileWrite(setData, NinshouFile)

                'メインサーバーへのファイルアップロード
                If NinshouFileUpload(CommonConstant.MainServerAddressIP) Then
                    'ファイル転送正常終了の場合
                    MsgBox(CommonConstant.msgUploadOk & CommonConstant.MainServerAddressIP)
                Else
                    'ファイル転送ＮＧの場合
                    MsgBox(CommonConstant.msgUploadNg & CommonConstant.MainServerAddressIP)
                End If


                ''サブサーバーへのファイルアップロード
                'If NinshouFileUpload(CommonConstant.SubServerAddressIP) Then
                '    'ファイル転送正常終了の場合
                '    MsgBox(CommonConstant.msgUploadOk & CommonConstant.SubServerAddressIP)
                'Else
                '    'ファイル転送ＮＧの場合
                '    MsgBox(CommonConstant.msgUploadNg & CommonConstant.SubServerAddressIP)
                'End If

                MsgBox("認証情報の登録が終了しました")

                InputClear()

            Catch ex As Exception
                MsgBox("認証ファイルの登録作業中にエラーが発生しました")

            End Try

        Else

            Exit Sub

        End If

    End Sub

    '認証情報の登録状況を確認する
    '返却値
    ' True：登録済み
    ' False：未登録
    Private Function TourokuDataCheck(ByVal mailAddress As String, ByVal passWord As String, ByVal NinshouFile As String) As Boolean

        Dim retCode As Boolean = False

        Dim f As Integer
        Dim readData As String()
        Dim FirstRec As Boolean = True

        f = FreeFile()

        FileOpen(f, NinshouFile, OpenMode.Input)

        Do Until EOF(f)
            readData = LineInput(f).Split(","c)
            Dim readDataMailAddress = readData(CommonConstant.const0)
            Dim readDataPassWord = readData(CommonConstant.const1)
            '今回の登録情報がすでに存在するかを判定する
            If (readDataMailAddress = mailAddress And readDataPassWord = passWord) Then
                'すでに存在した場合は処理を終了
                retCode = True
                Exit Do

            End If

        Loop

        FileClose(f)

        Return retCode

    End Function
    '登録内容を認証情報ファイルへ書き込む
    Private Sub NinshouFileWrite(ByVal setData As String, ByVal NinshouFile As String)

        'ファイルを書き込み用に開く
        Dim fsFile As System.IO.FileStream = System.IO.File.OpenWrite(NinshouFile)

        '書き込み用ストリームを用意し、データを書き込める状態にする
        Dim sw As System.IO.StreamWriter = New System.IO.StreamWriter(fsFile)

        'ストリームの末尾に移動
        sw.BaseStream.Seek(0, System.IO.SeekOrigin.End)

        'データを書き込む
        sw.WriteLine(setData)

        'ファイルを更新する
        sw.Flush()

        'ファイルを閉じる
        sw.Close()
        fsFile.Close()



    End Sub

    '入力情報の取消を行う
    Private Sub Cancellation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancellation.Click
        'InputMailAddress.Text = ""
        'InputPassword.Text = ""
        'AuthorityList.SelectedIndex = CommonConstant.const0

        InputClear()

    End Sub

    '登録情報の削除を行う
    Private Sub RegistrationDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationDelete.Click

        '入力内容のチェックを行う
        If (InputDataErrorCheck()) Then

            Exit Sub

        End If

        'メールアドレスを取得
        Dim mailAddress As String = InputMailAddress.Text
        'パスワードを取得
        Dim passWord As String = InputPassword.Text
        '利用者権限を取得
        Dim Authority As String = AuthorityList.SelectedItem
        '利用者権限をコード化
        Dim AuthorityCode As String = setAuthorityCode(Authority)
        'ファイル設定値を生成
        Dim setData As String = mailAddress & "," & passWord & "," & AuthorityCode


        '共通変数へセット
        gMailAddress = mailAddress.Clone
        gPassWord = passWord.Clone
        gAuthority = Authority.Clone
        gDlgHeaderMsg = CommonConstant.lblHeaderDelete
        gDlgConfirmationMsg = CommonConstant.lblConfirmationDelete



        '確認ダイアログのインスタンス生成
        Dim dlgConfirmation As New dlgConfirmation

        dlgConfirmation.ShowDialog()
        dlgConfirmation.Dispose()

        '確認ダイアログの押下ボタンにより処理を分岐
        If dlgConfirmation.DialogResult = DialogResult.OK Then
            'ＯＫが押下された場合
            '登録有無の確認
            If TourokuDataCheck(mailAddress, passWord, NinshouFile) Then
                '存在した場合、該当レコードの削除を実施
                recDelete(setData, NinshouFile)

            Else
                'データが存在しない場合、メッセージを出力して処理を終了
                MsgBox(CommonConstant.msgDataNotFound)
            End If

        End If



    End Sub
    '登録情報の削除
    Private Sub recDelete(ByVal setData As String, ByVal DataFile As String)

        '出力データ蓄積用リスト
        Dim readDataList As New ArrayList
        Dim Reader As New IO.StreamReader(DataFile)
        Dim setDataWork As String() = setData.Split(","c)
        Dim setDataKey As String = setDataWork(CommonConstant.const0) & "," & setDataWork(CommonConstant.const1)
        Try
            Do Until Reader.EndOfStream
                Dim readData As String = Reader.ReadLine
                Dim readDataH As String() = readData.Split(","c)

                Dim dataKey As String = readDataH(CommonConstant.const0) & "," & _
                                        readDataH(CommonConstant.const1)

                If (dataKey <> setDataKey) Then
                    readDataList.Add(readData)
                End If

            Loop

            Reader.Close()


            Dim Writer As New IO.StreamWriter(DataFile)

            For i = 0 To readDataList.Count - 1
                Writer.WriteLine(readDataList(i))
            Next

            Writer.Close()

            MsgBox("認証情報を削除しました。")
            InputClear()

        Catch ex As Exception

            MsgBox("認証情報の削除中にエラーが発生しました。", MsgBoxStyle.Exclamation)

        End Try


    End Sub

    '入力情報の確認
    Private Function InputDataErrorCheck()
        Dim retCode As Boolean = False
        '入力内容のチェックを行う

        If (InputMailAddress.Text = "") Then
            'メールアドレスの入力が空の場合
            MsgBox("メールアドレスが入力されていません。", MsgBoxStyle.Exclamation)
            retCode = True

        ElseIf (InputPassword.Text = "") Then
            'パスワードの入力が空の場合
            MsgBox("パスワードが入力されていません。", MsgBoxStyle.Exclamation)
            retCode = True

        End If

        Return retCode

    End Function
    '利用者権限コードを返却する
    Private Function setAuthorityCode(ByVal AuthorityData As String)
        Dim retCode As String = String.Empty

        If (AuthorityData = CommonConstant.AuthorityGeneral) Then
            retCode = CommonConstant.AuthorityGeneralCode
        Else
            retCode = CommonConstant.AuthorityManagerCode

        End If


        Return retCode
    End Function
    Private Sub InputClear()
        InputMailAddress.Text = ""
        InputPassword.Text = ""
        AuthorityList.SelectedIndex = CommonConstant.const0

    End Sub
    'フォームロード
    Private Sub AttestationDataForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '権限コンボボックスに選択内容を表示
        AuthorityList.Items.Add(CommonConstant.AuthorityGeneral)
        AuthorityList.Items.Add(CommonConstant.AuthorityManager)
        AuthorityList.SelectedIndex = CommonConstant.const0

        If (File.Exists(NinshouFile) = False) Then

            'ファイルが存在しない場合、空のファイルを作成する
            hStream = System.IO.File.Create(NinshouFile)
            hStream.Close()

        End If

    End Sub
    '
    '認証ファイルのバックアップを行う
    '
    Private Sub btnBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackUp.Click
        '現在時刻を取得
        Dim dtNow As String = DateTime.Now.ToString("yyyyMMddHHmmss")
        'MsgBox(dtNow.ToString("yyyyMMddHHmmss"))

        Dim dlgExplorerView As New FolderBrowserDialog

        dlgExplorerView.Description = "保存先を指定してください"
        'デフォルトフォルダ 
        dlgExplorerView.RootFolder = Environment.SpecialFolder.Desktop

        '最初に選択するフォルダ 
        dlgExplorerView.SelectedPath = "C:\"

        'あたらしいフォルダを作成できるようにする 
        dlgExplorerView.ShowNewFolderButton = True

        Dim dialogButton As Integer 'OK/CANCEL 
        dialogButton = dlgExplorerView.ShowDialog()

        If dialogButton = DialogResult.OK Then 'OKボタンが押されたら次の処理を行う 
            Dim backUpFile As String = dlgExplorerView.SelectedPath & "/" & CommonConstant.NinshouFileName & "_" & dtNow
            System.IO.File.Copy(NinshouFile, backUpFile, True)

            If File.Exists(backUpFile) Then

                MsgBox("ファイルバックアップ完了：" & backUpFile)
            Else
                MsgBox("ファイルバックアップに失敗しました。", MsgBoxStyle.Exclamation)
            End If

        End If

    End Sub

    '認証情報の再配信
    Private Sub btnDelivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelivery.Click

        'メインサーバーへのファイルアップロード
        If NinshouFileUpload(CommonConstant.MainServerAddressIP) Then
            'ファイル転送正常終了の場合
            MsgBox(CommonConstant.msgUploadOk & CommonConstant.MainServerAddressIP)
        Else
            'ファイル転送ＮＧの場合
            MsgBox(CommonConstant.msgUploadNg & CommonConstant.MainServerAddressIP)
        End If


        ''サブサーバーへのファイルアップロード
        'If NinshouFileUpload(CommonConstant.SubServerAddressIP) Then
        '    'ファイル転送正常終了の場合
        '    MsgBox(CommonConstant.msgUploadOk & CommonConstant.SubServerAddressIP)
        'Else
        '    'ファイル転送ＮＧの場合
        '    MsgBox(CommonConstant.msgUploadNg & CommonConstant.SubServerAddressIP)
        'End If


    End Sub

    '指定されたサーバーに対して、認証ファイルをアップロードする（ＦＴＰ）

    Private Function NinshouFileUpload2(ByVal IPAddress As String) As Boolean

        '処理結果の戻り値
        Dim retCode As Boolean = True

        '送信元ファイル 
        Dim filePath As String = NinshouFile
        '送信先ファイル 
        Dim url As String = CommonConstant.FtpUpload & IPAddress & "/" & CommonConstant.NinshouFileName
        'サーバー接続ユーザーID格納エリア
        Dim setId As String = String.Empty
        'サーバー接続パスワード格納エリア
        Dim setPass As String = String.Empty

        'サーバー接続ID／パスワードの設定
        If (IPAddress = CommonConstant.MainServerAddressIP) Then
            'メインサーバーの場合
            setId = CommonConstant.MainServerFtpId
            setPass = CommonConstant.MainServerFtpPass

        Else
            'サブサーバーの場合
            'setId = CommonConstant.SubServerFtpId
            'setPass = CommonConstant.SubServerFtpPass

        End If


        'サーバー接続クラスのインスタンス
        Dim wc As New System.Net.WebClient
        '接続ＩＤ／パスワード設定
        wc.Credentials = New System.Net.NetworkCredential(setId, setPass)

        Try
            'データを送信する 
            wc.UploadFile(url, filePath)

        Catch ex As Exception
            'アップロードエラーの場合
            retCode = False

        End Try


        Return retCode

    End Function


    Private Function NinshouFileUpload(ByVal IPAddress As String) As Boolean
        'アップロードするファイル
        Dim upFile As String = "C:\test.txt"
        'アップロード先のURI
        Dim u As New Uri(CommonConstant.FtpUpload & IPAddress & "/" & CommonConstant.NinshouFileName)

        '送信元ファイル 
        Dim filePath As String = NinshouFile
        '送信先ファイル 
        Dim url As String = CommonConstant.FtpUpload & IPAddress & "/" & CommonConstant.NinshouFileName
        'サーバー接続ユーザーID格納エリア
        Dim setId As String = String.Empty
        'サーバー接続パスワード格納エリア
        Dim setPass As String = String.Empty

        '処理結果の戻り値
        Dim retCode As Boolean = True

        'サーバー接続ID／パスワードの設定
        If (IPAddress = CommonConstant.MainServerAddressIP) Then
            'メインサーバーの場合
            setId = CommonConstant.MainServerFtpId
            setPass = CommonConstant.MainServerFtpPass

        Else
            'サブサーバーの場合
            'setId = CommonConstant.SubServerFtpId
            'setPass = CommonConstant.SubServerFtpPass

        End If


        'FtpWebRequestの作成
        Dim ftpReq As System.Net.FtpWebRequest = _
            CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
        'ログインユーザー名とパスワードを設定
        ftpReq.Credentials = New System.Net.NetworkCredential(setId, setPass)
        'MethodにWebRequestMethods.Ftp.UploadFile("STOR")を設定
        ftpReq.Method = System.Net.WebRequestMethods.Ftp.UploadFile
        '要求の完了後に接続を閉じる
        ftpReq.KeepAlive = False
        'ASCIIモードで転送する
        ftpReq.UseBinary = False
        'PASVモードを無効にする
        ftpReq.UsePassive = False

        'ファイルをアップロードするためのStreamを取得
        Dim reqStrm As System.IO.Stream = ftpReq.GetRequestStream()
        'アップロードするファイルを開く
        Try
            Dim fs As New System.IO.FileStream( _
                filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
            'アップロードStreamに書き込む
            Dim buffer(1023) As Byte
            While True
                Dim readSize As Integer = fs.Read(buffer, 0, buffer.Length)
                If readSize = 0 Then
                    Exit While
                End If
                reqStrm.Write(buffer, 0, readSize)
            End While
            fs.Close()
            reqStrm.Close()

            'FtpWebResponseを取得
            Dim ftpRes As System.Net.FtpWebResponse = _
                CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
            'FTPサーバーから送信されたステータスを表示
            Console.WriteLine("{0}: {1}", ftpRes.StatusCode, ftpRes.StatusDescription)
            '閉じる
            ftpRes.Close()
        Catch ex As Exception
            'アップロードエラーの場合
            retCode = False

        End Try


        Return retCode

    End Function



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' ListViewダイアログを表示

        dlgListDisplay.Show()


    End Sub

    Private Sub btnActivationCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivationCancel.Click
        '認証ファイル名
        Dim strFileName As String
        'メールアドレスを取得
        Dim mailAddress As String = InputMailAddress.Text
        'パスワードを取得
        Dim passWord As String = InputPassword.Text
        '利用者権限を取得
        Dim Authority As String = AuthorityList.SelectedItem
        '利用者権限をコード化
        Dim AuthorityCode As String = setAuthorityCode(Authority)
        'ファイル設定値を生成
        Dim setData As String = mailAddress & "," & passWord & "," & AuthorityCode


        '入力内容のチェックを行う
        If (InputDataErrorCheck()) Then

            Exit Sub

        End If

        '共通変数へセット
        gMailAddress = mailAddress.Clone
        gPassWord = passWord.Clone
        gAuthority = Authority.Clone
        gDlgHeaderMsg = CommonConstant.lblHeaderActivationCancel
        gDlgConfirmationMsg = CommonConstant.lblConfirmationActivationCancel

        '確認ダイアログのインスタンス生成
        Dim dlgConfirmation As New dlgConfirmation

        dlgConfirmation.ShowDialog()
        dlgConfirmation.Dispose()

        '確認ダイアログの押下ボタンにより処理を分岐
        If dlgConfirmation.DialogResult = DialogResult.OK Then
            'ＯＫが押下された場合
            '登録有無の確認
            If TourokuDataCheck(mailAddress, passWord, NinshouFile) Then
                'ファイル名をメールアドレスから作成
                strFileName = Replace(mailAddress, "@", "_")
                strFileName = Replace(strFileName, ".", "_")
                strFileName = Replace(strFileName, ";", "")

                'アクティベーションファイルがサーバに存在するか確認する
                If ActivationServerFileFind(strFileName) = True Then
                    'ファイルが存在した場合、削除する
                    ActivationFileDelete(strFileName)

                    MsgBox("認証情報を解除しました。")
                Else
                    MsgBox("認証情報はありませんでした。")
                End If
            Else
                'データが存在しない場合、メッセージを出力して処理を終了
                MsgBox(CommonConstant.msgDataNotFound)
            End If

        End If
    End Sub

    'アクティベーション用ファイルがサーバに存在するか確認する。
    Private Function ActivationServerFileFind(ByVal FileName As String) As Boolean
        Dim req As System.Net.FtpWebRequest = System.Net.WebRequest.Create(CommonConstant.FtpUpload & CommonConstant.ActivationDir & FileName)

        req.Credentials = New System.Net.NetworkCredential(CommonConstant.MainServerFtpId, CommonConstant.MainServerFtpPass)
        req.Method = System.Net.WebRequestMethods.Ftp.ListDirectory
        '要求の完了後に接続を閉じる
        req.KeepAlive = False
        'PASSIVEモードを無効にする
        req.UsePassive = False

        'FTPWebResponseを取得
        Dim ftpres As System.Net.FtpWebResponse = CType(req.GetResponse(), System.Net.FtpWebResponse)

        'FTPサーバから送信されたデータを取得
        Dim sr As New System.IO.StreamReader(ftpres.GetResponseStream())
        Dim res As String = sr.ReadToEnd()
        'ファイル一覧を表示
        sr.Close()

        If InStr(res, FileName) > 0 Then
            Return True
        Else
            Return False
        End If


    End Function

    'アクティベーション用ファイルを削除する
    Private Function ActivationFileDelete(ByVal FileName As String) As Boolean
        'アップロード先のURI
        Dim u As New Uri(CommonConstant.FtpUpload & CommonConstant.ActivationDir & FileName)
        '削除するファイル 
        Dim url As String = CommonConstant.FtpUpload & CommonConstant.ActivationDir & FileName
        'サーバー接続ユーザーID格納エリア
        Dim setId As String = String.Empty
        'サーバー接続パスワード格納エリア
        Dim setPass As String = String.Empty
        '処理結果の戻り値
        Dim retCode As Boolean = True
        'サーバー接続ID／パスワードの設定
        'メインサーバーの場合
        setId = CommonConstant.MainServerFtpId
        setPass = CommonConstant.MainServerFtpPass
        'アップロードするファイルを開く
        Try
            'FtpWebRequestの作成
            Dim ftpReq As System.Net.FtpWebRequest = _
                CType(System.Net.WebRequest.Create(u), System.Net.FtpWebRequest)
            'ログインユーザー名とパスワードを設定
            ftpReq.Credentials = New System.Net.NetworkCredential(setId, setPass)
            '要求の完了後に接続を閉じる
            ftpReq.KeepAlive = False
            'ファイルを削除する
            ftpReq.Method = System.Net.WebRequestMethods.Ftp.DeleteFile

            'FtpWebResponseを取得
            Dim ftpRes As System.Net.FtpWebResponse = _
                CType(ftpReq.GetResponse(), System.Net.FtpWebResponse)
            'FTPサーバーから送信されたステータスを表示
            Console.WriteLine("{0}: {1}", ftpRes.StatusCode, ftpRes.StatusDescription)
            '閉じる
            ftpRes.Close()
        Catch ex As Exception
            'アップロードエラーの場合
            retCode = False

        End Try

        Return retCode

    End Function

End Class
