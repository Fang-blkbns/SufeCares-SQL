<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 我的评论
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(我的评论))
        Me.SufeDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SufeDataSet2 = New WindowsApp7.sufeDataSet2()
        Me.CommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommentsTableAdapter = New WindowsApp7.sufeDataSet2TableAdapters.CommentsTableAdapter()
        Me.TableAdapterManager = New WindowsApp7.sufeDataSet2TableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SufeDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SufeDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SufeDataSet2BindingSource
        '
        Me.SufeDataSet2BindingSource.DataSource = Me.SufeDataSet2
        Me.SufeDataSet2BindingSource.Position = 0
        '
        'SufeDataSet2
        '
        Me.SufeDataSet2.DataSetName = "sufeDataSet2"
        Me.SufeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CommentsBindingSource
        '
        Me.CommentsBindingSource.DataMember = "Comments"
        Me.CommentsBindingSource.DataSource = Me.SufeDataSet2
        '
        'CommentsTableAdapter
        '
        Me.CommentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CanteenTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.CommentsTableAdapter = Me.CommentsTableAdapter
        Me.TableAdapterManager.DishesTableAdapter = Nothing
        Me.TableAdapterManager.MarksTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp7.sufeDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(334, 202)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1035, 603)
        Me.DataGridView1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1693, 1034)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        '我的评论
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1694, 1034)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "我的评论"
        Me.Text = "我的评论"
        CType(Me.SufeDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SufeDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents SufeDataSet2BindingSource As BindingSource
    Friend WithEvents SufeDataSet2 As sufeDataSet2
    Friend WithEvents CommentsBindingSource As BindingSource
    Friend WithEvents CommentsTableAdapter As sufeDataSet2TableAdapters.CommentsTableAdapter
    Friend WithEvents TableAdapterManager As sufeDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
