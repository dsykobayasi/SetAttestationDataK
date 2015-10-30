Imports System.Windows.Forms

Public Class dlgConfirmation

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'MsgBox(Me.DialogResult)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgConfirmation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblHeader.Text = gDlgHeaderMsg
        lblConfirmation.Text = gDlgConfirmationMsg
        lblMailAddress.Text = gMailAddress
        lblPass.Text = gPassWord
        lblAuthority.Text = gAuthority
    End Sub
End Class
