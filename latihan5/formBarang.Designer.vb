<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBarang
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.cbKategori = New System.Windows.Forms.ComboBox()
        Me.btnUlang = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txStok = New System.Windows.Forms.TextBox()
        Me.txDiskon = New System.Windows.Forms.TextBox()
        Me.txHarga = New System.Windows.Forms.TextBox()
        Me.txNama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txKode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.BarangTableAdapter = New latihan5.BreadShopDataSetTableAdapters.barangTableAdapter()
        Me.LihatBarangTableAdapter = New latihan5.BreadShopDataSetTableAdapters.lihatBarangTableAdapter()
        Me.BreadShopDataSet = New latihan5.BreadShopDataSet()
        Me.KategoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KategoriTableAdapter = New latihan5.BreadShopDataSetTableAdapters.kategoriTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.PanelForm.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        CType(Me.BreadShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KategoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PanelForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 450)
        Me.Panel1.TabIndex = 0
        '
        'PanelForm
        '
        Me.PanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelForm.Controls.Add(Me.cbKategori)
        Me.PanelForm.Controls.Add(Me.btnUlang)
        Me.PanelForm.Controls.Add(Me.btnSimpan)
        Me.PanelForm.Controls.Add(Me.txStok)
        Me.PanelForm.Controls.Add(Me.txDiskon)
        Me.PanelForm.Controls.Add(Me.txHarga)
        Me.PanelForm.Controls.Add(Me.txNama)
        Me.PanelForm.Controls.Add(Me.Label6)
        Me.PanelForm.Controls.Add(Me.Label5)
        Me.PanelForm.Controls.Add(Me.Label4)
        Me.PanelForm.Controls.Add(Me.Label3)
        Me.PanelForm.Controls.Add(Me.Label2)
        Me.PanelForm.Controls.Add(Me.txKode)
        Me.PanelForm.Controls.Add(Me.Label1)
        Me.PanelForm.Controls.Add(Me.pemisah3)
        Me.PanelForm.Controls.Add(Me.pemisah4)
        Me.PanelForm.Controls.Add(Me.pemisah2)
        Me.PanelForm.Controls.Add(Me.pemisah1)
        Me.PanelForm.Controls.Add(Me.PanelHeader)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(448, 448)
        Me.PanelForm.TabIndex = 1
        '
        'cbKategori
        '
        Me.cbKategori.DataSource = Me.KategoriBindingSource
        Me.cbKategori.DisplayMember = "nama_kategori"
        Me.cbKategori.FormattingEnabled = True
        Me.cbKategori.Location = New System.Drawing.Point(110, 208)
        Me.cbKategori.Name = "cbKategori"
        Me.cbKategori.Size = New System.Drawing.Size(302, 21)
        Me.cbKategori.TabIndex = 2
        Me.cbKategori.ValueMember = "kode_kategori"
        '
        'btnUlang
        '
        Me.btnUlang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUlang.FlatAppearance.BorderSize = 0
        Me.btnUlang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUlang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUlang.ForeColor = System.Drawing.Color.White
        Me.btnUlang.Location = New System.Drawing.Point(236, 387)
        Me.btnUlang.Name = "btnUlang"
        Me.btnUlang.Size = New System.Drawing.Size(80, 40)
        Me.btnUlang.TabIndex = 7
        Me.btnUlang.Text = "Ulang"
        Me.btnUlang.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(332, 387)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(80, 40)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'txStok
        '
        Me.txStok.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txStok.Location = New System.Drawing.Point(110, 325)
        Me.txStok.Name = "txStok"
        Me.txStok.Size = New System.Drawing.Size(302, 22)
        Me.txStok.TabIndex = 5
        '
        'txDiskon
        '
        Me.txDiskon.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDiskon.Location = New System.Drawing.Point(110, 286)
        Me.txDiskon.Name = "txDiskon"
        Me.txDiskon.Size = New System.Drawing.Size(302, 22)
        Me.txDiskon.TabIndex = 4
        '
        'txHarga
        '
        Me.txHarga.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txHarga.Location = New System.Drawing.Point(110, 247)
        Me.txHarga.Name = "txHarga"
        Me.txHarga.Size = New System.Drawing.Size(302, 22)
        Me.txHarga.TabIndex = 3
        '
        'txNama
        '
        Me.txNama.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNama.Location = New System.Drawing.Point(110, 169)
        Me.txNama.Name = "txNama"
        Me.txNama.Size = New System.Drawing.Size(302, 22)
        Me.txNama.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(32, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Stok"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(32, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Diskon"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Harga"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Kategori"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama Barang"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txKode
        '
        Me.txKode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txKode.Location = New System.Drawing.Point(110, 130)
        Me.txKode.Name = "txKode"
        Me.txKode.Size = New System.Drawing.Size(302, 22)
        Me.txKode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Kode Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pemisah3
        '
        Me.pemisah3.Dock = System.Windows.Forms.DockStyle.Left
        Me.pemisah3.Location = New System.Drawing.Point(0, 110)
        Me.pemisah3.Name = "pemisah3"
        Me.pemisah3.Size = New System.Drawing.Size(35, 306)
        Me.pemisah3.TabIndex = 7
        '
        'pemisah4
        '
        Me.pemisah4.Dock = System.Windows.Forms.DockStyle.Right
        Me.pemisah4.Location = New System.Drawing.Point(411, 110)
        Me.pemisah4.Name = "pemisah4"
        Me.pemisah4.Size = New System.Drawing.Size(35, 306)
        Me.pemisah4.TabIndex = 6
        '
        'pemisah2
        '
        Me.pemisah2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pemisah2.Location = New System.Drawing.Point(0, 416)
        Me.pemisah2.Name = "pemisah2"
        Me.pemisah2.Size = New System.Drawing.Size(446, 30)
        Me.pemisah2.TabIndex = 5
        '
        'pemisah1
        '
        Me.pemisah1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pemisah1.Location = New System.Drawing.Point(0, 100)
        Me.pemisah1.Name = "pemisah1"
        Me.pemisah1.Size = New System.Drawing.Size(446, 10)
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
        Me.PanelHeader.Size = New System.Drawing.Size(446, 100)
        Me.PanelHeader.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblKeteranganMenu)
        Me.Panel3.Controls.Add(Me.LabelMenu)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(446, 70)
        Me.Panel3.TabIndex = 0
        '
        'lblKeteranganMenu
        '
        Me.lblKeteranganMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKeteranganMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeteranganMenu.ForeColor = System.Drawing.Color.White
        Me.lblKeteranganMenu.Location = New System.Drawing.Point(0, 40)
        Me.lblKeteranganMenu.Name = "lblKeteranganMenu"
        Me.lblKeteranganMenu.Size = New System.Drawing.Size(446, 30)
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
        Me.LabelMenu.Size = New System.Drawing.Size(446, 40)
        Me.LabelMenu.TabIndex = 0
        Me.LabelMenu.Text = "Form Barang"
        Me.LabelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(446, 30)
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
        Me.btnKeluar.Location = New System.Drawing.Point(416, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 5
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'LihatBarangTableAdapter
        '
        Me.LihatBarangTableAdapter.ClearBeforeFill = True
        '
        'BreadShopDataSet
        '
        Me.BreadShopDataSet.DataSetName = "BreadShopDataSet"
        Me.BreadShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KategoriBindingSource
        '
        Me.KategoriBindingSource.DataMember = "kategori"
        Me.KategoriBindingSource.DataSource = Me.BreadShopDataSet
        '
        'KategoriTableAdapter
        '
        Me.KategoriTableAdapter.ClearBeforeFill = True
        '
        'formBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formBarang"
        Me.Panel1.ResumeLayout(False)
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        CType(Me.BreadShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KategoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelForm As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txKode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pemisah3 As Label
    Friend WithEvents pemisah4 As Label
    Friend WithEvents pemisah2 As Label
    Friend WithEvents pemisah1 As Label
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblKeteranganMenu As Label
    Friend WithEvents LabelMenu As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txStok As TextBox
    Friend WithEvents txDiskon As TextBox
    Friend WithEvents txHarga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUlang As Button
    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents BarangTableAdapter As BreadShopDataSetTableAdapters.barangTableAdapter
    Friend WithEvents LihatBarangTableAdapter As BreadShopDataSetTableAdapters.lihatBarangTableAdapter
    Friend WithEvents BreadShopDataSet As BreadShopDataSet
    Friend WithEvents KategoriBindingSource As BindingSource
    Friend WithEvents KategoriTableAdapter As BreadShopDataSetTableAdapters.kategoriTableAdapter
End Class
