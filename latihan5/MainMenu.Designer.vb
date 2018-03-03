<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.PanelKonten = New System.Windows.Forms.Panel()
        Me.PanelKontenKaryawan = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTampilFotoBox = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tabelDataKaryawan = New System.Windows.Forms.DataGridView()
        Me.IdkaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelkaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BreadShopDataSet = New latihan5.BreadShopDataSet()
        Me.PanelFooterKaryawan = New System.Windows.Forms.Panel()
        Me.PanelFotoBox = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PanelHeaderKaryawan = New System.Windows.Forms.Panel()
        Me.btnTambahKaryawan = New System.Windows.Forms.Button()
        Me.btnEditKaryawan = New System.Windows.Forms.Button()
        Me.btnHapusKaryawan = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txCariKaryawan = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.PanelKontenKasir = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PanelFooterKasir = New System.Windows.Forms.Panel()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.txKembalian = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txBayar = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txDiskonBelanja = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txTotal = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tabelDataKasir = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PanelHeaderKasir = New System.Windows.Forms.Panel()
        Me.txKodeBarang = New System.Windows.Forms.TextBox()
        Me.btnCariKodeBarang = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txTotalBelanja = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txStokBarang = New System.Windows.Forms.TextBox()
        Me.txHargaBarang = New System.Windows.Forms.TextBox()
        Me.txNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txDiskon = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txQty = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tglKasir = New System.Windows.Forms.DateTimePicker()
        Me.txStruk = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelKontenBarang = New System.Windows.Forms.Panel()
        Me.tabelDataBarang = New System.Windows.Forms.DataGridView()
        Me.KodebarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodekategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LihatBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label33 = New System.Windows.Forms.Label()
        Me.PanelHeaderBarang = New System.Windows.Forms.Panel()
        Me.btnTambahBarang = New System.Windows.Forms.Button()
        Me.btnEditBarang = New System.Windows.Forms.Button()
        Me.btnHapusBarang = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txCariBarang = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.PanelKontenDashboard = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.lblStokMinuman = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.lblStokRoti = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.lblPenjualan = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.lblStokBarang = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblKaryawan = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lblDataBarang = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.pemisah3 = New System.Windows.Forms.Label()
        Me.pemisah4 = New System.Windows.Forms.Label()
        Me.pemisah2 = New System.Windows.Forms.Label()
        Me.pemisah1 = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblKeteranganMenu = New System.Windows.Forms.Label()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.PanelSideBar = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnKaryawan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBarang = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnKasir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelCornerHeader = New System.Windows.Forms.Panel()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HeaderpenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Header_penjualanTableAdapter = New latihan5.BreadShopDataSetTableAdapters.header_penjualanTableAdapter()
        Me.PenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanTableAdapter = New latihan5.BreadShopDataSetTableAdapters.penjualanTableAdapter()
        Me.LihatBarangTableAdapter = New latihan5.BreadShopDataSetTableAdapters.lihatBarangTableAdapter()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New latihan5.BreadShopDataSetTableAdapters.barangTableAdapter()
        Me.KaryawanTableAdapter = New latihan5.BreadShopDataSetTableAdapters.karyawanTableAdapter()
        Me.fotoBox = New System.Windows.Forms.PictureBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelForm.SuspendLayout()
        Me.PanelKonten.SuspendLayout()
        Me.PanelKontenKaryawan.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.tabelDataKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BreadShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFooterKaryawan.SuspendLayout()
        Me.PanelFotoBox.SuspendLayout()
        Me.PanelHeaderKaryawan.SuspendLayout()
        Me.PanelKontenKasir.SuspendLayout()
        Me.PanelFooterKasir.SuspendLayout()
        CType(Me.tabelDataKasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderKasir.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelKontenBarang.SuspendLayout()
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderBarang.SuspendLayout()
        Me.PanelKontenDashboard.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.PanelSideBar.SuspendLayout()
        Me.PanelCornerHeader.SuspendLayout()
        CType(Me.HeaderpenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fotoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelForm
        '
        Me.PanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelForm.Controls.Add(Me.PanelKonten)
        Me.PanelForm.Controls.Add(Me.PanelHeader)
        Me.PanelForm.Controls.Add(Me.PanelSideBar)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(872, 670)
        Me.PanelForm.TabIndex = 0
        '
        'PanelKonten
        '
        Me.PanelKonten.Controls.Add(Me.PanelKontenKaryawan)
        Me.PanelKonten.Controls.Add(Me.PanelKontenKasir)
        Me.PanelKonten.Controls.Add(Me.PanelKontenBarang)
        Me.PanelKonten.Controls.Add(Me.PanelKontenDashboard)
        Me.PanelKonten.Controls.Add(Me.pemisah3)
        Me.PanelKonten.Controls.Add(Me.pemisah4)
        Me.PanelKonten.Controls.Add(Me.pemisah2)
        Me.PanelKonten.Controls.Add(Me.pemisah1)
        Me.PanelKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKonten.Location = New System.Drawing.Point(200, 100)
        Me.PanelKonten.Name = "PanelKonten"
        Me.PanelKonten.Size = New System.Drawing.Size(670, 568)
        Me.PanelKonten.TabIndex = 0
        '
        'PanelKontenKaryawan
        '
        Me.PanelKontenKaryawan.Controls.Add(Me.Panel2)
        Me.PanelKontenKaryawan.Controls.Add(Me.tabelDataKaryawan)
        Me.PanelKontenKaryawan.Controls.Add(Me.PanelFooterKaryawan)
        Me.PanelKontenKaryawan.Controls.Add(Me.Label22)
        Me.PanelKontenKaryawan.Controls.Add(Me.PanelHeaderKaryawan)
        Me.PanelKontenKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenKaryawan.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenKaryawan.Name = "PanelKontenKaryawan"
        Me.PanelKontenKaryawan.Size = New System.Drawing.Size(650, 548)
        Me.PanelKontenKaryawan.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnTampilFotoBox)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 328)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(650, 20)
        Me.Panel2.TabIndex = 24
        '
        'btnTampilFotoBox
        '
        Me.btnTampilFotoBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnTampilFotoBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTampilFotoBox.FlatAppearance.BorderSize = 0
        Me.btnTampilFotoBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilFotoBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTampilFotoBox.ForeColor = System.Drawing.Color.White
        Me.btnTampilFotoBox.Location = New System.Drawing.Point(300, 0)
        Me.btnTampilFotoBox.Name = "btnTampilFotoBox"
        Me.btnTampilFotoBox.Size = New System.Drawing.Size(25, 20)
        Me.btnTampilFotoBox.TabIndex = 27
        Me.btnTampilFotoBox.Text = "^"
        Me.btnTampilFotoBox.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.Label38)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(325, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(325, 20)
        Me.Panel6.TabIndex = 26
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label37)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 10)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(325, 10)
        Me.Panel7.TabIndex = 25
        '
        'Label37
        '
        Me.Label37.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label37.Location = New System.Drawing.Point(0, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(325, 10)
        Me.Label37.TabIndex = 8
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.White
        Me.Label38.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label38.Location = New System.Drawing.Point(0, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(325, 10)
        Me.Label38.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label35)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 20)
        Me.Panel4.TabIndex = 25
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label36)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(300, 10)
        Me.Panel5.TabIndex = 25
        '
        'Label36
        '
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label36.Location = New System.Drawing.Point(0, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(325, 10)
        Me.Label36.TabIndex = 8
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label35.Location = New System.Drawing.Point(0, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(300, 10)
        Me.Label35.TabIndex = 8
        '
        'tabelDataKaryawan
        '
        Me.tabelDataKaryawan.AllowUserToAddRows = False
        Me.tabelDataKaryawan.AllowUserToDeleteRows = False
        Me.tabelDataKaryawan.AllowUserToOrderColumns = True
        Me.tabelDataKaryawan.AutoGenerateColumns = False
        Me.tabelDataKaryawan.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataKaryawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdkaryawanDataGridViewTextBoxColumn, Me.NamakaryawanDataGridViewTextBoxColumn, Me.LevelkaryawanDataGridViewTextBoxColumn, Me.FotoDataGridViewImageColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.tabelDataKaryawan.DataSource = Me.KaryawanBindingSource
        Me.tabelDataKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataKaryawan.Location = New System.Drawing.Point(0, 70)
        Me.tabelDataKaryawan.Name = "tabelDataKaryawan"
        Me.tabelDataKaryawan.ReadOnly = True
        Me.tabelDataKaryawan.RowHeadersVisible = False
        Me.tabelDataKaryawan.Size = New System.Drawing.Size(650, 278)
        Me.tabelDataKaryawan.TabIndex = 8
        '
        'IdkaryawanDataGridViewTextBoxColumn
        '
        Me.IdkaryawanDataGridViewTextBoxColumn.DataPropertyName = "id_karyawan"
        Me.IdkaryawanDataGridViewTextBoxColumn.HeaderText = "ID Karyawan"
        Me.IdkaryawanDataGridViewTextBoxColumn.Name = "IdkaryawanDataGridViewTextBoxColumn"
        Me.IdkaryawanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamakaryawanDataGridViewTextBoxColumn
        '
        Me.NamakaryawanDataGridViewTextBoxColumn.DataPropertyName = "nama_karyawan"
        Me.NamakaryawanDataGridViewTextBoxColumn.HeaderText = "Nama Karyawan"
        Me.NamakaryawanDataGridViewTextBoxColumn.Name = "NamakaryawanDataGridViewTextBoxColumn"
        Me.NamakaryawanDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamakaryawanDataGridViewTextBoxColumn.Width = 120
        '
        'LevelkaryawanDataGridViewTextBoxColumn
        '
        Me.LevelkaryawanDataGridViewTextBoxColumn.DataPropertyName = "level_karyawan"
        Me.LevelkaryawanDataGridViewTextBoxColumn.HeaderText = "Level"
        Me.LevelkaryawanDataGridViewTextBoxColumn.Name = "LevelkaryawanDataGridViewTextBoxColumn"
        Me.LevelkaryawanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FotoDataGridViewImageColumn
        '
        Me.FotoDataGridViewImageColumn.DataPropertyName = "foto"
        Me.FotoDataGridViewImageColumn.HeaderText = "foto"
        Me.FotoDataGridViewImageColumn.Name = "FotoDataGridViewImageColumn"
        Me.FotoDataGridViewImageColumn.ReadOnly = True
        Me.FotoDataGridViewImageColumn.Visible = False
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Visible = False
        '
        'KaryawanBindingSource
        '
        Me.KaryawanBindingSource.DataMember = "karyawan"
        Me.KaryawanBindingSource.DataSource = Me.BreadShopDataSet
        '
        'BreadShopDataSet
        '
        Me.BreadShopDataSet.DataSetName = "BreadShopDataSet"
        Me.BreadShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelFooterKaryawan
        '
        Me.PanelFooterKaryawan.Controls.Add(Me.PanelFotoBox)
        Me.PanelFooterKaryawan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooterKaryawan.Location = New System.Drawing.Point(0, 348)
        Me.PanelFooterKaryawan.Name = "PanelFooterKaryawan"
        Me.PanelFooterKaryawan.Size = New System.Drawing.Size(650, 200)
        Me.PanelFooterKaryawan.TabIndex = 9
        Me.PanelFooterKaryawan.Visible = False
        '
        'PanelFotoBox
        '
        Me.PanelFotoBox.Controls.Add(Me.fotoBox)
        Me.PanelFotoBox.Controls.Add(Me.Label34)
        Me.PanelFotoBox.Controls.Add(Me.Label32)
        Me.PanelFotoBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFotoBox.Location = New System.Drawing.Point(0, 0)
        Me.PanelFotoBox.Name = "PanelFotoBox"
        Me.PanelFotoBox.Size = New System.Drawing.Size(650, 179)
        Me.PanelFotoBox.TabIndex = 25
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label34.Location = New System.Drawing.Point(0, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(150, 179)
        Me.Label34.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label32.Location = New System.Drawing.Point(500, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(150, 179)
        Me.Label32.TabIndex = 23
        '
        'Label22
        '
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label22.Location = New System.Drawing.Point(0, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(650, 10)
        Me.Label22.TabIndex = 7
        '
        'PanelHeaderKaryawan
        '
        Me.PanelHeaderKaryawan.Controls.Add(Me.btnTambahKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.btnEditKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.btnHapusKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.Label23)
        Me.PanelHeaderKaryawan.Controls.Add(Me.txCariKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.Label27)
        Me.PanelHeaderKaryawan.Controls.Add(Me.Label28)
        Me.PanelHeaderKaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderKaryawan.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderKaryawan.Name = "PanelHeaderKaryawan"
        Me.PanelHeaderKaryawan.Size = New System.Drawing.Size(650, 60)
        Me.PanelHeaderKaryawan.TabIndex = 6
        '
        'btnTambahKaryawan
        '
        Me.btnTambahKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnTambahKaryawan.FlatAppearance.BorderSize = 0
        Me.btnTambahKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahKaryawan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnTambahKaryawan.Location = New System.Drawing.Point(390, 9)
        Me.btnTambahKaryawan.Name = "btnTambahKaryawan"
        Me.btnTambahKaryawan.Size = New System.Drawing.Size(80, 40)
        Me.btnTambahKaryawan.TabIndex = 20
        Me.btnTambahKaryawan.Text = "Tambah"
        Me.btnTambahKaryawan.UseVisualStyleBackColor = False
        '
        'btnEditKaryawan
        '
        Me.btnEditKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnEditKaryawan.FlatAppearance.BorderSize = 0
        Me.btnEditKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditKaryawan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnEditKaryawan.Location = New System.Drawing.Point(476, 9)
        Me.btnEditKaryawan.Name = "btnEditKaryawan"
        Me.btnEditKaryawan.Size = New System.Drawing.Size(80, 40)
        Me.btnEditKaryawan.TabIndex = 20
        Me.btnEditKaryawan.Text = "Edit"
        Me.btnEditKaryawan.UseVisualStyleBackColor = False
        '
        'btnHapusKaryawan
        '
        Me.btnHapusKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnHapusKaryawan.FlatAppearance.BorderSize = 0
        Me.btnHapusKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusKaryawan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnHapusKaryawan.Location = New System.Drawing.Point(562, 9)
        Me.btnHapusKaryawan.Name = "btnHapusKaryawan"
        Me.btnHapusKaryawan.Size = New System.Drawing.Size(80, 40)
        Me.btnHapusKaryawan.TabIndex = 20
        Me.btnHapusKaryawan.Text = "Hapus"
        Me.btnHapusKaryawan.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label23.Location = New System.Drawing.Point(0, 60)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(650, 1)
        Me.Label23.TabIndex = 12
        '
        'txCariKaryawan
        '
        Me.txCariKaryawan.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCariKaryawan.Location = New System.Drawing.Point(42, 21)
        Me.txCariKaryawan.Name = "txCariKaryawan"
        Me.txCariKaryawan.Size = New System.Drawing.Size(233, 19)
        Me.txCariKaryawan.TabIndex = 9
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(9, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(27, 13)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "Cari"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label28.Location = New System.Drawing.Point(0, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(650, 60)
        Me.Label28.TabIndex = 0
        '
        'PanelKontenKasir
        '
        Me.PanelKontenKasir.Controls.Add(Me.Label21)
        Me.PanelKontenKasir.Controls.Add(Me.PanelFooterKasir)
        Me.PanelKontenKasir.Controls.Add(Me.tabelDataKasir)
        Me.PanelKontenKasir.Controls.Add(Me.Label20)
        Me.PanelKontenKasir.Controls.Add(Me.PanelHeaderKasir)
        Me.PanelKontenKasir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenKasir.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenKasir.Name = "PanelKontenKasir"
        Me.PanelKontenKasir.Size = New System.Drawing.Size(650, 548)
        Me.PanelKontenKasir.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label21.Location = New System.Drawing.Point(0, 468)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(650, 10)
        Me.Label21.TabIndex = 10
        '
        'PanelFooterKasir
        '
        Me.PanelFooterKasir.Controls.Add(Me.btnBayar)
        Me.PanelFooterKasir.Controls.Add(Me.txKembalian)
        Me.PanelFooterKasir.Controls.Add(Me.Label24)
        Me.PanelFooterKasir.Controls.Add(Me.txBayar)
        Me.PanelFooterKasir.Controls.Add(Me.Label25)
        Me.PanelFooterKasir.Controls.Add(Me.txDiskonBelanja)
        Me.PanelFooterKasir.Controls.Add(Me.Label26)
        Me.PanelFooterKasir.Controls.Add(Me.txTotal)
        Me.PanelFooterKasir.Controls.Add(Me.Label30)
        Me.PanelFooterKasir.Controls.Add(Me.Label31)
        Me.PanelFooterKasir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooterKasir.Location = New System.Drawing.Point(0, 478)
        Me.PanelFooterKasir.Name = "PanelFooterKasir"
        Me.PanelFooterKasir.Size = New System.Drawing.Size(650, 70)
        Me.PanelFooterKasir.TabIndex = 9
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnBayar.FlatAppearance.BorderSize = 0
        Me.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBayar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.Color.White
        Me.btnBayar.Location = New System.Drawing.Point(546, 8)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(99, 54)
        Me.btnBayar.TabIndex = 20
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'txKembalian
        '
        Me.txKembalian.Enabled = False
        Me.txKembalian.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txKembalian.Location = New System.Drawing.Point(335, 43)
        Me.txKembalian.Name = "txKembalian"
        Me.txKembalian.Size = New System.Drawing.Size(200, 19)
        Me.txKembalian.TabIndex = 12
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(274, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 13)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Kembalian"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txBayar
        '
        Me.txBayar.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBayar.Location = New System.Drawing.Point(335, 8)
        Me.txBayar.Name = "txBayar"
        Me.txBayar.Size = New System.Drawing.Size(200, 19)
        Me.txBayar.TabIndex = 13
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(274, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(46, 13)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Dibayar"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txDiskonBelanja
        '
        Me.txDiskonBelanja.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDiskonBelanja.Location = New System.Drawing.Point(48, 43)
        Me.txDiskonBelanja.Name = "txDiskonBelanja"
        Me.txDiskonBelanja.Size = New System.Drawing.Size(200, 19)
        Me.txDiskonBelanja.TabIndex = 14
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(6, 49)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 13)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Diskon"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txTotal
        '
        Me.txTotal.Enabled = False
        Me.txTotal.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTotal.Location = New System.Drawing.Point(48, 10)
        Me.txTotal.Name = "txTotal"
        Me.txTotal.Size = New System.Drawing.Size(200, 19)
        Me.txTotal.TabIndex = 15
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(9, 10)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(31, 13)
        Me.Label30.TabIndex = 19
        Me.Label30.Text = "Total"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label31.Location = New System.Drawing.Point(0, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(650, 70)
        Me.Label31.TabIndex = 0
        '
        'tabelDataKasir
        '
        Me.tabelDataKasir.AllowUserToAddRows = False
        Me.tabelDataKasir.AllowUserToDeleteRows = False
        Me.tabelDataKasir.AllowUserToOrderColumns = True
        Me.tabelDataKasir.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataKasir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataKasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataKasir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.kode_barang, Me.nama_barang, Me.harga, Me.qty, Me.diskon, Me.sub_total, Me.stok})
        Me.tabelDataKasir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataKasir.Location = New System.Drawing.Point(0, 181)
        Me.tabelDataKasir.Name = "tabelDataKasir"
        Me.tabelDataKasir.ReadOnly = True
        Me.tabelDataKasir.RowHeadersVisible = False
        Me.tabelDataKasir.Size = New System.Drawing.Size(650, 367)
        Me.tabelDataKasir.TabIndex = 8
        '
        'no
        '
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 40
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "Kode Barang"
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.ReadOnly = True
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.ReadOnly = True
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "QTY"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'diskon
        '
        Me.diskon.HeaderText = "Diskon (%)"
        Me.diskon.Name = "diskon"
        Me.diskon.ReadOnly = True
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        '
        'stok
        '
        Me.stok.HeaderText = "Stok"
        Me.stok.Name = "stok"
        Me.stok.ReadOnly = True
        Me.stok.Visible = False
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label20.Location = New System.Drawing.Point(0, 171)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(650, 10)
        Me.Label20.TabIndex = 7
        '
        'PanelHeaderKasir
        '
        Me.PanelHeaderKasir.Controls.Add(Me.txKodeBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.btnCariKodeBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.Panel1)
        Me.PanelHeaderKasir.Controls.Add(Me.Label18)
        Me.PanelHeaderKasir.Controls.Add(Me.txStokBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.txHargaBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.txNamaBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.Label17)
        Me.PanelHeaderKasir.Controls.Add(Me.txDiskon)
        Me.PanelHeaderKasir.Controls.Add(Me.Label16)
        Me.PanelHeaderKasir.Controls.Add(Me.txQty)
        Me.PanelHeaderKasir.Controls.Add(Me.Label15)
        Me.PanelHeaderKasir.Controls.Add(Me.Label14)
        Me.PanelHeaderKasir.Controls.Add(Me.Label13)
        Me.PanelHeaderKasir.Controls.Add(Me.Label12)
        Me.PanelHeaderKasir.Controls.Add(Me.tglKasir)
        Me.PanelHeaderKasir.Controls.Add(Me.txStruk)
        Me.PanelHeaderKasir.Controls.Add(Me.Label11)
        Me.PanelHeaderKasir.Controls.Add(Me.Label10)
        Me.PanelHeaderKasir.Controls.Add(Me.Label8)
        Me.PanelHeaderKasir.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderKasir.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderKasir.Name = "PanelHeaderKasir"
        Me.PanelHeaderKasir.Size = New System.Drawing.Size(650, 171)
        Me.PanelHeaderKasir.TabIndex = 6
        '
        'txKodeBarang
        '
        Me.txKodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txKodeBarang.Location = New System.Drawing.Point(84, 51)
        Me.txKodeBarang.Name = "txKodeBarang"
        Me.txKodeBarang.Size = New System.Drawing.Size(200, 20)
        Me.txKodeBarang.TabIndex = 9
        '
        'btnCariKodeBarang
        '
        Me.btnCariKodeBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnCariKodeBarang.FlatAppearance.BorderSize = 0
        Me.btnCariKodeBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariKodeBarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariKodeBarang.ForeColor = System.Drawing.Color.White
        Me.btnCariKodeBarang.Location = New System.Drawing.Point(290, 51)
        Me.btnCariKodeBarang.Name = "btnCariKodeBarang"
        Me.btnCariKodeBarang.Size = New System.Drawing.Size(27, 20)
        Me.btnCariKodeBarang.TabIndex = 21
        Me.btnCariKodeBarang.Text = "..."
        Me.btnCariKodeBarang.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txTotalBelanja)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Location = New System.Drawing.Point(340, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 130)
        Me.Panel1.TabIndex = 15
        '
        'txTotalBelanja
        '
        Me.txTotalBelanja.Dock = System.Windows.Forms.DockStyle.Top
        Me.txTotalBelanja.Enabled = False
        Me.txTotalBelanja.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTotalBelanja.Location = New System.Drawing.Point(0, 53)
        Me.txTotalBelanja.Name = "txTotalBelanja"
        Me.txTotalBelanja.Size = New System.Drawing.Size(309, 71)
        Me.txTotalBelanja.TabIndex = 9
        Me.txTotalBelanja.Text = "50000"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(309, 53)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Total Belanja"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(337, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(1, 131)
        Me.Label18.TabIndex = 14
        '
        'txStokBarang
        '
        Me.txStokBarang.Enabled = False
        Me.txStokBarang.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txStokBarang.Location = New System.Drawing.Point(266, 81)
        Me.txStokBarang.Name = "txStokBarang"
        Me.txStokBarang.Size = New System.Drawing.Size(51, 19)
        Me.txStokBarang.TabIndex = 9
        Me.txStokBarang.Visible = False
        '
        'txHargaBarang
        '
        Me.txHargaBarang.Enabled = False
        Me.txHargaBarang.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txHargaBarang.Location = New System.Drawing.Point(266, 111)
        Me.txHargaBarang.Name = "txHargaBarang"
        Me.txHargaBarang.Size = New System.Drawing.Size(51, 19)
        Me.txHargaBarang.TabIndex = 9
        Me.txHargaBarang.Visible = False
        '
        'txNamaBarang
        '
        Me.txNamaBarang.Enabled = False
        Me.txNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNamaBarang.Location = New System.Drawing.Point(84, 81)
        Me.txNamaBarang.Name = "txNamaBarang"
        Me.txNamaBarang.Size = New System.Drawing.Size(233, 20)
        Me.txNamaBarang.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(6, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Diskon (%)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txDiskon
        '
        Me.txDiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDiskon.Location = New System.Drawing.Point(84, 141)
        Me.txDiskon.Name = "txDiskon"
        Me.txDiskon.Size = New System.Drawing.Size(233, 20)
        Me.txDiskon.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 111)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "QTY"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txQty
        '
        Me.txQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txQty.Location = New System.Drawing.Point(84, 111)
        Me.txQty.Name = "txQty"
        Me.txQty.Size = New System.Drawing.Size(233, 20)
        Me.txQty.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(6, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Nama Barang"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(6, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Kode Barang"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Location = New System.Drawing.Point(0, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(650, 131)
        Me.Label13.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Location = New System.Drawing.Point(0, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(650, 1)
        Me.Label12.TabIndex = 12
        '
        'tglKasir
        '
        Me.tglKasir.Location = New System.Drawing.Point(409, 10)
        Me.tglKasir.Name = "tglKasir"
        Me.tglKasir.Size = New System.Drawing.Size(233, 20)
        Me.tglKasir.TabIndex = 11
        '
        'txStruk
        '
        Me.txStruk.Enabled = False
        Me.txStruk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txStruk.Location = New System.Drawing.Point(84, 11)
        Me.txStruk.Name = "txStruk"
        Me.txStruk.Size = New System.Drawing.Size(233, 20)
        Me.txStruk.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(356, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Tanggal"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "No Struk"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(650, 40)
        Me.Label8.TabIndex = 0
        '
        'PanelKontenBarang
        '
        Me.PanelKontenBarang.Controls.Add(Me.tabelDataBarang)
        Me.PanelKontenBarang.Controls.Add(Me.Label33)
        Me.PanelKontenBarang.Controls.Add(Me.PanelHeaderBarang)
        Me.PanelKontenBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenBarang.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenBarang.Name = "PanelKontenBarang"
        Me.PanelKontenBarang.Size = New System.Drawing.Size(650, 548)
        Me.PanelKontenBarang.TabIndex = 6
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
        Me.tabelDataBarang.Location = New System.Drawing.Point(0, 70)
        Me.tabelDataBarang.Name = "tabelDataBarang"
        Me.tabelDataBarang.ReadOnly = True
        Me.tabelDataBarang.RowHeadersVisible = False
        Me.tabelDataBarang.Size = New System.Drawing.Size(650, 478)
        Me.tabelDataBarang.TabIndex = 8
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
        'Label33
        '
        Me.Label33.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label33.Location = New System.Drawing.Point(0, 60)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(650, 10)
        Me.Label33.TabIndex = 7
        '
        'PanelHeaderBarang
        '
        Me.PanelHeaderBarang.Controls.Add(Me.btnTambahBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.btnEditBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.btnHapusBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.Label41)
        Me.PanelHeaderBarang.Controls.Add(Me.txCariBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.Label43)
        Me.PanelHeaderBarang.Controls.Add(Me.Label44)
        Me.PanelHeaderBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderBarang.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderBarang.Name = "PanelHeaderBarang"
        Me.PanelHeaderBarang.Size = New System.Drawing.Size(650, 60)
        Me.PanelHeaderBarang.TabIndex = 6
        '
        'btnTambahBarang
        '
        Me.btnTambahBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnTambahBarang.FlatAppearance.BorderSize = 0
        Me.btnTambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahBarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahBarang.ForeColor = System.Drawing.Color.White
        Me.btnTambahBarang.Location = New System.Drawing.Point(390, 9)
        Me.btnTambahBarang.Name = "btnTambahBarang"
        Me.btnTambahBarang.Size = New System.Drawing.Size(80, 40)
        Me.btnTambahBarang.TabIndex = 20
        Me.btnTambahBarang.Text = "Tambah"
        Me.btnTambahBarang.UseVisualStyleBackColor = False
        '
        'btnEditBarang
        '
        Me.btnEditBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnEditBarang.FlatAppearance.BorderSize = 0
        Me.btnEditBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBarang.ForeColor = System.Drawing.Color.White
        Me.btnEditBarang.Location = New System.Drawing.Point(476, 9)
        Me.btnEditBarang.Name = "btnEditBarang"
        Me.btnEditBarang.Size = New System.Drawing.Size(80, 40)
        Me.btnEditBarang.TabIndex = 20
        Me.btnEditBarang.Text = "Edit"
        Me.btnEditBarang.UseVisualStyleBackColor = False
        '
        'btnHapusBarang
        '
        Me.btnHapusBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnHapusBarang.FlatAppearance.BorderSize = 0
        Me.btnHapusBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusBarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusBarang.ForeColor = System.Drawing.Color.White
        Me.btnHapusBarang.Location = New System.Drawing.Point(562, 9)
        Me.btnHapusBarang.Name = "btnHapusBarang"
        Me.btnHapusBarang.Size = New System.Drawing.Size(80, 40)
        Me.btnHapusBarang.TabIndex = 20
        Me.btnHapusBarang.Text = "Hapus"
        Me.btnHapusBarang.UseVisualStyleBackColor = False
        '
        'Label41
        '
        Me.Label41.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label41.Location = New System.Drawing.Point(0, 60)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(650, 1)
        Me.Label41.TabIndex = 12
        '
        'txCariBarang
        '
        Me.txCariBarang.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCariBarang.Location = New System.Drawing.Point(42, 21)
        Me.txCariBarang.Name = "txCariBarang"
        Me.txCariBarang.Size = New System.Drawing.Size(233, 19)
        Me.txCariBarang.TabIndex = 9
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
        Me.Label44.Size = New System.Drawing.Size(650, 60)
        Me.Label44.TabIndex = 0
        '
        'PanelKontenDashboard
        '
        Me.PanelKontenDashboard.Controls.Add(Me.Panel14)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel13)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel12)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel11)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel10)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel9)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel8)
        Me.PanelKontenDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenDashboard.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenDashboard.Name = "PanelKontenDashboard"
        Me.PanelKontenDashboard.Size = New System.Drawing.Size(650, 548)
        Me.PanelKontenDashboard.TabIndex = 4
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Label58)
        Me.Panel14.Controls.Add(Me.Label59)
        Me.Panel14.Location = New System.Drawing.Point(14, 438)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(324, 63)
        Me.Panel14.TabIndex = 1
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.SystemColors.Control
        Me.Label58.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label58.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(0, 30)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(324, 33)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "√Lezat  √Sehat  √Terjangkau"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.SystemColors.Control
        Me.Label59.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label59.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(0, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(324, 30)
        Me.Label59.TabIndex = 1
        Me.Label59.Text = "Toko Roti Terbaik Di Indonesia"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Label55)
        Me.Panel13.Controls.Add(Me.lblStokMinuman)
        Me.Panel13.Controls.Add(Me.Label57)
        Me.Panel13.Location = New System.Drawing.Point(442, 116)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(200, 100)
        Me.Panel13.TabIndex = 0
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.White
        Me.Label55.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label55.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(30, 64)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(170, 36)
        Me.Label55.TabIndex = 2
        Me.Label55.Text = "Stok Minuman"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStokMinuman
        '
        Me.lblStokMinuman.BackColor = System.Drawing.Color.White
        Me.lblStokMinuman.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStokMinuman.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokMinuman.ForeColor = System.Drawing.Color.Black
        Me.lblStokMinuman.Location = New System.Drawing.Point(30, 0)
        Me.lblStokMinuman.Name = "lblStokMinuman"
        Me.lblStokMinuman.Size = New System.Drawing.Size(170, 64)
        Me.lblStokMinuman.TabIndex = 1
        Me.lblStokMinuman.Text = "100"
        Me.lblStokMinuman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.White
        Me.Label57.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label57.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(0, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(30, 100)
        Me.Label57.TabIndex = 3
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Label52)
        Me.Panel12.Controls.Add(Me.lblStokRoti)
        Me.Panel12.Controls.Add(Me.Label54)
        Me.Panel12.Location = New System.Drawing.Point(281, 116)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(155, 100)
        Me.Panel12.TabIndex = 0
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.White
        Me.Label52.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label52.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(30, 64)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(125, 36)
        Me.Label52.TabIndex = 2
        Me.Label52.Text = "Stok Roti"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStokRoti
        '
        Me.lblStokRoti.BackColor = System.Drawing.Color.White
        Me.lblStokRoti.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStokRoti.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokRoti.ForeColor = System.Drawing.Color.Black
        Me.lblStokRoti.Location = New System.Drawing.Point(30, 0)
        Me.lblStokRoti.Name = "lblStokRoti"
        Me.lblStokRoti.Size = New System.Drawing.Size(125, 64)
        Me.lblStokRoti.TabIndex = 1
        Me.lblStokRoti.Text = "100"
        Me.lblStokRoti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.White
        Me.Label54.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label54.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(0, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(30, 100)
        Me.Label54.TabIndex = 3
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label49)
        Me.Panel11.Controls.Add(Me.lblPenjualan)
        Me.Panel11.Controls.Add(Me.Label51)
        Me.Panel11.Location = New System.Drawing.Point(10, 116)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(265, 100)
        Me.Panel11.TabIndex = 0
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.White
        Me.Label49.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label49.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(30, 64)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(235, 36)
        Me.Label49.TabIndex = 2
        Me.Label49.Text = "Penjualan Hari Ini"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPenjualan
        '
        Me.lblPenjualan.BackColor = System.Drawing.Color.White
        Me.lblPenjualan.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPenjualan.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenjualan.ForeColor = System.Drawing.Color.Black
        Me.lblPenjualan.Location = New System.Drawing.Point(30, 0)
        Me.lblPenjualan.Name = "lblPenjualan"
        Me.lblPenjualan.Size = New System.Drawing.Size(235, 64)
        Me.lblPenjualan.TabIndex = 1
        Me.lblPenjualan.Text = "100"
        Me.lblPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.White
        Me.Label51.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label51.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(0, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(30, 100)
        Me.Label51.TabIndex = 3
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label46)
        Me.Panel10.Controls.Add(Me.lblStokBarang)
        Me.Panel10.Controls.Add(Me.Label48)
        Me.Panel10.Location = New System.Drawing.Point(479, 10)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(163, 100)
        Me.Panel10.TabIndex = 0
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.White
        Me.Label46.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label46.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(30, 64)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(133, 36)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "Stok Barang"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStokBarang
        '
        Me.lblStokBarang.BackColor = System.Drawing.Color.White
        Me.lblStokBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStokBarang.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokBarang.ForeColor = System.Drawing.Color.Black
        Me.lblStokBarang.Location = New System.Drawing.Point(30, 0)
        Me.lblStokBarang.Name = "lblStokBarang"
        Me.lblStokBarang.Size = New System.Drawing.Size(133, 64)
        Me.lblStokBarang.TabIndex = 1
        Me.lblStokBarang.Text = "100"
        Me.lblStokBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.White
        Me.Label48.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label48.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(0, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(30, 100)
        Me.Label48.TabIndex = 3
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label29)
        Me.Panel9.Controls.Add(Me.lblKaryawan)
        Me.Panel9.Controls.Add(Me.Label45)
        Me.Panel9.Location = New System.Drawing.Point(216, 9)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(257, 100)
        Me.Panel9.TabIndex = 0
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(30, 64)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(227, 36)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Karyawan"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKaryawan
        '
        Me.lblKaryawan.BackColor = System.Drawing.Color.White
        Me.lblKaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblKaryawan.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaryawan.ForeColor = System.Drawing.Color.Black
        Me.lblKaryawan.Location = New System.Drawing.Point(30, 0)
        Me.lblKaryawan.Name = "lblKaryawan"
        Me.lblKaryawan.Size = New System.Drawing.Size(227, 64)
        Me.lblKaryawan.TabIndex = 1
        Me.lblKaryawan.Text = "100"
        Me.lblKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.White
        Me.Label45.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(0, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(30, 100)
        Me.Label45.TabIndex = 3
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label39)
        Me.Panel8.Controls.Add(Me.lblDataBarang)
        Me.Panel8.Controls.Add(Me.Label40)
        Me.Panel8.Location = New System.Drawing.Point(10, 10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 100)
        Me.Panel8.TabIndex = 0
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.White
        Me.Label39.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(30, 64)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(170, 36)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "Data Barang"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDataBarang
        '
        Me.lblDataBarang.BackColor = System.Drawing.Color.White
        Me.lblDataBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDataBarang.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataBarang.ForeColor = System.Drawing.Color.Black
        Me.lblDataBarang.Location = New System.Drawing.Point(30, 0)
        Me.lblDataBarang.Name = "lblDataBarang"
        Me.lblDataBarang.Size = New System.Drawing.Size(170, 64)
        Me.lblDataBarang.TabIndex = 1
        Me.lblDataBarang.Text = "100"
        Me.lblDataBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.White
        Me.Label40.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(0, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(30, 100)
        Me.Label40.TabIndex = 3
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pemisah3
        '
        Me.pemisah3.Dock = System.Windows.Forms.DockStyle.Left
        Me.pemisah3.Location = New System.Drawing.Point(0, 10)
        Me.pemisah3.Name = "pemisah3"
        Me.pemisah3.Size = New System.Drawing.Size(10, 548)
        Me.pemisah3.TabIndex = 3
        '
        'pemisah4
        '
        Me.pemisah4.Dock = System.Windows.Forms.DockStyle.Right
        Me.pemisah4.Location = New System.Drawing.Point(660, 10)
        Me.pemisah4.Name = "pemisah4"
        Me.pemisah4.Size = New System.Drawing.Size(10, 548)
        Me.pemisah4.TabIndex = 2
        '
        'pemisah2
        '
        Me.pemisah2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pemisah2.Location = New System.Drawing.Point(0, 558)
        Me.pemisah2.Name = "pemisah2"
        Me.pemisah2.Size = New System.Drawing.Size(670, 10)
        Me.pemisah2.TabIndex = 1
        '
        'pemisah1
        '
        Me.pemisah1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pemisah1.Location = New System.Drawing.Point(0, 0)
        Me.pemisah1.Name = "pemisah1"
        Me.pemisah1.Size = New System.Drawing.Size(670, 10)
        Me.pemisah1.TabIndex = 0
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.Panel3)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(200, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(670, 100)
        Me.PanelHeader.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblKeteranganMenu)
        Me.Panel3.Controls.Add(Me.lblMenu)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(670, 70)
        Me.Panel3.TabIndex = 0
        '
        'lblKeteranganMenu
        '
        Me.lblKeteranganMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKeteranganMenu.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeteranganMenu.ForeColor = System.Drawing.Color.White
        Me.lblKeteranganMenu.Location = New System.Drawing.Point(0, 40)
        Me.lblKeteranganMenu.Name = "lblKeteranganMenu"
        Me.lblKeteranganMenu.Size = New System.Drawing.Size(670, 30)
        Me.lblKeteranganMenu.TabIndex = 1
        Me.lblKeteranganMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMenu
        '
        Me.lblMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(0, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(670, 40)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Halaman Awal"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnMinimize)
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(670, 30)
        Me.PanelWindowBar.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(610, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 6
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Transparent
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(640, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 5
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'PanelSideBar
        '
        Me.PanelSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelSideBar.Controls.Add(Me.btnLogOut)
        Me.PanelSideBar.Controls.Add(Me.Label5)
        Me.PanelSideBar.Controls.Add(Me.btnKaryawan)
        Me.PanelSideBar.Controls.Add(Me.Label4)
        Me.PanelSideBar.Controls.Add(Me.btnBarang)
        Me.PanelSideBar.Controls.Add(Me.Label3)
        Me.PanelSideBar.Controls.Add(Me.btnKasir)
        Me.PanelSideBar.Controls.Add(Me.Label2)
        Me.PanelSideBar.Controls.Add(Me.btnDashboard)
        Me.PanelSideBar.Controls.Add(Me.Label6)
        Me.PanelSideBar.Controls.Add(Me.PanelCornerHeader)
        Me.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideBar.Name = "PanelSideBar"
        Me.PanelSideBar.Size = New System.Drawing.Size(200, 668)
        Me.PanelSideBar.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 1)
        Me.Label5.TabIndex = 7
        '
        'btnKaryawan
        '
        Me.btnKaryawan.BackColor = System.Drawing.Color.Transparent
        Me.btnKaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKaryawan.FlatAppearance.BorderSize = 0
        Me.btnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaryawan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnKaryawan.Location = New System.Drawing.Point(0, 283)
        Me.btnKaryawan.Name = "btnKaryawan"
        Me.btnKaryawan.Size = New System.Drawing.Size(200, 60)
        Me.btnKaryawan.TabIndex = 6
        Me.btnKaryawan.Text = "       Data Karyawan"
        Me.btnKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaryawan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 1)
        Me.Label4.TabIndex = 5
        '
        'btnBarang
        '
        Me.btnBarang.BackColor = System.Drawing.Color.Transparent
        Me.btnBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBarang.FlatAppearance.BorderSize = 0
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.ForeColor = System.Drawing.Color.White
        Me.btnBarang.Location = New System.Drawing.Point(0, 222)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Size = New System.Drawing.Size(200, 60)
        Me.btnBarang.TabIndex = 4
        Me.btnBarang.Text = "       Data Barang"
        Me.btnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarang.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 1)
        Me.Label3.TabIndex = 3
        '
        'btnKasir
        '
        Me.btnKasir.BackColor = System.Drawing.Color.Transparent
        Me.btnKasir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKasir.FlatAppearance.BorderSize = 0
        Me.btnKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKasir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKasir.ForeColor = System.Drawing.Color.White
        Me.btnKasir.Location = New System.Drawing.Point(0, 161)
        Me.btnKasir.Name = "btnKasir"
        Me.btnKasir.Size = New System.Drawing.Size(200, 60)
        Me.btnKasir.TabIndex = 2
        Me.btnKasir.Text = "       Kasir"
        Me.btnKasir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKasir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 1)
        Me.Label2.TabIndex = 1
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 100)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 60)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "       Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 1)
        Me.Label6.TabIndex = 9
        '
        'PanelCornerHeader
        '
        Me.PanelCornerHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanelCornerHeader.Controls.Add(Me.lblAdmin)
        Me.PanelCornerHeader.Controls.Add(Me.Label9)
        Me.PanelCornerHeader.Controls.Add(Me.Label1)
        Me.PanelCornerHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCornerHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelCornerHeader.Name = "PanelCornerHeader"
        Me.PanelCornerHeader.Size = New System.Drawing.Size(200, 99)
        Me.PanelCornerHeader.TabIndex = 0
        '
        'lblAdmin
        '
        Me.lblAdmin.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAdmin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblAdmin.Location = New System.Drawing.Point(82, 63)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(54, 36)
        Me.lblAdmin.TabIndex = 2
        Me.lblAdmin.Text = "Admin"
        Me.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bread" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shop"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HeaderpenjualanBindingSource
        '
        Me.HeaderpenjualanBindingSource.DataMember = "header_penjualan"
        Me.HeaderpenjualanBindingSource.DataSource = Me.BreadShopDataSet
        '
        'Header_penjualanTableAdapter
        '
        Me.Header_penjualanTableAdapter.ClearBeforeFill = True
        '
        'PenjualanBindingSource
        '
        Me.PenjualanBindingSource.DataMember = "penjualan"
        Me.PenjualanBindingSource.DataSource = Me.BreadShopDataSet
        '
        'PenjualanTableAdapter
        '
        Me.PenjualanTableAdapter.ClearBeforeFill = True
        '
        'LihatBarangTableAdapter
        '
        Me.LihatBarangTableAdapter.ClearBeforeFill = True
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "barang"
        Me.BarangBindingSource.DataSource = Me.BreadShopDataSet
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'fotoBox
        '
        Me.fotoBox.BackColor = System.Drawing.Color.White
        Me.fotoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fotoBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fotoBox.Location = New System.Drawing.Point(150, 0)
        Me.fotoBox.Name = "fotoBox"
        Me.fotoBox.Size = New System.Drawing.Size(350, 179)
        Me.fotoBox.TabIndex = 22
        Me.fotoBox.TabStop = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLogOut.Location = New System.Drawing.Point(0, 608)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(200, 60)
        Me.btnLogOut.TabIndex = 8
        Me.btnLogOut.Text = "Keluar Sesi"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(0, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 36)
        Me.Label9.TabIndex = 4
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 670)
        Me.Controls.Add(Me.PanelForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelForm.ResumeLayout(False)
        Me.PanelKonten.ResumeLayout(False)
        Me.PanelKontenKaryawan.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.tabelDataKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BreadShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFooterKaryawan.ResumeLayout(False)
        Me.PanelFotoBox.ResumeLayout(False)
        Me.PanelHeaderKaryawan.ResumeLayout(False)
        Me.PanelHeaderKaryawan.PerformLayout()
        Me.PanelKontenKasir.ResumeLayout(False)
        Me.PanelFooterKasir.ResumeLayout(False)
        Me.PanelFooterKasir.PerformLayout()
        CType(Me.tabelDataKasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderKasir.ResumeLayout(False)
        Me.PanelHeaderKasir.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelKontenBarang.ResumeLayout(False)
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderBarang.ResumeLayout(False)
        Me.PanelHeaderBarang.PerformLayout()
        Me.PanelKontenDashboard.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.PanelSideBar.ResumeLayout(False)
        Me.PanelCornerHeader.ResumeLayout(False)
        CType(Me.HeaderpenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fotoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelForm As Panel
    Friend WithEvents PanelKonten As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelSideBar As Panel
    Friend WithEvents PanelCornerHeader As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblKeteranganMenu As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKaryawan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBarang As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnKasir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pemisah3 As Label
    Friend WithEvents pemisah4 As Label
    Friend WithEvents pemisah2 As Label
    Friend WithEvents pemisah1 As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelKontenKasir As Panel
    Friend WithEvents PanelHeaderKasir As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelKontenDashboard As Panel
    Friend WithEvents tglKasir As DateTimePicker
    Friend WithEvents txStruk As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txNamaBarang As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txDiskon As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txQty As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txKodeBarang As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents txTotalBelanja As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tabelDataKasir As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents BreadShopDataSet As BreadShopDataSet
    Friend WithEvents HeaderpenjualanBindingSource As BindingSource
    Friend WithEvents Header_penjualanTableAdapter As BreadShopDataSetTableAdapters.header_penjualanTableAdapter
    Friend WithEvents PenjualanBindingSource As BindingSource
    Friend WithEvents PenjualanTableAdapter As BreadShopDataSetTableAdapters.penjualanTableAdapter
    Friend WithEvents LihatBarangBindingSource As BindingSource
    Friend WithEvents LihatBarangTableAdapter As BreadShopDataSetTableAdapters.lihatBarangTableAdapter
    Friend WithEvents BarangBindingSource As BindingSource
    Friend WithEvents BarangTableAdapter As BreadShopDataSetTableAdapters.barangTableAdapter
    Friend WithEvents Label21 As Label
    Friend WithEvents PanelFooterKasir As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents btnBayar As Button
    Friend WithEvents txKembalian As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txBayar As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txDiskonBelanja As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txTotal As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents diskon As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
    Friend WithEvents stok As DataGridViewTextBoxColumn
    Friend WithEvents PanelKontenBarang As Panel
    Friend WithEvents tabelDataBarang As DataGridView
    Friend WithEvents KodebarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamabarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamakategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodekategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PanelHeaderBarang As Panel
    Friend WithEvents btnTambahBarang As Button
    Friend WithEvents btnEditBarang As Button
    Friend WithEvents btnHapusBarang As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents txCariBarang As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txStokBarang As TextBox
    Friend WithEvents txHargaBarang As TextBox
    Friend WithEvents PanelKontenKaryawan As Panel
    Friend WithEvents tabelDataKaryawan As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents PanelHeaderKaryawan As Panel
    Friend WithEvents btnTambahKaryawan As Button
    Friend WithEvents btnEditKaryawan As Button
    Friend WithEvents btnHapusKaryawan As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents txCariKaryawan As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents KaryawanBindingSource As BindingSource
    Friend WithEvents KaryawanTableAdapter As BreadShopDataSetTableAdapters.karyawanTableAdapter
    Friend WithEvents IdkaryawanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamakaryawanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LevelkaryawanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PanelFooterKaryawan As Panel
    Friend WithEvents fotoBox As PictureBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTampilFotoBox As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents btnCariKodeBarang As Button
    Friend WithEvents PanelFotoBox As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents lblDataBarang As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label55 As Label
    Friend WithEvents lblStokMinuman As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label52 As Label
    Friend WithEvents lblStokRoti As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label49 As Label
    Friend WithEvents lblPenjualan As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label46 As Label
    Friend WithEvents lblStokBarang As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents lblKaryawan As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
End Class
