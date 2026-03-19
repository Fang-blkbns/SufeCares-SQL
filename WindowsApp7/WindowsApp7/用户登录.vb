Imports System.Data.SqlClient

Public Class 用户登录

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim myconn As New SqlConnection("Initial catalog=sufe cares; data source=FULL-MOON111\SQLSEVER;integrated security=true;")
        Dim mysql As String = "SELECT * FROM Users WHERE UserName = '" & Me.TextBoxUserName.Text & "' AND password = '" & Me.TextBoxPassword.Text & "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        Dim mydb As New DataSet()
        myadapter.Fill(mydb, "Users")
        If mydb.Tables("Users").Rows.Count = 0 Then
            MsgBox("用户名或密码错误！")
            Me.TextBoxPassword.Text = ""
            Me.TextBoxUserName.Text = ""
        Else
            MsgBox("登录成功！")
            Me.Hide()
            Dim mainForm As New 主页面()
            mainForm.ShowDialog()

            Me.Close()
        End If
    End Sub
    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim loginForm As New 注册()
        loginForm.ShowDialog()
    End Sub

    Private Sub ButtonForgotPassword_Click(sender As Object, e As EventArgs) Handles ButtonForgotPassword.Click
        Dim loginForm As New 忘记密码()
        loginForm.ShowDialog()
    End Sub
    ' 登录成功后
End Class