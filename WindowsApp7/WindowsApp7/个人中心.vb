Public Class 个人中心
    Private Sub 个人中心_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(865, 560)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim map As New 我的收藏
        我的收藏.ShowDialog()
    End Sub
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sufe_caresDataSet)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "选择头像图片"
        ofd.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp|所有文件|*.*"
        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox2.Image = Image.FromFile(ofd.FileName)
            Catch ex As Exception
                MsgBox("无法加载图片：" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim loginForm As New 我的评论()
        loginForm.ShowDialog()
    End Sub
    Private Sub CommentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CommentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sufe_caresDataSet)
    End Sub

    Private Function CommentsBindingSource() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MessageBox.Show("确定要退出登录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Dim openForms = Application.OpenForms.OfType(Of Form)().ToList()
        For Each frm As Form In openForms
            frm.Close()
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim loginForm As New 忘记密码()
        loginForm.ShowDialog()
    End Sub
End Class
