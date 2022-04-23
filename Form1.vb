Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSend.Click

        Dim user As String
        Dim pass As String
        user = txtUser.Text
        pass = txtPass.Text

        'MsgBox("User: " & user)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub


End Class
