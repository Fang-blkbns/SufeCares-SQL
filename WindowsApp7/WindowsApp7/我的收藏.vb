Imports System.Data.SqlClient

Public Class 我的收藏
    Private Sub 我的收藏_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(865, 560)
        DataGridView1.Size = New Size(400, 300)
        DataGridView1.Location = New Point((Me.ClientSize.Width - DataGridView1.Width) \ 2, (Me.ClientSize.Height - DataGridView1.Height) \ 2)
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;")
        Dim myadapter As New SqlDataAdapter("SELECT Dishname FROM marks ", myconn)

        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "marks")
        Me.DataGridView1.DataSource = mydataset.Tables("marks")
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
End Class