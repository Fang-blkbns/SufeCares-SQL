Imports System.Data.SqlClient
Public Class 评价

    Private currentDishID As Integer = 0

    Public Sub SetDishID(dishID As Integer)
        currentDishID = dishID
        LoadComments()
    End Sub

    Private Sub LoadComments()
        If currentDishID <= 0 Then Return

        Try
            Using conn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security=true;")
                conn.Open()
                Dim sql As String = "SELECT commentcontent, commenttime FROM Comments WHERE dishid=@dishid ORDER BY commenttime DESC"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@dishid", currentDishID)

                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    DataGridView1.DataSource = Nothing
                    DataGridView1.Columns.Clear()
                    Dim contentCol As New DataGridViewTextBoxColumn()
                    contentCol.Name = "commentcontent"
                    contentCol.HeaderText = "评论内容"
                    contentCol.DataPropertyName = "commentcontent"
                    contentCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    DataGridView1.Columns.Add(contentCol)
                    Dim timeCol As New DataGridViewTextBoxColumn()
                    timeCol.Name = "commenttime"
                    timeCol.HeaderText = "评论时间"
                    timeCol.DataPropertyName = "commenttime"
                    timeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    DataGridView1.Columns.Add(timeCol)

                    DataGridView1.DataSource = dataTable

                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"加载评论失败: {ex.Message}")
        End Try
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentDishID <= 0 Then
            MessageBox.Show("请先选择菜品")
            Return
        End If

        Dim commentText As String = TextBox1.Text.Trim()
        If commentText = "" Then
            MessageBox.Show("请输入评论内容")
            TextBox1.Focus()
            Return
        End If


        Try
            Using conn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security=true;")
                conn.Open()
                Dim sql As String = "INSERT INTO Comments (dishid, userid, commentcontent, commenttime) VALUES (@dishid, @userid, @content, GETDATE())"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@dishid", currentDishID)
                    cmd.Parameters.AddWithValue("@userid", 22)
                    cmd.Parameters.AddWithValue("@content", commentText)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            TextBox1.Clear()
            LoadComments()
            MessageBox.Show("评论提交成功！")
        Catch ex As Exception
            MessageBox.Show($"提交评论失败: {ex.Message}")
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Resize
        If DataGridView1.Columns.Count > 0 Then
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
        If GlobalData.UserPermission = 0 Then ' 游客
            Button1.Enabled = False

        ElseIf GlobalData.UserPermission = 1 Then ' 普通用户
            Button1.Enabled = True

        End If
    End Sub
    Private Sub 评价_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(865, 560)
    End Sub
End Class
