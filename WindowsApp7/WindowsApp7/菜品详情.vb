Imports System.Reflection.Emit
Imports System.Data.SqlClient
Public Class 菜品详情
    Public Property dishname As String
    Public Property ImagePath As String
    ' 默认图片路径
    Private Const DEFAULT_IMAGE_PATH As String = "D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\WechatIMG2052.jpg"

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(865, 560)
        LoadDishImage()
    End Sub
    Private Sub LoadDishImage()
        Try
            If Not String.IsNullOrEmpty(ImagePath) AndAlso System.IO.File.Exists(ImagePath) Then
                ' 显示数据库中的图片
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Image = Image.FromFile(ImagePath)
            Else
                ' 显示默认图片（
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Image = Image.FromFile(DEFAULT_IMAGE_PATH)
            End If
        Catch
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dishID As Integer = GetDishIDByName(Me.dishname)
        If dishID = -1 Then
            MessageBox.Show("未找到菜品 ID，无法进入评价！")
            Return
        End If

        ' 2. 打开 Form1 并传递 dishID
        Dim form1 As New 评价()
        form1.SetDishID(dishID)  ' 关键：传递菜品 ID
        form1.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connStr As String = "Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security=true;"
        Using conn As New SqlConnection(connStr),
              cmd As New SqlCommand("SELECT COUNT(*) FROM marks WHERE dishname=@dishname", conn)
            cmd.Parameters.AddWithValue("@dishname", Me.dishname)
            conn.Open()
            If CInt(cmd.ExecuteScalar()) > 0 Then
                MessageBox.Show("已收藏该菜品！", "提示")
                Return
            End If
            UpdateDishCount(TextBox9, "favorite_count")
            cmd.CommandText = "INSERT INTO marks (dishname) VALUES (@dishname)"
            cmd.ExecuteNonQuery()
        End Using


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateDishCount(TextBox10, "like_count")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateDishCount(TextBox11, "dislike_count")
    End Sub
    Private Sub UpdateDishCount(txtBox As TextBox, fieldName As String)
        If Integer.TryParse(txtBox.Text, Nothing) Then
            txtBox.Text = (Integer.Parse(txtBox.Text) + 1).ToString()
            UpdateDatabase(dishname, fieldName, Integer.Parse(txtBox.Text))
        Else
            MessageBox.Show($"{txtBox.Name} 内容不是有效数字，无法更新！")
        End If
    End Sub
    Private Sub UpdateDatabase(dishName As String, fieldName As String, newValue As Integer)
        Dim connectionString As String = "Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security=true;"
        Dim sql As String = $"UPDATE Dishes SET {fieldName} = @NewValue WHERE Dishname = @Dishname"

        Using myconn As New SqlConnection(connectionString),
              cmd As New SqlCommand(sql, myconn)
            cmd.Parameters.AddWithValue("@NewValue", newValue)
            cmd.Parameters.AddWithValue("@Dishname", dishName)

            myconn.Open()
            Dim affectedRows As Integer = cmd.ExecuteNonQuery()
            If affectedRows = 0 Then
                MessageBox.Show("未找到对应菜品，更新失败！")
            End If
            myconn.Close()
        End Using
    End Sub
    Private Function GetDishIDByName(dishName As String) As Integer
        Dim dishID As Integer = -1
        Dim connStr As String = "Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security=true;"

        Using conn As New SqlConnection(connStr),
              cmd As New SqlCommand("SELECT dishid FROM Dishes WHERE Dishname = @Dishname", conn)

            cmd.Parameters.AddWithValue("@Dishname", dishName)
            conn.Open()

            Dim result = cmd.ExecuteScalar()
            If result IsNot DBNull.Value Then
                dishID = CInt(result)
            End If
        End Using

        Return dishID
    End Function

    Private Sub 菜品详情_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(865, 560)
        If GlobalData.UserPermission = 0 Then ' 游客
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        ElseIf GlobalData.UserPermission = 1 Then ' 普通用户
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True

        End If
    End Sub


End Class
