Public Class CommonConstant

    '認証ファイル
    '認証ファイル格納パス
    Public Const NinshouFilePath As String = "C:"
    '認証ファイルバックアップ格納パス
    Public Const BackUpPath As String = "C:\BackUp"
    '認証ファイル名称
    Public Const NinshouFileName As String = "NinshouDataK.csv"


    'サーバー関連
    'メインサーバーＩＰアドレス
    Public Const MainServerAddressIP As String = "153.121.59.92/ninshou"
    'メインサーバーＵＲＬ
    Public Const MainServerUrl As String = "http://www.ananokami38.com/~anasoft/"
    'メインサーバーＨＴＴＰログインユーザーＩＤ
    Public Const MainServerHttpUserId As String = "root"
    'メインサーバーＨＴＴＰログインパスワード
    Public Const MainServerHttpUserPass As String = "vsmyvn3yt3"
    'メインサーバーＦＴＰログインユーザーＩＤ
    Public Const MainServerFtpId As String = "root"
    'メインサーバーＦＴＰログインパスワード
    Public Const MainServerFtpPass As String = "vsmyvn3yt3"


    ''サブサーバーアドレス
    'Public Const SubServerAddressIP As String = "203.105.84.56/www/htdocs/anasoft/Data"
    ''サブサーバーＵＲＬ
    'Public Const SubServerUrl As String = "http://203.105.84.56/anasoft/"
    ''サブサーバーＨＴＴＰログインユーザーＩＤ
    'Public Const SubServerHttpUserId As String = "anasoft"
    ''サブサーバーＨＴＴＰログインパスワード
    'Public Const SubServerHttpUserPass As String = "8cdg7Kmg"
    ''サブサーバーＦＴＰログインユーザーＩＤ
    'Public Const SubServerFtpId As String = "anasoft"
    ''サブサーバーＦＴＰログインパスワード
    'Public Const SubServerFtpPass As String = "Aw2dKiu4"

    '伝送方式
    Public Const FtpUpload As String = "ftp://"
    Public Const HttpUpload As String = "http://"

    '利用者権限
    '表示文言
    '一般
    Public Const AuthorityGeneral As String = "一般利用者"
    '管理
    Public Const AuthorityManager As String = "管理者"

    '権限コード
    '一般
    Public Const AuthorityGeneralCode As String = "0"
    '管理
    Public Const AuthorityManagerCode As String = "1"

    '固定値
    Public Const const0 As Integer = 0
    Public Const const1 As Integer = 1
    Public Const const2 As Integer = 2
    Public Const const3 As Integer = 3

    '確認フォーム文言
    Public Const lblHeaderRegistration As String = "登録内容確認"
    Public Const lblHeaderDelete As String = "削除内容確認"
    Public Const lblHeaderActivationCancel As String = "認証解除確認"
    Public Const lblConfirmationRegistration As String = "上記の内容で登録します。よろしいでしょうか？"
    Public Const lblConfirmationDelete As String = "上記の登録内容を削除します。よろしいでしょうか？"
    Public Const lblConfirmationActivationCancel As String = "上記のデータの認証情報を解除します。よろしいでしょうか？"

    'データ存在確認
    Public Const msgDataFound As String = "該当のデータが存在します。入力情報を確認してください。"
    Public Const msgDataNotFound As String = "該当のデータが存在しません。入力情報を確認してください。"

    'ファイル転送文言
    Public Const msgUploadOk As String = "ファイルを転送しました。サーバー："
    Public Const msgUploadNg As String = "ファイルの転送に失敗しました。サーバー："

    '20140810 アクティベーション用
    Public Const ActivationDir As String = "153.121.59.92/ninshou/activation/"

End Class
