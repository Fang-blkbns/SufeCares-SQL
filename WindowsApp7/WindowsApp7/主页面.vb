Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class 主页面

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim map As New 今天吃什么
        今天吃什么.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim map As New 随机生成食物
        随机生成食物.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim map As New 个人中心
        个人中心.ShowDialog()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim loginForm As New 校味互鉴()
        loginForm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim loginForm As New 推荐()
        loginForm.ShowDialog()
    End Sub

    ' 主页面.vb 或 推荐.vb

    Private Sub 主页面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(865, 560)
        If GlobalData.UserPermission = 0 Then ' 游客
            Button2.Enabled = False

        ElseIf GlobalData.UserPermission = 1 Then ' 普通用户
            Button2.Enabled = True

        End If
    End Sub

    Private connString As String = "Data Source=FULL-MOON111\SQLSEVER;Initial Catalog=sufe;Integrated Security=True"
    Dim ds As New DataSet
    Dim conn As New SqlConnection("Database=sufe;Data Source=FULL-MOON111\SQLSEVER;Integrated security=True")
    Dim adapter As New SqlDataAdapter("", conn)

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' 获取TextBox1中输入的菜品名称
        Dim dishName As String = TextBox1.Text ' 假设输入框名为TextBox1

        ' 构建查询对应菜品的SQL语句
        Dim sql As String = "SELECT * FROM Dishes WHERE DishName LIKE @DishName"

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(sql, conn)
                ' 添加参数，模糊查询菜品名称
                cmd.Parameters.AddWithValue("@DishName", "%" & dishName & "%")

                adapter.SelectCommand = cmd

                adapter.Fill(ds, "Dishes")

                ' 将查询结果显示到DataGridView1
                DataGridView1.DataSource = ds.Tables("Dishes")
            End Using
        End Using
    End Sub
End Class
Module GlobalData
    Public UserPermission As Integer = 0 ' 0=游客，1=普通用户
End Module
