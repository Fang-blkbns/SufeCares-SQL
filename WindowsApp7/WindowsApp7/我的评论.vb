Imports System.Data.SqlClient

Public Class 我的评论
    Private Sub 我的评论_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(865, 560)
        Me.CommentsTableAdapter.Fill(Me.SufeDataSet2.Comments)
        Dim myconn As New SqlConnection("Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security=true;")
        Dim myadapter As New SqlDataAdapter("SELECT CommentContent, CommentTime FROM Comments ", myconn)
        Dim mydataset As New DataSet
        myadapter.Fill(mydataset, "comments")
        Me.DataGridView1.DataSource = mydataset.Tables("comments")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
End Class