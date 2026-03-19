Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



Public Class 推荐
    ' 数据库连接字符串（请根据实际情况修改）
    Private connString As String = "Data Source=FULL-MOON111\SQLSEVER;Initial Catalog=sufe;Integrated Security=True"
    Dim ds2 As New DataSet



    '' 显示所有菜品（简化查询，不带条件）
    'Private Sub ShowAllDishes()
    '    Using conn As New SqlConnection(connString)
    '        ' 简化SQL：查询所有菜品，按评分排序
    '        Dim sql As String = "SELECT DishName, price, rating FROM Dishes ORDER BY rating DESC"
    '        Dim adapter As New SqlDataAdapter(sql, conn)

    '        Try
    '            ' 清空旧数据
    '            ds2.Tables.Clear()

    '            ' 执行查询
    '            adapter.Fill(ds2, "Dishes")

    '            ' 绑定到DataGridView
    '            If ds2.Tables("Dishes").Rows.Count > 0 Then
    '                DataGridView1.DataSource = ds2.Tables("Dishes")
    '                SetColumnHeaders()
    '            Else
    '                MessageBox.Show("数据库中没有菜品数据", "提示")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show($"查询失败: {ex.Message}", "错误")
    '        End Try
    '    End Using
    'End Sub
    ''' <summary>
    ''' '''''''''''''`
    ''' </summary>
    ''' <param name="dgv"></param>
    ' 设置列标题
    Private Sub SetColumnHeaders(dgv As DataGridView)
        dgv.Columns("dishname").HeaderText = "菜品名"
        dgv.Columns("price").HeaderText = "价格"
        dgv.Columns("rating").HeaderText = "评分"
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub



    '食物分类

    Dim selectedCanteenID As Integer? = 1
    Dim selectedcategoryID As Integer? = 1

    Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
    Dim ds As New DataSet
    Dim adapter As New SqlDataAdapter("", myconn)
    Dim sql As String

    ''AI
    'Private Sub SetDataGridView1Columns(dgv As DataGridView)
    '    dgv.Columns("DishName").HeaderText = "菜品名"
    '    dgv.Columns("Price").HeaderText = "价格"
    '    dgv.Columns("Rating").HeaderText = "评分"
    '    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    'End Sub
    '版本1
    'sql = "SELECT * FROM dishes  
    '       JOIN Canteen ON Canteen.CanteenID = Dishes.CanteenID  
    '       JOIN Category ON Category.CategoryID = Dishes.CategoryID 
    '       WHERE Dishes.CanteenID = @CanteenID  
    '         AND Dishes.CategoryID = @CategoryID  
    '       ORDER BY rating DESC"

    'adapter.SelectCommand.CommandText = sql
    'adapter.SelectCommand.Parameters.Clear()
    'adapter.SelectCommand.Parameters.AddWithValue("@CanteenID", canteenIDnum)
    'adapter.SelectCommand.Parameters.AddWithValue("@CategoryID", categoryIDnum)

    'Try
    '    If ds.Tables("排行榜结果") IsNot Nothing Then
    '        ds.Tables("排行榜结果").Clear()
    '    End If

    '    adapter.Fill(ds, "排行榜结果")

    '    If ds.Tables("排行榜结果") IsNot Nothing AndAlso ds.Tables("排行榜结果").Rows.Count > 0 Then
    '        DataGridView1.DataSource = ds.Tables("排行榜结果")
    '    Else
    '        MessageBox.Show("查询结果为空！")
    '    End If
    'Catch ex As Exception
    '    MessageBox.Show($"查询失败: {ex.Message}")
    'End Try


    Public Sub form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初始化显示所有食堂和分类的菜品（简化版）
        'ShowAllDishes()

        '模块1：菜品排行榜显示列表————————
        '版本2
        'sql = "SELECT * FROM dishes  
        '       JOIN Canteen ON Canteen.CanteenID = Dishes.CanteenID  
        '       JOIN Category ON Category.CategoryID = Dishes.CategoryID 
        '       WHERE Dishes.CanteenID = @CanteenID  
        '         AND Dishes.CategoryID = @CategoryID  
        '       ORDER BY rating DESC"

        'adapter.SelectCommand.CommandText = sql
        'adapter.SelectCommand.Parameters.Clear()


        '版本3
        Dim myadapter As New SqlDataAdapter("
        SELECT DishName, price, rating 
        FROM Dishes 
        WHERE CanteenID =1 
        ORDER BY rating DESC", myconn)


        If ds.Tables.Contains("dishes") Then
            ds.Tables("dishes").Clear()
        Else
            ds.Tables.Add("dishes")
        End If

        myadapter.Fill(ds, "dishes")
        Me.DataGridView1.DataSource = ds.Tables("dishes")
        SetColumnHeaders(DataGridView1)


        '时间控件+提醒吃饭控件
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Timer2.Interval = 100
        Timer2.Enabled = True
        'TempI = PictureBox3.Image
        'PictureBox4.Visible = False
        'PictureBox5.Visible = False

    End Sub


    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        TextBox1.Text = Now.ToString()
        Dim currentTime As DateTime = Now
        Dim hour As Integer = currentTime.Hour

        ' 根据时间段显示不同提示
        Select Case hour
            Case 6 To 9 ' 早上6点-9点
                Label3.Text = "唤醒一天精神，该吃早饭啦"
                Label3.ForeColor = Color.Goldenrod

            Case 11 To 13 ' 中午11点-13点
                Label3.Text = "午餐时间到！补充能量继续战斗！ "
                Label3.ForeColor = Color.DarkOrange

            Case 16 To 18 ' 傍晚16点-18点
                Label3.Text = "夕阳西下，是时候享用晚餐了"
                Label3.ForeColor = Color.DeepSkyBlue

            Case 19 To 20 ' 晚上19点-20点
                Label3.Text = "食堂快关门啦，吃点夜宵吗 "
                Label3.ForeColor = Color.DimGray

            Case 21 To 23 ' 晚间21点-23点
                Label3.Text = "食堂已经关门了，太饿就去全家吧 "
                Label3.ForeColor = Color.MediumPurple

            Case 0 To 5 ' 凌晨0点-5点
                Label3.Text = "凌晨" & hour & "华屋万间，夜卧不过五尺；
珍馐百味，日食只需三餐。"
                Label3.ForeColor = Color.MidnightBlue
            Case Else ' 其他时间
                Label3.Text = "今天上财吃什么"

        End Select
    End Sub

    ''制作计时器动画
    'Dim TempI As Image = My.Resources.Resources.picturebox1
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick '‘’‘’‘’问了ai“多张图片如何实现动画变化？
    '    ' 静态变量，记录当前图片索引
    '    Static PickBmp As Integer

    '    If PickBmp = 0 Then
    '        PictureBox3.Image = PictureBox4.Image  ' 第2张图
    '        PickBmp = 1
    '    ElseIf PickBmp = 1 Then
    '        PictureBox3.Image = PictureBox5.Image  ' 第3张图
    '        PickBmp = 2
    '    ElseIf PickBmp = 2 Then
    '        PictureBox3.Image = TempI  ' 第4张图
    '        PickBmp = 0
    '    End If


    'End Sub


    '''!!!!!!!!!!在点击按钮时切换食堂

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Label1.Text = "绿叶食堂"
    '    Label1.ForeColor = Color.ForestGreen
    '    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    '    PictureBox2.BackColor = Color.DarkSeaGreen
    '    PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\canteen1.jpg")

    '    selectedCanteenID = 1
    '    DataGridView1.Visible = True


    '    Dim myconn As New SqlConnection("Data Source=FULL-MOON111\SQLSEVER;Initial Catalog=sufe;Integrated Security=True")
    '    Dim adapter As New SqlDataAdapter("SELECT dishname,price,rating FROM Dishes WHERE canteenID=1  order by rating DESC", myconn)
    '    Dim mydataset As New DataSet
    '    adapter.Fill(ds, "dishes")
    '    Me.DataGridView1.DataSource = mydataset.Tables("dishes")
    '    SetColumnHeaders(DataGridView1)


    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    '    Label1.Text = "清真食堂"
    '    Label1.ForeColor = Color.LightSeaGreen
    '    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    '    PictureBox2.BackColor = Color.LightSeaGreen
    '    PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\canteen2.jpg")

    '    selectedCanteenID = 2

    '    DataGridView1.Visible = True
    '    Dim myconn As New SqlConnection("Data Source=FULL-MOON111\SQLSEVER;Initial Catalog=sufe;Integrated Security=True")
    '    Dim adapter As New SqlDataAdapter("SELECT dishname,price,rating FROM Dishes WHERE canteenID=2  order by rating DESC", myconn)
    '    Dim mydataset As New DataSet
    '    adapter.Fill(ds, "dishes")
    '    Me.DataGridView1.DataSource = mydataset.Tables("dishes")
    '    SetColumnHeaders(DataGridView1)


    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    Label1.Text = "新食堂"
    '    Label1.ForeColor = Color.SteelBlue
    '    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    '    PictureBox2.BackColor = Color.LightSkyBlue
    '    PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\canteen3.jpg")

    '    selectedCanteenID = 3
    '    DataGridView1.Visible = True

    '    Dim myconn As New SqlConnection("Data Source=FULL-MOON111\SQLSEVER;Initial Catalog=sufe;Integrated Security=True")
    '    Dim adapter As New SqlDataAdapter("SELECT dishname,price,rating FROM Dishes WHERE canteenID=3  order by rating DESC", myconn)
    '    Dim mydataset As New DataSet
    '    adapter.Fill(ds, "dishes")
    '    Me.DataGridView1.DataSource = mydataset.Tables("dishes")
    '    SetColumnHeaders(DataGridView1)

    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


    '    Label1.Text = "新园食堂"
    '    Label1.ForeColor = Color.MediumPurple
    '    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    '    PictureBox2.BackColor = Color.FromArgb(207, 190, 241)
    '    PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\canteen4.jpg")

    '    selectedCanteenID = 4
    '    DataGridView1.Visible = True

    '    Dim myconn As New SqlConnection("Data Source=FULL-MOON111\SQLSEVER;Initial Catalog=sufe;Integrated Security=True")
    '    Dim adapter As New SqlDataAdapter("SELECT dishname,price,rating FROM Dishes WHERE canteenID=4  order by rating DESC", myconn)
    '    Dim mydataset As New DataSet
    '    adapter.Fill(ds, "dishes")
    '    Me.DataGridView1.DataSource = mydataset.Tables("dishes")
    '    SetColumnHeaders(DataGridView1)


    'End Sub


    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    '    Label1.Text = "西餐厅"
    '    Label1.ForeColor = Color.MediumVioletRed
    '    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    '    PictureBox2.BackColor = Color.FromArgb(227, 138, 140)
    '    PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\canteen6.jpg")

    '    selectedCanteenID = 6
    '    DataGridView1.Visible = True

    '    Dim myconn As New SqlConnection("Data Source=FULL-MOON111\SQLSEVER;Initial Catalog=sufe;Integrated Security=True")
    '    Dim adapter As New SqlDataAdapter("SELECT dishname,price,rating FROM Dishes WHERE canteenID=6  order by rating DESC", myconn)
    '    Dim mydataset As New DataSet
    '    adapter.Fill(ds, "dishes")
    '    Me.DataGridView1.DataSource = mydataset.Tables("dishes")
    '    SetColumnHeaders(DataGridView1)
    'End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    '    Label1.Text = "蜜雪冰城"
    '    Label1.ForeColor = Color.DarkGray
    '    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    '    PictureBox2.BackColor = Color.Crimson
    '    PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\mixue.jpg")
    '    DataGridView1.Visible = False

    '    Dim myconn As New SqlConnection("Data Source=FULL-MOON111\SQLSEVER;Initial Catalog=sufe;Integrated Security=True")
    '    Dim adapter As New SqlDataAdapter("SELECT dishname,price,rating FROM Dishes WHERE canteenID=7  order by rating DESC", myconn)
    '    Dim mydataset As New DataSet
    '    adapter.Fill(ds, "dishes")
    '    Me.DataGridView1.DataSource = mydataset.Tables("dishes")
    '    SetColumnHeaders(DataGridView1)

    '    selectedCanteenID = 7
    'End Sub

    'Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    '    Label1.Text = "库迪咖啡"
    '    Label1.ForeColor = Color.DarkGray
    '    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    '    PictureBox2.BackColor = Color.Crimson
    '    PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\cotti.jpg")

    '    DataGridView1.Visible = False

    '    Dim myconn As New SqlConnection("Data Source=FULL-MOON111\SQLSEVER;Initial Catalog=sufe;Integrated Security=True")
    '    Dim adapter As New SqlDataAdapter("SELECT dishname,price,rating FROM Dishes WHERE canteenID=8  order by rating DESC", myconn)
    '    Dim mydataset As New DataSet
    '    adapter.Fill(ds, "dishes")
    '    Me.DataGridView1.DataSource = mydataset.Tables("dishes")
    '    SetColumnHeaders(DataGridView1)
    '    selectedCanteenID = 8
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 绿叶食堂（假设CanteenID=1）
        ShowDishesByCanteen(1)
        Label1.Text = "绿叶食堂"
        Label1.ForeColor = Color.ForestGreen
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.BackColor = Color.DarkSeaGreen
        PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\canteen1.jpg")

        selectedCanteenID = 1
        DataGridView1.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 清真食堂（假设CanteenID=2）
        ShowDishesByCanteen(2)
        Label1.Text = "清真食堂"
        Label1.ForeColor = Color.LightSeaGreen
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.BackColor = Color.LightSeaGreen
        PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\canteen2.jpg")

        selectedCanteenID = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 新食堂（假设CanteenID=3）
        ShowDishesByCanteen(3)
        Label1.Text = "新食堂"
        Label1.ForeColor = Color.SteelBlue
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.BackColor = Color.LightSkyBlue
        PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\canteen3.jpg")

        selectedCanteenID = 3
        DataGridView1.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' 新园食堂（假设CanteenID=4）
        ShowDishesByCanteen(4)

        Label1.Text = "新园食堂"
        Label1.ForeColor = Color.MediumPurple
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.BackColor = Color.FromArgb(207, 190, 241)
        PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\canteen4.jpg")

        selectedCanteenID = 4
        DataGridView1.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' 西餐厅（假设CanteenID=6）
        ShowDishesByCanteen(6)

        Label1.Text = "西餐厅"
        Label1.ForeColor = Color.MediumVioletRed
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.BackColor = Color.FromArgb(227, 138, 140)
        PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\canteen6.jpg")

        selectedCanteenID = 6
        DataGridView1.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' 蜜雪冰城（假设CanteenID=7）
        ShowDishesByCanteen(7)
        Label1.Text = "蜜雪冰城"
        Label1.ForeColor = Color.DarkGray
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.BackColor = Color.Crimson
        PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\mixue.jpg")
        DataGridView1.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' 库迪咖啡（假设CanteenID=8）
        ShowDishesByCanteen(8)

        Label1.Text = "库迪咖啡"
        Label1.ForeColor = Color.DarkGray
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.BackColor = Color.Crimson
        PictureBox1.Image = Image.FromFile("D:\数据库\WindowsApp7 最终\WindowsApp7\WindowsApp7\bin\Debug\images\cotti.jpg")

        DataGridView1.Visible = False

    End Sub

    ' 公共方法：根据食堂ID显示菜品
    Private Sub ShowDishesByCanteen(canteenID As Integer)
        Dim connStr As String = "Data Source=FULL-MOON111\SQLSEVER;Initial Catalog=sufe;Integrated Security=True"
        Dim sql As String = "SELECT Dishname, Price, Rating FROM Dishes WHERE canteenID=@canteenID ORDER BY rating DESC"
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connStr)
            Using adapter As New SqlDataAdapter(sql, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@canteenID", canteenID)
                adapter.Fill(dt)
            End Using
        End Using
        Me.DataGridView1.DataSource = dt
        ' 设置列标题
        If DataGridView1.Columns.Count >= 3 Then
            DataGridView1.Columns("Dishname").HeaderText = "菜品名"
            DataGridView1.Columns("Price").HeaderText = "价格"
            DataGridView1.Columns("Rating").HeaderText = "评分"
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub
    Private Function GetDishDetails(dishName As String) As DataTable
        Dim connectionString As String = "Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;"
        Dim sql As String = "SELECT Rating, dishname, description, price, calories, protein, carbs, fat, imagepath, favorite_count,like_count,dislike_count
                         FROM Dishes 
                         WHERE Dishname = @Dishname"

        Using myconn As New SqlConnection(connectionString),
          myadapter As New SqlDataAdapter(sql, myconn)

            myadapter.SelectCommand.Parameters.AddWithValue("@Dishname", dishName)
            Dim mydataset As New DataSet()
            myadapter.Fill(mydataset, "dishes")
            Return mydataset.Tables("dishes")
        End Using
    End Function
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim dishName As String = DataGridView1.Rows(e.RowIndex).Cells("dishname").Value.ToString()
            Dim dishTable As DataTable = GetDishDetails(dishName)
            Dim form4 As New 菜品详情()
            form4.dishname = dishName
            If dishTable.Rows.Count > 0 Then
                form4.TextBox1.Text = dishTable.Rows(0)("rating").ToString()
                form4.TextBox2.Text = dishTable.Rows(0)("dishname").ToString()
                form4.TextBox3.Text = dishTable.Rows(0)("description").ToString()
                form4.TextBox4.Text = dishTable.Rows(0)("price").ToString()
                form4.TextBox5.Text = dishTable.Rows(0)("calories").ToString()
                form4.TextBox6.Text = dishTable.Rows(0)("protein").ToString()
                form4.TextBox7.Text = dishTable.Rows(0)("carbs").ToString()
                form4.TextBox8.Text = dishTable.Rows(0)("fat").ToString()
                form4.TextBox9.Text = dishTable.Rows(0)("favorite_count").ToString()
                form4.TextBox10.Text = dishTable.Rows(0)("like_count").ToString()
                form4.TextBox11.Text = dishTable.Rows(0)("dislike_count").ToString()
                form4.ImagePath = dishTable.Rows(0)("imagepath")?.ToString()
            Else
                form4.TextBox1.Text = "暂无评分"
                form4.ImagePath = ""
            End If

            form4.ShowDialog()
        End If
    End Sub
    Private Sub 推荐_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(865, 560)
    End Sub
End Class