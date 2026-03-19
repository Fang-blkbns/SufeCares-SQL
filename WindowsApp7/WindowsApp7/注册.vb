Imports System.Data.SqlClient

Public Class 注册
    ' 用户名校验
    Private Sub TextBoxUserName_Leave(sender As Object, e As EventArgs) Handles TextBoxUserName.Leave
        If Not System.Text.RegularExpressions.Regex.IsMatch(TextBoxUserName.Text, "^\d{8}$") Then
            MsgBox("用户名必须为8位数字！")
            TextBoxUserName.Text = ""
            TextBoxUserName.Focus()
        End If
        Dim connStr As String = "Initial catalog=sufe cares; data source=FULL-MOON111\SQLSEVER;integrated security=true;"
        Using conn As New SqlConnection(connStr)
            ' 先检查用户名是否已存在
            Dim checkSql As String = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName"
            Using checkCmd As New SqlCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@UserName", TextBoxUserName.Text)
                conn.Open()
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If count > 0 Then
                    MsgBox("用户名已存在，请更换用户名！")
                    TextBoxUserName.Text = ""
                    TextBoxUserName.Focus()
                    Return
                End If
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        ' 假设 TextBoxPassword 是“设置密码”，TextBoxConfirm 是“确认密码”
        If TextBoxPassword.Text <> TextBoxConfirm.Text Then
            MsgBox("两次输入的密码不一致，请重新输入！")
            TextBoxConfirm.Text = ""
            TextBoxConfirm.Focus()
            Return
        End If
        ' 数据库插入操作
        Dim connStr As String = "Initial catalog=sufe cares; data source=FULL-MOON111\SQLSEVER;integrated security=true;"
        Using conn As New SqlConnection(connStr)
            Dim sql As String = "INSERT INTO Users (UserName, Password) VALUES (@UserName, @Password)"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@UserName", TextBoxUserName.Text)
                cmd.Parameters.AddWithValue("@Password", TextBoxPassword.Text)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("注册失败：" & ex.Message)
                    Return
                End Try
            End Using
        End Using

        ' 这里写注册成功的逻辑，比如保存用户信息到数据库
        MsgBox("注册成功！")
        Me.Close()
    End Sub

End Class

