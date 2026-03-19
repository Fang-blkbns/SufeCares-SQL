Imports System.Data.SqlClient
Imports System.IO
Public Class 今天吃什么
    Private Sub LoadCanteenImage(canteenID As Integer)
        PictureBox1.Image = Image.FromFile(
        Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            GetCanteenPath(canteenID)
        )
    )
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Private Function GetCanteenPath(canteenID As Integer) As String
        Using conn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security=true;"),
          cmd As New SqlCommand("SELECT ImagePath FROM canteen WHERE CanteenID=@canteenid", conn)

            cmd.Parameters.AddWithValue("@canteenid", canteenID)
            conn.Open()
            Return cmd.ExecuteScalar().ToString()
        End Using
    End Function


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


    Private Sub MapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapToolStripMenuItem.Click
        Dim map As New map
        map.ShowDialog()
    End Sub

    Private Sub 第一食堂ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 第一食堂ToolStripMenuItem.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        LoadCanteenImage(1)
    End Sub

    Private Sub 第二食堂ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 第二食堂ToolStripMenuItem.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        LoadCanteenImage(2)
    End Sub

    Private Sub 第三食堂ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 第三食堂ToolStripMenuItem.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        LoadCanteenImage(3)
    End Sub

    Private Sub 第四食堂ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 第四食堂ToolStripMenuItem.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        LoadCanteenImage(4)
    End Sub

    Private Sub 第六食堂ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 第六食堂ToolStripMenuItem.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        LoadCanteenImage(5)
    End Sub

    Private Sub 库迪咖啡ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 库迪咖啡ToolStripMenuItem.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        LoadCanteenImage(6)
    End Sub

    Private Sub 蜜雪冰城ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 蜜雪冰城ToolStripMenuItem.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        LoadCanteenImage(7)
    End Sub

    Private Sub DishesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DishesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SufeDataSet)

    End Sub

    Private Sub SetDataGridView1Columns(dgv As DataGridView)
        dgv.Columns(0).HeaderText = "菜品名"
        dgv.Columns(1).HeaderText = "价格"
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub 正餐ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 正餐ToolStripMenuItem.Click
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname, Price FROM Dishes WHERE canteenID=1 and CategoryID=2", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "dishes")
        Me.DataGridView1.DataSource = mydataset.Tables("dishes")
        SetDataGridView1Columns(DataGridView1)
    End Sub

    Private Sub 正餐ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 正餐ToolStripMenuItem1.Click
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname, Price FROM Dishes WHERE canteenID=2 and CategoryID=1", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "dishes")
        Me.DataGridView1.DataSource = mydataset.Tables("dishes")
        SetDataGridView1Columns(DataGridView1)
    End Sub

    Private Sub 饮品小食ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 饮品小食ToolStripMenuItem1.Click

        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname, Price FROM Dishes WHERE canteenID=2 and CategoryID=2", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "dishes")
        Me.DataGridView1.DataSource = mydataset.Tables("dishes")
        SetDataGridView1Columns(DataGridView1)
    End Sub

    Private Sub 早点ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname, Price FROM Dishes WHERE canteenID=3 and CategoryID=1", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "dishes")
        Me.DataGridView1.DataSource = mydataset.Tables("dishes")
        SetDataGridView1Columns(DataGridView1)
    End Sub

    Private Sub 正餐ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles 正餐ToolStripMenuItem2.Click
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname, Price FROM Dishes WHERE canteenID=3 and CategoryID=2", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "dishes")
        Me.DataGridView1.DataSource = mydataset.Tables("dishes")
        SetDataGridView1Columns(DataGridView1)
    End Sub

    Private Sub 饮品小食ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles 饮品小食ToolStripMenuItem2.Click
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname, Price FROM Dishes WHERE canteenID=3 and CategoryID=3", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "dishes")
        Me.DataGridView1.DataSource = mydataset.Tables("dishes")
        SetDataGridView1Columns(DataGridView1)
    End Sub

    Private Sub 正餐ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles 正餐ToolStripMenuItem3.Click
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname, Price FROM Dishes WHERE canteenID=4 and CategoryID=2", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "dishes")
        Me.DataGridView1.DataSource = mydataset.Tables("dishes")
        SetDataGridView1Columns(DataGridView1)
    End Sub

    Private Sub 饮品小食ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles 饮品小食ToolStripMenuItem3.Click
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname, Price FROM Dishes WHERE canteenID=4 and CategoryID=3", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "dishes")
        Me.DataGridView1.DataSource = mydataset.Tables("dishes")
        SetDataGridView1Columns(DataGridView1)
    End Sub

    Private Sub 饮品小食品ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 饮品小食品ToolStripMenuItem.Click
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname, Price FROM Dishes WHERE canteenID=1 and CategoryID=3", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "dishes")
        Me.DataGridView1.DataSource = mydataset.Tables("dishes")
        SetDataGridView1Columns(DataGridView1)
    End Sub

    Private Sub 正餐ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles 正餐ToolStripMenuItem4.Click
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname, Price FROM Dishes WHERE canteenID=5 and CategoryID=2", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "dishes")
        Me.DataGridView1.DataSource = mydataset.Tables("dishes")
        SetDataGridView1Columns(DataGridView1)
    End Sub

    Private Sub 饮品小食ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles 饮品小食ToolStripMenuItem4.Click
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname, Price FROM Dishes WHERE canteenID=5 and CategoryID=3", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "dishes")
        Me.DataGridView1.DataSource = mydataset.Tables("dishes")
        SetDataGridView1Columns(DataGridView1)
    End Sub



    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim dishName As String = DataGridView1.Rows(e.RowIndex).Cells("Dishname").Value.ToString()
            Dim dishTable As DataTable = GetDishDetails(dishName)
            Dim form4 As New 菜品详情()
            form4.dishname = dishName
            If dishTable.Rows.Count > 0 Then
                form4.TextBox1.Text = dishTable.Rows(0)("Rating").ToString()
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

    Private Sub 今天吃什么_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(865, 560)
    End Sub

End Class

