Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class 首页
    Private Sub 首页_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(865, 560)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GlobalData.UserPermission = 1 ' 普通用户
        Dim loginForm As New 用户登录()
        loginForm.ShowDialog()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim loginForm As New 管理员登录()
        loginForm.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GlobalData.UserPermission = 0 ' 游客
        Dim mainForm As New 主页面()
        mainForm.ShowDialog()
    End Sub

    Dim tempI As Image

        Private Sub 登录_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' 初始化所有Timer
            Timer1.Interval = 100
            Timer2.Interval = 100
            Timer3.Interval = 100
            Timer4.Interval = 100
            Timer5.Interval = 100
            Timer6.Interval = 100
            Timer7.Interval = 100

            Timer1.Enabled = True
            tempI = PictureBox4.Image

            ' 隐藏其余帧
            For i = 5 To 11
                Controls("PictureBox" & i).Visible = False
            Next
        End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static PickBmp As Integer
        If PickBmp = 0 Then
            PictureBox4.Image = PictureBox5.Image
            PickBmp = 1
        ElseIf PickBmp = 1 Then
            PictureBox4.Image = PictureBox6.Image
            PickBmp = 2
        ElseIf PickBmp = 2 Then
            PictureBox4.Image = PictureBox7.Image
            PickBmp = 3
        ElseIf PickBmp = 3 Then
            PictureBox4.Image = PictureBox8.Image
            PickBmp = 4
        ElseIf PickBmp = 4 Then
            PictureBox4.Image = PictureBox9.Image
            PickBmp = 5
        ElseIf PickBmp = 5 Then
            PictureBox4.Image = PictureBox10.Image
            PickBmp = 6
        ElseIf PickBmp = 6 Then
            PictureBox4.Image = PictureBox11.Image
            PickBmp = 0
        End If
    End Sub
End Class


