Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class 随机生成食物
    Private Const CONNECTION_STRING As String = "Initial catalog=sufe; data source=FULL-MOON111\SQLSEVER;integrated security= true;"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = GetRandomDishName()
    End Sub

    Private Function GetRandomDishName() As String
        Using myconn As New SqlConnection(CONNECTION_STRING)
            Dim sql As String = "SELECT TOP 1 Dishname FROM Dishes ORDER BY NEWID()"
            Using mycmd As New SqlCommand(sql, myconn)
                myconn.Open()
                Dim result As Object = mycmd.ExecuteScalar()
                Return If(result IsNot DBNull.Value, result.ToString(), "暂无菜品数据")
            End Using
        End Using
    End Function

End Class