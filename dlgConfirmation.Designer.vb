<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgConfirmation
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblConfirmation = New System.Windows.Forms.Label
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblMailAddress = New System.Windows.Forms.Label
        Me.lblPass = New System.Windows.Forms.Label
        Me.lblAuthority = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(365, 253)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 21)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "キャンセル"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "メールアドレス"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "パスワード"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "利用者権限"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "："
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.BackColor = System.Drawing.SystemColors.Control
        Me.lblConfirmation.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblConfirmation.ForeColor = System.Drawing.Color.Red
        Me.lblConfirmation.Location = New System.Drawing.Point(26, 201)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(247, 12)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "上記の内容で登録します。よろしいでしょうか？"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHeader.Location = New System.Drawing.Point(12, 22)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(110, 16)
        Me.lblHeader.TabIndex = 8
        Me.lblHeader.Text = "登録内容確認"
        '
        'lblMailAddress
        '
        Me.lblMailAddress.AutoSize = True
        Me.lblMailAddress.Location = New System.Drawing.Point(126, 64)
        Me.lblMailAddress.Name = "lblMailAddress"
        Me.lblMailAddress.Size = New System.Drawing.Size(0, 12)
        Me.lblMailAddress.TabIndex = 9
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(126, 99)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(0, 12)
        Me.lblPass.TabIndex = 10
        '
        'lblAuthority
        '
        Me.lblAuthority.AutoSize = True
        Me.lblAuthority.Location = New System.Drawing.Point(126, 130)
        Me.lblAuthority.Name = "lblAuthority"
        Me.lblAuthority.Size = New System.Drawing.Size(0, 12)
        Me.lblAuthority.TabIndex = 11
        '
        'dlgConfirmation
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(523, 291)
        Me.Controls.Add(Me.lblAuthority)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblMailAddress)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgConfirmation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "確認フォーム"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblConfirmation As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblMailAddress As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblAuthority As System.Windows.Forms.Label

End Class
