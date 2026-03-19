Imports System.Data.SqlClient

Public Class 管理员登录
    Private Sub ButtonLogin1_Click(sender As Object, e As EventArgs) Handles ButtonLogin1.Click
        Dim myconn As New SqlConnection("Initial catalog=sufe cares; data source=FULL-MOON111\SQLSEVER;integrated security=true;")
        Dim mysql As String = "SELECT * FROM Admins WHERE AdminName = '" & Me.AdminName.Text & "' AND PasswordHash = '" & Me.AdminPassword.Text & "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        Dim mydb As New DataSet()
        myadapter.Fill(mydb, "Admins")
        If mydb.Tables("Admins").Rows.Count = 0 Then
            MsgBox("用户名或密码错误！")
            Me.AdminPassword.Text = ""
            Me.AdminName.Text = ""
        Else
            MsgBox("登录成功！")
            Me.Hide()
            Dim mainForm As New adminisitrator
            mainForm.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class