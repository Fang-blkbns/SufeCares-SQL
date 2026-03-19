Imports System.Data.SqlClient

'一级模块：菜品管理页面
Public Class adminisitrator

    '大模块1：查询页面——————————————————————————
    Dim conn As New SqlConnection("Database=sufe;Data Source=FULL-MOON111\SQLSEVER;Integrated security=True")
    Dim ds As New DataSet
    Dim adapter As New SqlDataAdapter("", conn)
    Dim sql As String
    '大模块2：删改界面——————————————————————————
    Dim listsql As String = "select * from Dishes"
    Dim mybs As New BindingSource
    Dim mybind As BindingManagerBase



    ''Private Sub AdministratorForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    ''    '大模块1：查询页面——————————————————————————

    ''    ''TODO: 这行代码将数据加载到表“_sufe_cares_db_2_DataSet.Category”中。您可以根据需要移动或移除它。
    ''    'Me.CategoryTableAdapter.Fill(Me._sufe_cares_db_2_DataSet.Category)
    ''    ''TODO: 这行代码将数据加载到表“_sufe_cares_db_2_DataSet.Dishes”中。您可以根据需要移动或移除它。
    ''    'Me.DishesTableAdapter.Fill(Me._sufe_cares_db_2_DataSet.Dishes)
    ''    ''TODO: 这行代码将数据加载到表“_sufe_cares_db_2_DataSet.Canteen”中。您可以根据需要移动或移除它。
    ''    'Me.CanteenTableAdapter.Fill(Me._sufe_cares_db_2_DataSet.Canteen)

    '    '模块：信息查询下拉框
    '    '菜品数据
    '    sql = "select * from Dishes"
    '    adapter.SelectCommand.CommandText = sql
    '    adapter.Fill(ds, "Dishes")
    '    DataGridView1.DataSource = ds.Tables("Dishes")

    '    '食堂下拉框canteenTable
    '    sql = "select distinct CanteenName 
    '           from Dishes join Canteen 
    '           on Canteen.CanteenID=Dishes.CanteenID "
    '    adapter.SelectCommand.CommandText = sql
    '    Dim canteenTable As New DataTable("Canteens")
    '    adapter.Fill(canteenTable)
    '    ComboBox1.DataSource = canteenTable
    '    ComboBox1.DisplayMember = "CanteenName"

    '    '食品种类下拉框categoryTable
    '    sql = "select distinct CategoryName 
    '           from Dishes 
    '           join Category on Category.CategoryID=Dishes.CategoryID "
    '    adapter.SelectCommand.CommandText = sql
    '    Dim categoryTable As New DataTable("Categories")
    '    adapter.Fill(categoryTable)
    '    ComboBox2.DataSource = categoryTable
    '    ComboBox2.DisplayMember = "CategoryName"


    '    ' 设置TextBox1和TextBox2为只读
    '    TextBox1.ReadOnly = True
    '    TextBox2.ReadOnly = True


    'MessageBox.Show("加载数据时出错: " & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)


    'Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    '    Dim CanteenName As String
    '    CanteenName = Str(ComboBox1.Text)
    '    sql = "select avg(price),count( DishID ) from 食堂 where '" & "CanteenName" & "'"
    'End Sub

    'Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
    '    Dim CategoryName As String
    '    CategoryName = Str(ComboBox2.Text)
    '    sql = "select avg(price),count( DishID ) from 食堂 where '" & "CategoryName" & "'"
    'End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 获取ComboBox1（食堂）和ComboBox2（菜品分类）选中的值
        Dim selectedCanteen As String = ComboBox1.Text
        Dim selectedCategory As String = ComboBox2.Text
        Dim sql As String = "SELECT COUNT(DishID) AS TotalCount, AVG(Rating) AS AvgRating " &
                    "FROM Dishes " &
                    "JOIN Canteen ON Dishes.CanteenID = Canteen.CanteenID " &
                    "JOIN Category ON Dishes.CategoryID = Category.CategoryID " &
                    "WHERE Canteen.CanteenName = @CanteenName AND Category.CategoryName = @CategoryName"
        ' 构建查询菜品总数量和平均评分的SQL语句


        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(sql, conn)
                ' 添加参数，避免SQL注入
                cmd.Parameters.AddWithValue("@CanteenName", selectedCanteen)
                cmd.Parameters.AddWithValue("@CategoryName", selectedCategory)

                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' 将查询结果显示到TextBox1和TextBox2
                    TextBox1.Text = reader("TotalCount").ToString()
                    TextBox2.Text = reader("AvgRating").ToString()
                Else
                    TextBox1.Text = "0"
                    TextBox2.Text = "0"
                    MessageBox.Show("未找到对应条件的菜品数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    '大模块2：删改界面——————————————————————————

    '    adapter.Fill(ds, "Dishes")
    '    mybs.DataSource = ds.Tables("Dishes")

    '    mybs.Position = 0

    '    TextBox3.DataBindings.Add(New Binding("text", mybs, "DishID"))
    '    TextBox4.DataBindings.Add(New Binding("text", mybs, "DishName"))
    '    TextBox5.DataBindings.Add(New Binding("text", mybs, "CanteenID"))
    '    TextBox6.DataBindings.Add(New Binding("text", mybs, "CategoryID"))
    '    TextBox7.DataBindings.Add(New Binding("text", mybs, "Description"))
    '    TextBox8.DataBindings.Add(New Binding("text", mybs, "Calories"))
    '    TextBox9.DataBindings.Add(New Binding("text", mybs, "Protein"))
    '    TextBox10.DataBindings.Add(New Binding("text", mybs, "Carbs"))
    '    TextBox11.DataBindings.Add(New Binding("text", mybs, "ImagePath"))


    'End Sub


    ' 窗体加载时初始化数据
    Private Sub AdministratorForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDishesData()
    End Sub

    ' 加载菜品数据到 DataGridView 和 BindingSource
    Private Sub LoadDishesData()
        Try
            Dim sql As String = "SELECT * FROM Dishes"
            adapter = New SqlDataAdapter(sql, connString)
            ds.Tables.Clear()
            adapter.Fill(ds, "Dishes")

            mybs.DataSource = ds.Tables("Dishes")
            DataGridView1.DataSource = mybs

            ' 数据绑定到 TextBox（与你现有代码一致）
            TextBox3.DataBindings.Add(New Binding("Text", mybs, "DishID"))
            TextBox4.DataBindings.Add(New Binding("Text", mybs, "DishName"))
            TextBox5.DataBindings.Add(New Binding("Text", mybs, "CanteenID"))
            TextBox6.DataBindings.Add(New Binding("Text", mybs, "CategoryID"))
            TextBox7.DataBindings.Add(New Binding("Text", mybs, "Description"))
            TextBox8.DataBindings.Add(New Binding("Text", mybs, "Calories"))
            TextBox9.DataBindings.Add(New Binding("Text", mybs, "Protein"))
            TextBox10.DataBindings.Add(New Binding("Text", mybs, "Carbs"))
            TextBox11.DataBindings.Add(New Binding("Text", mybs, "ImagePath"))

        Catch ex As Exception
            MessageBox.Show($"数据加载失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' 获取DishNameTextBox1中输入的菜品名称
        Dim dishName As String = DishNameTextBox1.Text ' 假设输入框名为DishNameTextBox1

        ' 构建查询对应菜品的SQL语句
        Dim sql As String = "SELECT * FROM Dishes WHERE DishName LIKE @DishName"

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(sql, conn)
                ' 添加参数，模糊查询菜品名称
                cmd.Parameters.AddWithValue("@DishName", "%" & dishName & "%")

                adapter.SelectCommand = cmd
                ds.Tables("Dishes").Clear() ' 清空之前的菜品数据
                adapter.Fill(ds, "Dishes")

                ' 将查询结果显示到DataGridView1
                DataGridView1.DataSource = ds.Tables("Dishes")
            End Using
        End Using
    End Sub

    '大模块1：查询页面——————————————————————————
    ''      Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ''          '模块：点击按钮1，选择combobox12里的东西，进行统计
    ''          Dim CanteenName As String
    ''          Dim CategoryName As String
    ''          CanteenName = ComboBox1.Text
    ''          CategoryName = ComboBox2.Text
    ''          sql = "SELECT COUNT(DishID), AVG(price) " &
    ''    "FROM Dishes " &
    ''    "WHERE CanteenName = '" & Me.ComboBox1.Text & "'" & "AND" & "CategoryName='" & Me.ComboBox2.Text & "'"
    ''          adapter.SelectCommand.CommandText = sql

    ''          If ds.Tables("均值数目") IsNot Nothing Then
    ''              ds.Tables("均值数目").Clear()
    ''          End If '是否有内容的判断，如果有就清空

    ''          '在textbox12中展示统计结果
    ''          adapter.Fill(ds, "均值数目")
    ''          TextBox1.Text = Str(ds.Tables("均值数目").Rows(0).Item(0))
    ''          TextBox2.Text = Str(ds.Tables("均值数目").Rows(0).Item(1))

    ''          '模块：点击按钮1，选择combobox12里的东西，进行查询
    ''          sql = "
    ''select * from dishes  
    ''join Canteen on Canteen.CanteenID=Dishes.CanteenID  
    ''join Category on Category.CategoryID=Dishes.CategoryID 
    ''where CanteenName='" & Me.ComboBox1.Text & "'" & "AND CategoryName‘" & Me.ComboBox2.Text & "'"
    ''          adapter.SelectCommand.CommandText = sql
    ''          If ds.Tables("查询结果") IsNot Nothing Then
    ''              ds.Tables("查询结果").Clear()
    ''          End If
    ''          adapter.Fill(ds, "查询结果")
    ''          DataGridView1.DataSource = ds.Tables("查询结果")

    ''      End Sub

    '大模块2：删改界面——————————————————————————
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mybs.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 1. 校验是否选中行
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("请先选中要替换的菜品行！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. 校验输入（可扩展更严格的格式校验）
        If String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("菜品名称不能为空！", "输入校验", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 3. 获取选中行的 DishID（主键，用于定位更新记录）
            Dim dishID As String = DataGridView1.SelectedRows(0).Cells("DishID").Value.ToString()

            ' 4. 拼接 UPDATE SQL（字段需与数据库表结构匹配）
            Dim sqlUpdate As String = "UPDATE Dishes " &
                                  "SET DishName=@DishName, CanteenID=@CanteenID, CategoryID=@CategoryID, " &
                                  "Description=@Description, Calories=@Calories, Protein=@Protein, " &
                                  "Carbs=@Carbs, ImagePath=@ImagePath " &
                                  "WHERE DishID=@DishID"

            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand(sqlUpdate, conn)
                    ' 5. 参数化赋值（注意包含 WHERE 条件的 DishID）
                    cmd.Parameters.AddWithValue("@DishName", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@CanteenID", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@CategoryID", TextBox6.Text)
                    cmd.Parameters.AddWithValue("@Description", TextBox7.Text)
                    cmd.Parameters.AddWithValue("@Calories", TextBox8.Text)
                    cmd.Parameters.AddWithValue("@Protein", TextBox9.Text)
                    cmd.Parameters.AddWithValue("@Carbs", TextBox10.Text)
                    cmd.Parameters.AddWithValue("@ImagePath", TextBox11.Text)
                    cmd.Parameters.AddWithValue("@DishID", dishID)

                    conn.Open()
                    ' 6. 执行更新
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' 7. 刷新 DataGridView（重新加载数据或直接更新行）
                        ds.Tables("Dishes").Clear()
                        adapter.Fill(ds, "Dishes")
                        mybs.DataSource = ds.Tables("Dishes")
                        MessageBox.Show("菜品信息替换成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("替换失败，可能数据未变更或记录不存在！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"数据库操作异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ''Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    ''        mybs.RemoveCurrent()

    ''        mybs.EndEdit()

    ''        Dim c As New SqlCommandBuilder(adapter)
    ''        If String.IsNullOrEmpty(TextBox6.Text) Then
    ''            MessageBox.Show("CategoryID cannot be empty.")
    ''        Else adapter.Update(ds.Tables("Dishes"))
    ''        End If
    ''        '列整成允许空值

    ''    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mybs.EndEdit()
        Dim c As New SqlCommandBuilder(adapter)
        adapter.Update(ds.Tables("Dishes"))
    End Sub


    '搜索过程
    Private Sub SetColumnHeaders()
        If DataGridView1.Columns.Count >= 3 Then
            DataGridView1.Columns(0).HeaderText = "菜品名"
            DataGridView1.Columns(1).HeaderText = "价格"
            DataGridView1.Columns(2).HeaderText = "评分"
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub
    Private connString As String = "Data Source=FULL-MOON111\SQLSEVER;Initial Catalog=sufe;Integrated Security=True"
    Private Sub QueryByCanteen(canteenID As Integer)
        Using conn As New SqlConnection(connString)
            ' 简化SQL：直接拼接ID（仅演示，实际应使用参数化）
            Dim sql As String = "SELECT DishName, price, rating FROM Dishes " &
                           "WHERE CanteenID = canteenID ORDER BY rating DESC"
            Dim adapter As New SqlDataAdapter(sql, conn)

            Try
                ds.Tables.Clear()
                adapter.Fill(ds, "Dishes")

                If ds.Tables("Dishes").Rows.Count > 0 Then
                    DataGridView1.DataSource = ds.Tables("Dishes")
                    SetColumnHeaders()
                Else
                    MessageBox.Show("没有菜品", "提示")
                End If
            Catch ex As Exception
                MessageBox.Show($"查询失败: {ex.Message}", "错误")
            End Try
        End Using
    End Sub

    '在 TextBox 中输入图片路径并按下回车键时，会将路径对应的图片显示在 PictureBox 中
    Private Sub TextBox11_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox11.KeyDown
        ' 检查是否按下了回车键
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' 阻止回车的默认行为（如换行）

            ' 获取文本框中的图片路径
            Dim imagePath As String = TextBox11.Text.Trim()

            ' 验证路径是否为空
            If String.IsNullOrEmpty(imagePath) Then
                MessageBox.Show("请输入有效的图片路径", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' 验证文件是否存在
            If Not System.IO.File.Exists(imagePath) Then
                MessageBox.Show("指定的文件不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' 尝试加载图片
            Try
                ' 先释放当前图片资源（如果有）
                If PictureBox1.Image IsNot Nothing Then
                    PictureBox1.Image.Dispose()
                    PictureBox1.Image = Nothing
                End If

                ' 加载新图片
                PictureBox1.Image = Image.FromFile(imagePath)

                ' 可选择设置图片的显示方式
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            Catch ex As Exception
                ' 处理加载图片时可能出现的异常
                MessageBox.Show($"无法加载图片: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub





    '附加模块：关闭管理员窗体之后，之前的窗体可以重新展示_____________________
    'Private Sub AdministratorForm2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    ' 显示之前的窗体
    '    'Form1.Show()
    'End Sub
    '在窗体类中添加右键菜单
    Private contextMenu As New ContextMenuStrip

    Private Sub adminisitrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1000, 700)
        contextMenu.Items.Add("删除该菜品")
        AddHandler contextMenu.Items(0).Click, AddressOf DeleteSelectedDish
        AddHandler DataGridView1.MouseDown, AddressOf DataGridView1_MouseDown
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Dim hit As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then
                DataGridView1.ClearSelection()
                DataGridView1.Rows(hit.RowIndex).Selected = True
                contextMenu.Show(DataGridView1, e.Location)
            End If
        End If
    End Sub

    Private Sub DeleteSelectedDish(sender As Object, e As EventArgs)
        ' 检查是否有选中的行
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result = MessageBox.Show("确定要删除该菜品吗？", "确认删除", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' 获取选中行的 DishID
                Dim dishID As String = DataGridView1.SelectedRows(0).Cells("DishID").Value.ToString()
                Dim sql As String = "DELETE FROM Dishes WHERE DishID=@DishID"

                Using conn As New SqlConnection(connString)
                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@DishID", dishID)
                        conn.Open()
                        ' 执行删除操作
                        Dim affectedRows As Integer = cmd.ExecuteNonQuery()
                        If affectedRows > 0 Then
                            ' 从 DataGridView 中移除选中的行
                            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
                            MessageBox.Show("删除成功！")
                        Else
                            MessageBox.Show("删除失败，未找到对应的菜品！")
                        End If
                    End Using
                End Using
            End If
        Else
            MessageBox.Show("请先选中要删除的菜品行！")
        End If
    End Sub


End Class