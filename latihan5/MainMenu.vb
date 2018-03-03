Imports System.ComponentModel

Public Class MainMenu
    'drag
    Dim drag As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    'login
    Public logOff As Boolean
    Public admin As String
    Public idAdmin As String
    Public levelAdmin As Integer
    'kasir
    Dim indexTabel As Integer = -1
    'barang
    Public editBarang As Boolean
    Public kodeBarang As String
    Public namaBarang As String
    Public kodeKategori As String
    Public hargabarang As Decimal
    Public diskonBarang As Integer
    Public stokBarang As Integer
    'karyawan
    Public editKaryawan As Boolean
    Public idKaryawan As String
    Public namaKaryawan As String
    Public levelKaryawan As String
    Public fotoKaryawan As Byte()
    Public password As String
    Dim lihatFoto As Boolean

    'panelWindow
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        logOff = False
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'dragWindow
    Private Sub PanelWindowBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PanelWindowBar_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub PanelWindowBar_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseUp
        drag = False
    End Sub

    'menu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblAdmin.Text = admin
        refreshData()
        ulangForm()
        btnDashboard_Click(sender, e)
        Me.KeyPreview = True
    End Sub

    Sub refreshData()
        'TODO: This line of code loads data into the 'BreadShopDataSet.karyawan' table. You can move, or remove it, as needed.
        Me.KaryawanTableAdapter.Fill(Me.BreadShopDataSet.karyawan)
        'TODO: This line of code loads data into the 'BreadShopDataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.BreadShopDataSet.barang)
        'TODO: This line of code loads data into the 'BreadShopDataSet.lihatBarang' table. You can move, or remove it, as needed.
        Me.LihatBarangTableAdapter.Fill(Me.BreadShopDataSet.lihatBarang)
        'TODO: This line of code loads data into the 'BreadShopDataSet.penjualan' table. You can move, or remove it, as needed.
        Me.PenjualanTableAdapter.Fill(Me.BreadShopDataSet.penjualan)
        'TODO: This line of code loads data into the 'BreadShopDataSet.header_penjualan' table. You can move, or remove it, as needed.
        Me.Header_penjualanTableAdapter.Fill(Me.BreadShopDataSet.header_penjualan)
        lblDataBarang.Text = Me.BreadShopDataSet.barang.Count
        lblKaryawan.Text = Me.BreadShopDataSet.karyawan.Count
        lblStokBarang.Text = BarangTableAdapter.sumStok()
        lblPenjualan.Text = Header_penjualanTableAdapter.dashboard(Now()).Count
        lblStokRoti.Text = BarangTableAdapter.dashboard("R")
        lblStokMinuman.Text = BarangTableAdapter.dashboard("M")
    End Sub

    Sub ulangForm()
        PanelKontenDashboard.Visible = False
        PanelKontenBarang.Visible = False
        PanelKontenKasir.Visible = False
        PanelKontenKaryawan.Visible = False
        btnDashboard.BackColor = Color.FromArgb(52, 73, 94)
        btnKasir.BackColor = Color.FromArgb(52, 73, 94)
        btnBarang.BackColor = Color.FromArgb(52, 73, 94)
        btnKaryawan.BackColor = Color.FromArgb(52, 73, 94)
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ulangForm()
        PanelKontenDashboard.Visible = True
        btnDashboard.BackColor = Color.FromArgb(46, 136, 197)
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        lblMenu.Text = "Halaman Awal"
        lblKeteranganMenu.Text = ""
    End Sub

    Private Sub btnKasir_Click(sender As Object, e As EventArgs) Handles btnKasir.Click
        ulangForm()
        PanelKontenKasir.Visible = True
        txKodeBarang.Focus()
        btnKasir.BackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        lblMenu.Text = "Menu Penjualan"
        lblKeteranganMenu.Text = "Tekan Enter Untuk Melanjutkan | Tekan F1 Untuk Mencari Kode Barang | Tekan F2 Untuk Membatalkan Pembelian Barang | Tekan F3 Untuk Mengulang Belanja | Tekan F4 Untuk Membayar"
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        ulangForm()
        PanelKontenBarang.Visible = True
        txCariBarang.Focus()
        btnBarang.BackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        lblMenu.Text = "Menu Data Barang"
        lblKeteranganMenu.Text = "Tekan F1 Untuk Mencari | Tekan F2 Untuk Menambah Data | Tekan F3 Untuk Mengedit Data | Tekan F4 Untuk Menghapus Data"
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        ulangForm()
        PanelKontenKaryawan.Visible = True
        txCariKaryawan.Focus()
        btnKaryawan.BackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        lblMenu.Text = "Menu Data Karyawan"
        lblKeteranganMenu.Text = "Tekan F1 Untuk Mencari | Tekan F2 Untuk Menambah Data | Tekan F3 Untuk Mengedit Data | Tekan F4 Untuk Menghapus Data | Tekan F5 Untuk Buka/Tutup Foto"
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        logOff = True
        Me.Close()
        formLogin.Show()
    End Sub

    'barang
    Private Sub btnTambahBarang_Click(sender As Object, e As EventArgs) Handles btnTambahBarang.Click
        editBarang = False
        formBarang.ShowDialog()
        refreshData()
    End Sub

    Private Sub tabelDataBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataBarang.CellClick
        Dim i As Integer = e.RowIndex
        If i >= 0 Then
            kodeBarang = tabelDataBarang.Rows(i).Cells(0).Value
            namaBarang = tabelDataBarang.Rows(i).Cells(1).Value
            hargabarang = tabelDataBarang.Rows(i).Cells(3).Value
            diskonBarang = tabelDataBarang.Rows(i).Cells(4).Value
            stokBarang = tabelDataBarang.Rows(i).Cells(5).Value
            kodeKategori = tabelDataBarang.Rows(i).Cells(6).Value
        Else
            kodeBarang = ""
        End If
    End Sub

    Private Sub btnEditBarang_Click(sender As Object, e As EventArgs) Handles btnEditBarang.Click
        If kodeBarang = "" Then
            MsgBox("Mohon Pilih Data!")
        Else
            editBarang = True
            formBarang.ShowDialog()
            refreshData()
        End If
    End Sub

    Private Sub btnHapusBarang_Click(sender As Object, e As EventArgs) Handles btnHapusBarang.Click
        If kodeBarang = "" Then
            MsgBox("Mohon Pilih Data!")
        Else
            If MsgBox("Apakah anda yakin menghapus barang " & kodeBarang & "?", vbYesNo, "Konfirmasi") = vbYes Then
                BarangTableAdapter.hapus(kodeBarang)
                refreshData()
                kodeBarang = ""
            End If
        End If
    End Sub

    Private Sub txCariBarang_TextChanged(sender As Object, e As EventArgs) Handles txCariBarang.TextChanged
        If txCariBarang.Text = "" Then
            refreshData()
        Else
            Dim kataKunci As String = "%" & txCariBarang.Text & "%"
            LihatBarangTableAdapter.FillByCari(Me.BreadShopDataSet.lihatBarang, kataKunci, kataKunci)
        End If
    End Sub

    'kasir
    Sub ulangKasir()
        refreshData()
        CariStruk()
        tglKasir.Value = Now()
        txKodeBarang.Clear()
        txNamaBarang.Clear()
        txQty.Clear()
        txDiskon.Clear()
        txHargaBarang.Clear()
        txStokBarang.Clear()
        txTotal.Text = 0
        txDiskonBelanja.Text = 0
        txBayar.Text = 0
        txKembalian.Text = 0
        txTotalBelanja.Text = 0
        tabelDataKasir.Rows.Clear()
        txKodeBarang.Select()
    End Sub

    Sub CariStruk()
        Dim dt As BreadShopDataSet.header_penjualanDataTable
        dt = Header_penjualanTableAdapter.GetData()
        If dt.Count = 0 Then
            txStruk.Text = "Struk" & 1
        Else
            txStruk.Text = "Struk" & dt.Count + 1
        End If
    End Sub

    Private Sub PanelKontenKasir_VisibleChanged(sender As Object, e As EventArgs) Handles PanelKontenKasir.VisibleChanged
        If PanelHeaderKasir.Visible Then
            ulangKasir()
        End If
    End Sub

    Private Sub txKodeBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles txKodeBarang.KeyDown
        If txKodeBarang.Text IsNot "" Then
            If e.KeyCode = Keys.Enter Then
                Dim dt As New BreadShopDataSet.lihatBarangDataTable
                dt = LihatBarangTableAdapter.GetDataByCari(txKodeBarang.Text, "")
                If dt.Count = 0 Then
                    MsgBox("Barang Tidak Ada!")
                    txNamaBarang.Clear()
                    txQty.Clear()
                    txHargaBarang.Clear()
                    txDiskon.Clear()
                    txStokBarang.Clear()
                Else
                    txNamaBarang.Text =  dt.Rows(0).Item(1)
                    txHargaBarang.Text = Decimal.ToInt64(dt.Rows(0).Item(3))
                    txDiskon.Text = dt.Rows(0).Item(4)
                    txStokBarang.Text = dt.Rows(0).Item(5)
                    txQty.Select()
                End If
            End If
        End If
    End Sub

    Private Sub txQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txQty.KeyDown
        If txQty.Text IsNot "" Then
            If e.KeyCode = Keys.Enter Then
                txDiskon.Select()
            End If
        End If
    End Sub

    Function tambahQty()
        Dim ada As Boolean
        Dim index As Integer = -1
        For i = 0 To tabelDataKasir.RowCount - 1
            If ada = False Then
                If txKodeBarang.Text = tabelDataKasir.Rows(i).Cells(1).Value Then
                    ada = True
                    index = i
                Else
                    ada = False
                End If
            End If
        Next
        Return index
    End Function

    Private Sub txDiskon_KeyDown(sender As Object, e As KeyEventArgs) Handles txDiskon.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txDiskon.Text IsNot "" And txKodeBarang.Text IsNot "" And txQty.Text IsNot "" And txNamaBarang.Text IsNot "" Then
                Dim qty As Integer
                Dim subtotal As Integer
                Dim stok As Integer
                Dim cekAda As Integer
                Dim jml As Integer
                jml = Integer.Parse(txQty.Text) * Decimal.ToInt64(txHargaBarang.Text)
                subtotal = jml - (jml * Integer.Parse(txDiskon.Text) / 100)
                stok = Integer.Parse(txStokBarang.Text) - Integer.Parse(txQty.Text)

                cekAda = tambahQty()
                If cekAda = -1 Then
                    tabelDataKasir.Rows.Add(tabelDataKasir.RowCount + 1, txKodeBarang.Text, txNamaBarang.Text, txHargaBarang.Text, txQty.Text, txDiskon.Text, subtotal, stok)
                Else
                    qty = tabelDataKasir.Rows(cekAda).Cells(4).Value + Integer.Parse(txQty.Text)
                    stok = tabelDataKasir.Rows(cekAda).Cells(7).Value - Integer.Parse(txQty.Text)
                    jml = qty * Integer.Parse(txHargaBarang.Text)
                    subtotal = jml - (jml * Integer.Parse(txDiskon.Text) / 100)
                    tabelDataKasir.Rows.RemoveAt(cekAda)
                    tabelDataKasir.Rows.Add(tabelDataKasir.RowCount + 1, txKodeBarang.Text, txNamaBarang.Text, txHargaBarang.Text, qty, txDiskon.Text, subtotal, stok)
                    For i = 0 To tabelDataKasir.RowCount - 1
                        tabelDataKasir.Rows(i).Cells(0).Value = i + 1
                    Next
                End If

                totalan(0)

                txKodeBarang.Clear()
                txNamaBarang.Clear()
                txQty.Clear()
                txHargaBarang.Clear()
                txDiskon.Clear()
                txStokBarang.Clear()
                txKodeBarang.Focus()
            Else
                MsgBox("Mohon Data Dilengkapi!")
            End If
        End If
    End Sub

    Sub totalan(dikurang As Integer)
        Dim total As Integer
        Dim diskon As Integer
        Dim totalBelanja As Integer

        If dikurang = 0 Then
            total = 0
            For i = 0 To tabelDataKasir.RowCount - 1
                total = total + tabelDataKasir.Rows(i).Cells(6).Value
            Next
        Else
            total = Integer.Parse(txTotal.Text) - dikurang
        End If
        If txDiskonBelanja.Text = "" Or txDiskonBelanja.Text = "0" Then
            diskon = 0
            totalBelanja = total
        Else
            diskon = Integer.Parse(txDiskonBelanja.Text)
            totalBelanja = total - (total * diskon / 100)
        End If
        txTotal.Text = total
        txTotalBelanja.Text = totalBelanja
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If tabelDataKasir.RowCount = 0 Then
            MsgBox("Mohon pilih barang untuk dibeli!")
        Else
            If Integer.Parse(txBayar.Text) < Integer.Parse(txTotal.Text) Then
                MsgBox("Uang pembeli kurang")
            Else
                Header_penjualanTableAdapter.Insert(txStruk.Text, idAdmin, tglKasir.Value, txDiskonBelanja.Text, txTotalBelanja.Text)
                For i = 0 To tabelDataKasir.RowCount - 1
                    PenjualanTableAdapter.Insert(tabelDataKasir.Rows(i).Cells(1).Value, Integer.Parse(tabelDataKasir.Rows(i).Cells(4).Value), Integer.Parse(tabelDataKasir.Rows(i).Cells(5).Value), txStruk.Text)
                    BarangTableAdapter.terjual(tabelDataKasir.Rows(i).Cells(7).Value, tabelDataKasir.Rows(i).Cells(1).Value)
                Next
                ulangKasir()
            End If
        End If
    End Sub

    Private Sub txDiskonBelanja_TextChanged(sender As Object, e As EventArgs) Handles txDiskonBelanja.TextChanged
        Dim total As Integer
        Dim bayar As Integer
        Dim kembalian As Integer
        If txDiskonBelanja.Text = "" Or txDiskonBelanja.Text = "0" Then
            total = txTotal.Text
        ElseIf txDiskonBelanja.Text > "100" Then
            total = 0
        Else
            total = txTotal.Text
            total = total - (total * txDiskonBelanja.Text / 100)
        End If
        If txBayar.Text = "" Or txBayar.Text = "0" Then
            bayar = 0
            kembalian = 0
        Else
            bayar = Integer.Parse(txBayar.Text)
            If bayar < total Then
                kembalian = 0
            Else
                kembalian = bayar - total
            End If
        End If
        txTotalBelanja.Text = total
        txKembalian.Text = kembalian
    End Sub

    Private Sub txBayar_TextChanged(sender As Object, e As EventArgs) Handles txBayar.TextChanged
        Dim bayar As Integer
        If txBayar.Text = "" Or txBayar.Text = "0" Then
            bayar = 0
            txKembalian.Text = 0
        Else
            bayar = Integer.Parse(txBayar.Text)
            If bayar < Integer.Parse(txTotalBelanja.Text) Then
                txKembalian.Text = 0
            Else
                txKembalian.Text = bayar - Integer.Parse(txTotalBelanja.Text)
            End If
        End If
    End Sub

    Private Sub btnCariKodeBarang_Click(sender As Object, e As EventArgs) Handles btnCariKodeBarang.Click
        formKodeBarang.ShowDialog()
        If txKodeBarang.Text = "" Or txNamaBarang.Text = "" Then
            txKodeBarang.Focus()
        Else
            txQty.Focus()
        End If
    End Sub

    Private Sub tabelDataKasir_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataKasir.CellClick
        If e.RowIndex >= 0 Then
            indexTabel = e.RowIndex
        Else
            indexTabel = -1
        End If
    End Sub

    'karyawan
    Private Sub btnTambahKaryawan_Click(sender As Object, e As EventArgs) Handles btnTambahKaryawan.Click
        editKaryawan = False
        formKaryawan.ShowDialog()
        refreshData()
    End Sub

    Private Sub btnEditKaryawan_Click(sender As Object, e As EventArgs) Handles btnEditKaryawan.Click
        If idKaryawan = "" Then
            MsgBox("Mohon Pilih Data!")
        Else
            editKaryawan = True
            formKaryawan.ShowDialog()
            refreshData()
        End If
    End Sub

    Private Sub btnHapusKaryawan_Click(sender As Object, e As EventArgs) Handles btnHapusKaryawan.Click
        If idKaryawan = "" Then
            MsgBox("Mohon Pilih Data!")
        Else
            If MsgBox("Apakah anda yakin menghapus data " & idKaryawan & "?", vbYesNo, "Konfirmasi") = vbYes Then
                KaryawanTableAdapter.hapus(idKaryawan)
                refreshData()
                idKaryawan = ""
            End If
        End If
    End Sub

    Private Sub tabelDataKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataKaryawan.CellClick
        Dim i As Integer = e.RowIndex
        If i >= 0 Then
            idKaryawan = tabelDataKaryawan.Rows(i).Cells(0).Value
            namaKaryawan = tabelDataKaryawan.Rows(i).Cells(1).Value
            levelAdmin = tabelDataKaryawan.Rows(i).Cells(2).Value
            If IsDBNull(tabelDataKaryawan.Rows(i).Cells(3).Value) = False Then
                fotoKaryawan = tabelDataKaryawan.Rows(i).Cells(3).Value
                Dim ms As New IO.MemoryStream(fotoKaryawan)
                fotoBox.BackgroundImage = Image.FromStream(ms)
            Else
                fotoKaryawan = Nothing
                fotoBox.BackgroundImage = Nothing
            End If
            password = tabelDataKaryawan.Rows(i).Cells(4).Value
        End If
    End Sub

    Private Sub txCariKaryawan_TextChanged(sender As Object, e As EventArgs) Handles txCariKaryawan.TextChanged
        If txCariKaryawan.Text = "" Then
            refreshData()
        Else
            Dim kataKunci As String = "%" & txCariKaryawan.Text & "%"
            KaryawanTableAdapter.FillByCari(Me.BreadShopDataSet.karyawan, kataKunci, kataKunci)
        End If
    End Sub

    Private Sub btnTampilFotoBox_Click(sender As Object, e As EventArgs) Handles btnTampilFotoBox.Click
        lihatFoto = Not lihatFoto
        If lihatFoto Then
            PanelFooterKaryawan.Visible = True
            btnTampilFotoBox.Text = "v"
        Else
            PanelFooterKaryawan.Visible = False
            btnTampilFotoBox.Text = "^"
        End If
    End Sub

    'banInt
    Sub banInt(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txBayar.KeyPress
        banInt(e)
    End Sub

    Private Sub txDiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskon.KeyPress
        banInt(e)
    End Sub

    Private Sub txDiskonBelanja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskonBelanja.KeyPress
        banInt(e)
    End Sub

    Private Sub txQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txQty.KeyPress
        banInt(e)
    End Sub

    'hotKey
    Private Sub MainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim hk As Keys = e.KeyCode
        If PanelKontenKasir.Visible Then
            If hk = Keys.F1 Then
                btnCariKodeBarang_Click(sender, e)
            ElseIf hk = Keys.F2 Then
                If indexTabel = -1 Then
                    MsgBox("Mohon Pilih Data!")
                Else
                    If MsgBox("Apakah Anda Yakin Membatalkan Pembelian " & tabelDataKasir.Rows(indexTabel).Cells(1).Value & "?", vbYesNo, "Konfirmasi") = vbYes Then
                        totalan(tabelDataKasir.Rows(indexTabel).Cells(6).Value)
                        tabelDataKasir.Rows.RemoveAt(indexTabel)
                        indexTabel = -1
                    End If
                End If
            ElseIf hk = Keys.F3 Then
                If MsgBox("Apakah Anda Yakin Untuk Mengulang?", vbYesNo, "Konfirmasi") = vbYes Then
                    ulangKasir()
                End If
            ElseIf hk = Keys.F4 Then
                If txBayar.Text = "" Or txBayar.Text = "0" Then
                    txBayar.Focus()
                Else
                    btnBayar_Click(sender, e)
                End If
            End If

        ElseIf PanelKontenBarang.Visible Then
            If hk = Keys.F1 Then
                txCariBarang.Focus()
            ElseIf hk = Keys.F2 Then
                btnTambahBarang_Click(sender, e)
            ElseIf hk = Keys.F3 Then
                btnEditBarang_Click(sender, e)
            ElseIf hk = Keys.F4 Then
                btnHapusBarang_Click(sender, e)
            End If
        ElseIf PanelKontenKaryawan.Visible Then
            If hk = Keys.F1 Then
                txCariKaryawan.Focus()
            ElseIf hk = Keys.F2 Then
                btnTambahKaryawan_Click(sender, e)
            ElseIf hk = Keys.F3 Then
                btnEditKaryawan_Click(sender, e)
            ElseIf hk = Keys.F4 Then
                btnHapusKaryawan_Click(sender, e)
            ElseIf hk = Keys.F5 Then
                btnTampilFotoBox_Click(sender, e)
            End If
        End If
    End Sub

End Class