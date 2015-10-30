<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttestationDataForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.InputMailAddress = New System.Windows.Forms.TextBox
        Me.InputPassword = New System.Windows.Forms.TextBox
        Me.RegistrationButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cancellation = New System.Windows.Forms.Button
        Me.RegistrationDelete = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.AuthorityList = New System.Windows.Forms.ComboBox
        Me.btnBackUp = New System.Windows.Forms.Button
        Me.btnDelivery = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnActivationCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "メールアドレス"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "パスワード"
        '
        'InputMailAddress
        '
        Me.InputMailAddress.Location = New System.Drawing.Point(122, 115)
        Me.InputMailAddress.Name = "InputMailAddress"
        Me.InputMailAddress.Size = New System.Drawing.Size(321, 19)
        Me.InputMailAddress.TabIndex = 2
        '
        'InputPassword
        '
        Me.InputPassword.Location = New System.Drawing.Point(122, 147)
        Me.InputPassword.Name = "InputPassword"
        Me.InputPassword.Size = New System.Drawing.Size(129, 19)
        Me.InputPassword.TabIndex = 3
        '
        'RegistrationButton
        '
        Me.RegistrationButton.Location = New System.Drawing.Point(18, 250)
        Me.RegistrationButton.Name = "RegistrationButton"
        Me.RegistrationButton.Size = New System.Drawing.Size(105, 23)
        Me.RegistrationButton.TabIndex = 4
        Me.RegistrationButton.Text = "登録"
        Me.RegistrationButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "十周年記念ソフト 認証登録"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(16, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "※必ず入金確認後に実施してください！！"
        '
        'Cancellation
        '
        Me.Cancellation.Location = New System.Drawing.Point(129, 250)
        Me.Cancellation.Name = "Cancellation"
        Me.Cancellation.Size = New System.Drawing.Size(105, 23)
        Me.Cancellation.TabIndex = 7
        Me.Cancellation.Text = "取消"
        Me.Cancellation.UseVisualStyleBackColor = True
        '
        'RegistrationDelete
        '
        Me.RegistrationDelete.Location = New System.Drawing.Point(240, 250)
        Me.RegistrationDelete.Name = "RegistrationDelete"
        Me.RegistrationDelete.Size = New System.Drawing.Size(105, 23)
        Me.RegistrationDelete.TabIndex = 8
        Me.RegistrationDelete.Text = "登録削除"
        Me.RegistrationDelete.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "利用権限"
        '
        'AuthorityList
        '
        Me.AuthorityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AuthorityList.FormattingEnabled = True
        Me.AuthorityList.Location = New System.Drawing.Point(122, 183)
        Me.AuthorityList.Name = "AuthorityList"
        Me.AuthorityList.Size = New System.Drawing.Size(121, 20)
        Me.AuthorityList.TabIndex = 10
        '
        'btnBackUp
        '
        Me.btnBackUp.Location = New System.Drawing.Point(29, 322)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(75, 23)
        Me.btnBackUp.TabIndex = 11
        Me.btnBackUp.Text = "バックアップ"
        Me.btnBackUp.UseVisualStyleBackColor = True
        '
        'btnDelivery
        '
        Me.btnDelivery.Location = New System.Drawing.Point(29, 365)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(75, 23)
        Me.btnDelivery.TabIndex = 12
        Me.btnDelivery.Text = "配信"
        Me.btnDelivery.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(120, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 12)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "認証登録情報のバックアップを実施します。"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(120, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 12)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "認証登録をサーバーへ再配信します。"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(120, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 12)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "認証登録情報の一覧を表示します。"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "一覧表示"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(27, 455)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(400, 12)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "※「登録削除」作業を実行した場合、認証情報はサーバーへ自動配信されません！"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(27, 469)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(434, 12)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = " 　「一覧表示」で削除された事を確認後、「配信」にてサーバーへファイルを配信してください。"
        '
        'btnActivationCancel
        '
        Me.btnActivationCancel.Location = New System.Drawing.Point(351, 250)
        Me.btnActivationCancel.Name = "btnActivationCancel"
        Me.btnActivationCancel.Size = New System.Drawing.Size(105, 23)
        Me.btnActivationCancel.TabIndex = 19
        Me.btnActivationCancel.Text = "認証解除"
        Me.btnActivationCancel.UseVisualStyleBackColor = True
        '
        'AttestationDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(475, 490)
        Me.Controls.Add(Me.btnActivationCancel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDelivery)
        Me.Controls.Add(Me.btnBackUp)
        Me.Controls.Add(Me.AuthorityList)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RegistrationDelete)
        Me.Controls.Add(Me.Cancellation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RegistrationButton)
        Me.Controls.Add(Me.InputPassword)
        Me.Controls.Add(Me.InputMailAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "AttestationDataForm"
        Me.Text = "認証情報登録フォーム"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InputMailAddress As System.Windows.Forms.TextBox
    Friend WithEvents InputPassword As System.Windows.Forms.TextBox
    Friend WithEvents RegistrationButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cancellation As System.Windows.Forms.Button
    Friend WithEvents RegistrationDelete As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AuthorityList As System.Windows.Forms.ComboBox
    Friend WithEvents btnBackUp As System.Windows.Forms.Button
    Friend WithEvents btnDelivery As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnActivationCancel As System.Windows.Forms.Button

End Class
