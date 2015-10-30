Imports System.Windows.Forms

Public Class dlgListDisplay

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ListDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ListViewコントロールのプロパティを設定 
        ' ListViewコントロールのデータをすべて消去します。 
        ListView1.Items.Clear()

        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Sorting = SortOrder.Ascending
        ListView1.View = View.Details

        ' 列（コラム）ヘッダの作成 
        Dim columnNo As New ColumnHeader
        Dim columnName = New ColumnHeader
        Dim columnType = New ColumnHeader
        Dim columnData = New ColumnHeader
        Dim columnInputDate = New ColumnHeader
        columnNo.Text = "No."
        columnNo.Width = 40
        columnName.Text = "メールアドレス"
        columnName.Width = 200
        columnType.Text = "パスワード"
        columnType.Width = 100
        columnData.Text = "使用権限"
        columnData.Width = 100
        columnInputDate.Text = "登録年月日"
        columnInputDate.Width = 100
        Dim colHeaderRegValue() As ColumnHeader = _
          {columnNo, columnName, columnType, columnData, columnInputDate}
        ListView1.Columns.AddRange(colHeaderRegValue)

        Dim f As Integer
        Dim readData As String
        Dim FirstRec As Boolean = True
        'Dim InputFile As String = CommonConstant.NinshouFilePath & "\" & CommonConstant.NInshouFileName
        Dim InputFile As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\" & CommonConstant.NInshouFileName

        Dim counter As Integer = CommonConstant.const1
        f = FreeFile()

        FileOpen(f, InputFile, OpenMode.Input)

        Do Until EOF(f)
            readData = LineInput(f)
            Dim readDataH As String() = readData.Split(","c)
            Dim readMailAddress As String = readDataH(CommonConstant.const0)
            Dim readPassword As String = readDataH(CommonConstant.const1)
            Dim readAuthority As String = getAuthorityName(readDataH(CommonConstant.const2))
            Dim readInputDate As String = readDataH(CommonConstant.const3).Substring(0, 4) & "年" & _
                                        readDataH(CommonConstant.const3).Substring(4, 2) & "月" & _
                                        readDataH(CommonConstant.const3).Substring(6, 2) & "日"


            ' ListViewコントロールにデータを追加します。 
            Dim item() As String = {counter, readMailAddress, readPassword, readAuthority, readInputDate}
            ListView1.Items.Add(New ListViewItem(item))

            counter = counter + CommonConstant.const1

        Loop

        FileClose(f)

 

    End Sub
    '使用権限コードを名称に変換して返却する
    Public Function getAuthorityName(ByVal AuthorityCode As String) As String
        Dim retName As String = String.Empty

        If AuthorityCode = CommonConstant.AuthorityGeneralCode Then

            retName = CommonConstant.AuthorityGeneral

        ElseIf AuthorityCode = CommonConstant.AuthorityManagerCode Then

            retName = CommonConstant.AuthorityManager

        End If


        Return retName

    End Function

End Class
