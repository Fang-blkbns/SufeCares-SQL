Imports System.Data.SqlClient

Public Class 忘记密码
    Private Sub TextBoxUserName_Leave(sender As Object, e As EventArgs) Handles TextBoxUserName.Leave
        ' 校验格式
        If Not System.Text.RegularExpressions.Regex.IsMatch(TextBoxUserName.Text, "^\d{8}$") Then
            MsgBox("用户名必须为8位数字！")
            TextBoxUserName.Text = ""
            TextBoxUserName.Focus()
            Return
        End If

        ' 查询数据库判断用户名是否存在
        Dim connStr As String = "Initial catalog=sufe cares; data source=FULL-MOON111\SQLSEVER;integrated security=true;"
        Using conn As New SqlConnection(connStr)
            Dim sql As String = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@UserName", TextBoxUserName.Text)
                Try
                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count = 0 Then
                        MsgBox("用户名错误！")
                        TextBoxUserName.Text = ""
                        TextBoxUserName.Focus()
                    End If
                    ' 如果存在，什么都不做，允许后续操作
                Catch ex As Exception
                    MsgBox("数据库连接失败：" & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        ' 假设 TextBoxPassword 是“设置密码”，TextBoxConfirm 是“确认密码”
        If TextBoxPassword.Text <> TextBoxConfirm.Text Then
            MsgBox("两次输入的密码不一致，请重新输入！")
            TextBoxPassword.Text = ""
            TextBoxConfirm.Text = ""
            TextBoxPassword.Focus()
            Return
        End If

        ' 更新数据库中该用户的密码
        Dim connStr As String = "Initial catalog=sufe cares; data source=FULL-MOON111\SQLSEVER;integrated security=true;"
        Using conn As New SqlConnection(connStr)
            Dim sql As String = "UPDATE Users SET Password = @Password WHERE UserName = @UserName"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Password", TextBoxPassword.Text)
                cmd.Parameters.AddWithValue("@UserName", TextBoxUserName.Text)
                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("修改成功！")
                        Me.Close()
                    Else
                        MsgBox("用户名不存在，无法修改密码！")
                    End If
                Catch ex As Exception
                    MsgBox("修改失败：" & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class