<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 今天吃什么
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(今天吃什么))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.第一食堂ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.正餐ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.饮品小食品ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.第二食堂ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.正餐ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.饮品小食ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.第三食堂ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.正餐ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.饮品小食ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.第四食堂ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.正餐ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.饮品小食ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.第六食堂ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.正餐ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.饮品小食ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.库迪咖啡ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.蜜雪冰城ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SufeDataSet = New WindowsApp7.sufeDataSet()
        Me.DishesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DishesTableAdapter = New WindowsApp7.sufeDataSetTableAdapters.DishesTableAdapter()
        Me.TableAdapterManager = New WindowsApp7.sufeDataSetTableAdapters.TableAdapterManager()
        Me.SufeDataSet1 = New WindowsApp7.sufeDataSet1()
        Me.DishesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DishesTableAdapter1 = New WindowsApp7.sufeDataSet1TableAdapters.DishesTableAdapter()
        Me.TableAdapterManager1 = New WindowsApp7.sufeDataSet1TableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SufeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DishesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SufeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DishesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MapToolStripMenuItem, Me.第一食堂ToolStripMenuItem, Me.第二食堂ToolStripMenuItem, Me.第三食堂ToolStripMenuItem, Me.第四食堂ToolStripMenuItem, Me.第六食堂ToolStripMenuItem, Me.库迪咖啡ToolStripMenuItem, Me.蜜雪冰城ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1694, 39)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MapToolStripMenuItem
        '
        Me.MapToolStripMenuItem.Name = "MapToolStripMenuItem"
        Me.MapToolStripMenuItem.Size = New System.Drawing.Size(84, 35)
        Me.MapToolStripMenuItem.Text = "map"
        '
        '第一食堂ToolStripMenuItem
        '
        Me.第一食堂ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.正餐ToolStripMenuItem, Me.饮品小食品ToolStripMenuItem})
        Me.第一食堂ToolStripMenuItem.Name = "第一食堂ToolStripMenuItem"
        Me.第一食堂ToolStripMenuItem.Size = New System.Drawing.Size(130, 35)
        Me.第一食堂ToolStripMenuItem.Text = "第一食堂"
        '
        '正餐ToolStripMenuItem
        '
        Me.正餐ToolStripMenuItem.Name = "正餐ToolStripMenuItem"
        Me.正餐ToolStripMenuItem.Size = New System.Drawing.Size(243, 44)
        Me.正餐ToolStripMenuItem.Text = "正餐"
        '
        '饮品小食品ToolStripMenuItem
        '
        Me.饮品小食品ToolStripMenuItem.Name = "饮品小食品ToolStripMenuItem"
        Me.饮品小食品ToolStripMenuItem.Size = New System.Drawing.Size(243, 44)
        Me.饮品小食品ToolStripMenuItem.Text = "饮品小食"
        '
        '第二食堂ToolStripMenuItem
        '
        Me.第二食堂ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.正餐ToolStripMenuItem1, Me.饮品小食ToolStripMenuItem1})
        Me.第二食堂ToolStripMenuItem.Name = "第二食堂ToolStripMenuItem"
        Me.第二食堂ToolStripMenuItem.Size = New System.Drawing.Size(130, 35)
        Me.第二食堂ToolStripMenuItem.Text = "第二食堂"
        '
        '正餐ToolStripMenuItem1
        '
        Me.正餐ToolStripMenuItem1.Name = "正餐ToolStripMenuItem1"
        Me.正餐ToolStripMenuItem1.Size = New System.Drawing.Size(195, 44)
        Me.正餐ToolStripMenuItem1.Text = "早点"
        '
        '饮品小食ToolStripMenuItem1
        '
        Me.饮品小食ToolStripMenuItem1.Name = "饮品小食ToolStripMenuItem1"
        Me.饮品小食ToolStripMenuItem1.Size = New System.Drawing.Size(195, 44)
        Me.饮品小食ToolStripMenuItem1.Text = "正餐"
        '
        '第三食堂ToolStripMenuItem
        '
        Me.第三食堂ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.正餐ToolStripMenuItem2, Me.饮品小食ToolStripMenuItem2})
        Me.第三食堂ToolStripMenuItem.Name = "第三食堂ToolStripMenuItem"
        Me.第三食堂ToolStripMenuItem.Size = New System.Drawing.Size(130, 35)
        Me.第三食堂ToolStripMenuItem.Text = "第三食堂"
        '
        '正餐ToolStripMenuItem2
        '
        Me.正餐ToolStripMenuItem2.Name = "正餐ToolStripMenuItem2"
        Me.正餐ToolStripMenuItem2.Size = New System.Drawing.Size(243, 44)
        Me.正餐ToolStripMenuItem2.Text = "正餐"
        '
        '饮品小食ToolStripMenuItem2
        '
        Me.饮品小食ToolStripMenuItem2.Name = "饮品小食ToolStripMenuItem2"
        Me.饮品小食ToolStripMenuItem2.Size = New System.Drawing.Size(243, 44)
        Me.饮品小食ToolStripMenuItem2.Text = "饮品小食"
        '
        '第四食堂ToolStripMenuItem
        '
        Me.第四食堂ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.正餐ToolStripMenuItem3, Me.饮品小食ToolStripMenuItem3})
        Me.第四食堂ToolStripMenuItem.Name = "第四食堂ToolStripMenuItem"
        Me.第四食堂ToolStripMenuItem.Size = New System.Drawing.Size(130, 35)
        Me.第四食堂ToolStripMenuItem.Text = "第四食堂"
        '
        '正餐ToolStripMenuItem3
        '
        Me.正餐ToolStripMenuItem3.Name = "正餐ToolStripMenuItem3"
        Me.正餐ToolStripMenuItem3.Size = New System.Drawing.Size(243, 44)
        Me.正餐ToolStripMenuItem3.Text = "正餐"
        '
        '饮品小食ToolStripMenuItem3
        '
        Me.饮品小食ToolStripMenuItem3.Name = "饮品小食ToolStripMenuItem3"
        Me.饮品小食ToolStripMenuItem3.Size = New System.Drawing.Size(243, 44)
        Me.饮品小食ToolStripMenuItem3.Text = "饮品小食"
        '
        '第六食堂ToolStripMenuItem
        '
        Me.第六食堂ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.正餐ToolStripMenuItem4, Me.饮品小食ToolStripMenuItem4})
        Me.第六食堂ToolStripMenuItem.Name = "第六食堂ToolStripMenuItem"
        Me.第六食堂ToolStripMenuItem.Size = New System.Drawing.Size(130, 35)
        Me.第六食堂ToolStripMenuItem.Text = "第六食堂"
        '
        '正餐ToolStripMenuItem4
        '
        Me.正餐ToolStripMenuItem4.Name = "正餐ToolStripMenuItem4"
        Me.正餐ToolStripMenuItem4.Size = New System.Drawing.Size(243, 44)
        Me.正餐ToolStripMenuItem4.Text = "正餐"
        '
        '饮品小食ToolStripMenuItem4
        '
        Me.饮品小食ToolStripMenuItem4.Name = "饮品小食ToolStripMenuItem4"
        Me.饮品小食ToolStripMenuItem4.Size = New System.Drawing.Size(243, 44)
        Me.饮品小食ToolStripMenuItem4.Text = "饮品小食"
        '
        '库迪咖啡ToolStripMenuItem
        '
        Me.库迪咖啡ToolStripMenuItem.Name = "库迪咖啡ToolStripMenuItem"
        Me.库迪咖啡ToolStripMenuItem.Size = New System.Drawing.Size(130, 35)
        Me.库迪咖啡ToolStripMenuItem.Text = "库迪咖啡"
        '
        '蜜雪冰城ToolStripMenuItem
        '
        Me.蜜雪冰城ToolStripMenuItem.Name = "蜜雪冰城ToolStripMenuItem"
        Me.蜜雪冰城ToolStripMenuItem.Size = New System.Drawing.Size(130, 35)
        Me.蜜雪冰城ToolStripMenuItem.Text = "蜜雪冰城"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1072, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(589, 678)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'SufeDataSet
        '
        Me.SufeDataSet.DataSetName = "sufeDataSet"
        Me.SufeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DishesBindingSource
        '
        Me.DishesBindingSource.DataMember = "Dishes"
        Me.DishesBindingSource.DataSource = Me.SufeDataSet
        '
        'DishesTableAdapter
        '
        Me.DishesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CanteenTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.DishesTableAdapter = Me.DishesTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp7.sufeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SufeDataSet1
        '
        Me.SufeDataSet1.DataSetName = "sufeDataSet1"
        Me.SufeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DishesBindingSource1
        '
        Me.DishesBindingSource1.DataMember = "Dishes"
        Me.DishesBindingSource1.DataSource = Me.SufeDataSet1
        '
        'DishesTableAdapter1
        '
        Me.DishesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CanteenTableAdapter = Nothing
        Me.TableAdapterManager1.CategoryTableAdapter = Nothing
        Me.TableAdapterManager1.DishesTableAdapter = Me.DishesTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = WindowsApp7.sufeDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.OldLace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1043, 972)
        Me.DataGridView1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1055, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(639, 1110)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        '今天吃什么
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1694, 1034)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "今天吃什么"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SufeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DishesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SufeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DishesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 第一食堂ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 正餐ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 第二食堂ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 正餐ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 第三食堂ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 第四食堂ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 库迪咖啡ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 蜜雪冰城ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 饮品小食ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 正餐ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 饮品小食ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 正餐ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents 饮品小食ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SufeDataSet As sufeDataSet
    Friend WithEvents DishesBindingSource As BindingSource
    Friend WithEvents DishesTableAdapter As sufeDataSetTableAdapters.DishesTableAdapter
    Friend WithEvents TableAdapterManager As sufeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SufeDataSet1 As sufeDataSet1
    Friend WithEvents DishesBindingSource1 As BindingSource
    Friend WithEvents DishesTableAdapter1 As sufeDataSet1TableAdapters.DishesTableAdapter
    Friend WithEvents TableAdapterManager1 As sufeDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents 饮品小食品ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 第六食堂ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 正餐ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents 饮品小食ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
End Class
