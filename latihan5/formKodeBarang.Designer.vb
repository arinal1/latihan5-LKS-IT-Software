<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKodeBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.tabelDataBarang = New System.Windows.Forms.DataGridView()
        Me.KodebarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodekategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LihatBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BreadShopDataSet = New latihan5.BreadShopDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelHeaderBarang = New System.Windows.Forms.Panel()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txCariBarang = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.pemisah3 = New System.Windows.Forms.Label()
        Me.pemisah4 = New System.Windows.Forms.Label()
        Me.pemisah2 = New System.Windows.Forms.Label()
        Me.pemisah1 = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblKeteranganMenu = New System.Windows.Forms.Label()
        Me.LabelMenu = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.LihatBarangTableAdapter = New latihan5.BreadShopDataSetTableAdapters.lihatBarangTableAdapter()
        Me.PanelForm.SuspendLayout()
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BreadShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderBarang.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelForm
        '
        Me.PanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelForm.Controls.Add(Me.tabelDataBarang)
        Me.PanelForm.Controls.Add(Me.Label1)
        Me.PanelForm.Controls.Add(Me.PanelHeaderBarang)
        Me.PanelForm.Controls.Add(Me.pemisah3)
        Me.PanelForm.Controls.Add(Me.pemisah4)
        Me.PanelForm.Controls.Add(Me.pemisah2)
        Me.PanelForm.Controls.Add(Me.pemisah1)
        Me.PanelForm.Controls.Add(Me.PanelHeader)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(450, 450)
        Me.PanelForm.TabIndex = 0
        '
        'tabelDataBarang
        '
        Me.tabelDataBarang.AllowUserToAddRows = False
        Me.tabelDataBarang.AllowUserToDeleteRows = False
        Me.tabelDataBarang.AllowUserToOrderColumns = True
        Me.tabelDataBarang.AutoGenerateColumns = False
        Me.tabelDataBarang.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodebarangDataGridViewTextBoxColumn, Me.NamabarangDataGridViewTextBoxColumn, Me.NamakategoriDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn, Me.StokDataGridViewTextBoxColumn, Me.KodekategoriDataGridViewTextBoxColumn})
        Me.tabelDataBarang.DataSource = Me.LihatBarangBindingSource
        Me.tabelDataBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataBarang.Location = New System.Drawing.Point(10, 180)
        Me.tabelDataBarang.Name = "tabelDataBarang"
        Me.tabelDataBarang.ReadOnly = True
        Me.tabelDataBarang.RowHeadersVisible = False
        Me.tabelDataBarang.Size = New System.Drawing.Size(428, 258)
        Me.tabelDataBarang.TabIndex = 10
        '
        'KodebarangDataGridViewTextBoxColumn
        '
        Me.KodebarangDataGridViewTextBoxColumn.DataPropertyName = "kode_barang"
        Me.KodebarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.KodebarangDataGridViewTextBoxColumn.Name = "KodebarangDataGridViewTextBoxColumn"
        Me.KodebarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamabarangDataGridViewTextBoxColumn
        '
        Me.NamabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang"
        Me.NamabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamabarangDataGridViewTextBoxColumn.Name = "NamabarangDataGridViewTextBoxColumn"
        Me.NamabarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamakategoriDataGridViewTextBoxColumn
        '
        Me.NamakategoriDataGridViewTextBoxColumn.DataPropertyName = "nama_kategori"
        Me.NamakategoriDataGridViewTextBoxColumn.HeaderText = "Kategori"
        Me.NamakategoriDataGridViewTextBoxColumn.Name = "NamakategoriDataGridViewTextBoxColumn"
        Me.NamakategoriDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.HeaderText = "Diskon"
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        Me.DiskonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StokDataGridViewTextBoxColumn
        '
        Me.StokDataGridViewTextBoxColumn.DataPropertyName = "stok"
        Me.StokDataGridViewTextBoxColumn.HeaderText = "Stok"
        Me.StokDataGridViewTextBoxColumn.Name = "StokDataGridViewTextBoxColumn"
        Me.StokDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KodekategoriDataGridViewTextBoxColumn
        '
        Me.KodekategoriDataGridViewTextBoxColumn.DataPropertyName = "kode_kategori"
        Me.KodekategoriDataGridViewTextBoxColumn.HeaderText = "kode_kategori"
        Me.KodekategoriDataGridViewTextBoxColumn.Name = "KodekategoriDataGridViewTextBoxColumn"
        Me.KodekategoriDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodekategoriDataGridViewTextBoxColumn.Visible = False
        '
        'LihatBarangBindingSource
        '
        Me.LihatBarangBindingSource.DataMember = "lihatBarang"
        Me.LihatBarangBindingSource.DataSource = Me.BreadShopDataSet
        '
        'BreadShopDataSet
        '
        Me.BreadShopDataSet.DataSetName = "BreadShopDataSet"
        Me.BreadShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(10, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 10)
        Me.Label1.TabIndex = 9
        '
        'PanelHeaderBarang
        '
        Me.PanelHeaderBarang.Controls.Add(Me.btnPilih)
        Me.PanelHeaderBarang.Controls.Add(Me.Label41)
        Me.PanelHeaderBarang.Controls.Add(Me.txCariBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.Label43)
        Me.PanelHeaderBarang.Controls.Add(Me.Label44)
        Me.PanelHeaderBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderBarang.Location = New System.Drawing.Point(10, 110)
        Me.PanelHeaderBarang.Name = "PanelHeaderBarang"
        Me.PanelHeaderBarang.Size = New System.Drawing.Size(428, 60)
        Me.PanelHeaderBarang.TabIndex = 8
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnPilih.FlatAppearance.BorderSize = 0
        Me.btnPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPilih.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilih.ForeColor = System.Drawing.Color.White
        Me.btnPilih.Location = New System.Drawing.Point(342, 10)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(80, 40)
        Me.btnPilih.TabIndex = 1
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'Label41
        '
        Me.Label41.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label41.Location = New System.Drawing.Point(0, 60)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(428, 1)
        Me.Label41.TabIndex = 12
        '
        'txCariBarang
        '
        Me.txCariBarang.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCariBarang.Location = New System.Drawing.Point(42, 21)
        Me.txCariBarang.Name = "txCariBarang"
        Me.txCariBarang.Size = New System.Drawing.Size(193, 19)
        Me.txCariBarang.TabIndex = 0
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.White
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(9, 24)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(27, 13)
        Me.Label43.TabIndex = 10
        Me.Label43.Text = "Cari"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.White
        Me.Label44.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label44.Location = New System.Drawing.Point(0, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(428, 60)
        Me.Label44.TabIndex = 0
        '
        'pemisah3
        '
        Me.pemisah3.Dock = System.Windows.Forms.DockStyle.Left
        Me.pemisah3.Location = New System.Drawing.Point(0, 110)
        Me.pemisah3.Name = "pemisah3"
        Me.pemisah3.Size = New System.Drawing.Size(10, 328)
        Me.pemisah3.TabIndex = 7
        '
        'pemisah4
        '
        Me.pemisah4.Dock = System.Windows.Forms.DockStyle.Right
        Me.pemisah4.Location = New System.Drawing.Point(438, 110)
        Me.pemisah4.Name = "pemisah4"
        Me.pemisah4.Size = New System.Drawing.Size(10, 328)
        Me.pemisah4.TabIndex = 6
        '
        'pemisah2
        '
        Me.pemisah2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pemisah2.Location = New System.Drawing.Point(0, 438)
        Me.pemisah2.Name = "pemisah2"
        Me.pemisah2.Size = New System.Drawing.Size(448, 10)
        Me.pemisah2.TabIndex = 5
        '
        'pemisah1
        '
        Me.pemisah1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pemisah1.Location = New System.Drawing.Point(0, 100)
        Me.pemisah1.Name = "pemisah1"
        Me.pemisah1.Size = New System.Drawing.Size(448, 10)
        Me.pemisah1.TabIndex = 4
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.Panel3)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(448, 100)
        Me.PanelHeader.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblKeteranganMenu)
        Me.Panel3.Controls.Add(Me.LabelMenu)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(448, 70)
        Me.Panel3.TabIndex = 0
        '
        'lblKeteranganMenu
        '
        Me.lblKeteranganMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKeteranganMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeteranganMenu.ForeColor = System.Drawing.Color.White
        Me.lblKeteranganMenu.Location = New System.Drawing.Point(0, 40)
        Me.lblKeteranganMenu.Name = "lblKeteranganMenu"
        Me.lblKeteranganMenu.Size = New System.Drawing.Size(448, 30)
        Me.lblKeteranganMenu.TabIndex = 1
        Me.lblKeteranganMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMenu
        '
        Me.LabelMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMenu.ForeColor = System.Drawing.Color.White
        Me.LabelMenu.Location = New System.Drawing.Point(0, 0)
        Me.LabelMenu.Name = "LabelMenu"
        Me.LabelMenu.Size = New System.Drawing.Size(448, 40)
        Me.LabelMenu.TabIndex = 0
        Me.LabelMenu.Text = "Cari Kode Barang"
        Me.LabelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(448, 30)
        Me.PanelWindowBar.TabIndex = 0
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Transparent
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(418, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 5
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'LihatBarangTableAdapter
        '
        Me.LihatBarangTableAdapter.ClearBeforeFill = True
        '
        'formKodeBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 450)
        Me.Controls.Add(Me.PanelForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formKodeBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formKodeBarang"
        Me.PanelForm.ResumeLayout(False)
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BreadShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderBarang.ResumeLayout(False)
        Me.PanelHeaderBarang.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelForm As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblKeteranganMenu As Label
    Friend WithEvents LabelMenu As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents pemisah3 As Label
    Friend WithEvents pemisah4 As Label
    Friend WithEvents pemisah2 As Label
    Friend WithEvents pemisah1 As Label
    Friend WithEvents PanelHeaderBarang As Panel
    Friend WithEvents btnPilih As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents txCariBarang As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tabelDataBarang As DataGridView
    Friend WithEvents BreadShopDataSet As BreadShopDataSet
    Friend WithEvents LihatBarangBindingSource As BindingSource
    Friend WithEvents LihatBarangTableAdapter As BreadShopDataSetTableAdapters.lihatBarangTableAdapter
    Friend WithEvents KodebarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamabarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamakategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodekategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
