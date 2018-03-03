Public Class formBarang
    'drag
    Dim drag As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
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

    Private Sub formBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'BreadShopDataSet.kategori' table. You can move, or remove it, as needed.
        Me.KategoriTableAdapter.Fill(Me.BreadShopDataSet.kategori)
        'TODO: This line of code loads data into the 'BreadShopDataSet.kategori' table. You can move, or remove it, as needed.
        Me.KategoriTableAdapter.Fill(Me.BreadShopDataSet.kategori)
        ulangForm()
        If MainMenu.editBarang Then
            txKode.Text = MainMenu.kodeBarang
            txNama.Text = MainMenu.namaBarang
            cbKategori.SelectedValue = MainMenu.kodeKategori
            txHarga.Text = MainMenu.hargabarang
            txDiskon.Text = MainMenu.diskonBarang
            txStok.Text = MainMenu.stokBarang
            txNama.Select()
        End If
    End Sub

    Sub ulangForm()
        txNama.Clear()
        cbKategori.SelectedIndex = 0
        txHarga.Clear()
        txDiskon.Clear()
        txStok.Clear()
        If MainMenu.editBarang = False Then
            txKode.Clear()
            txKode.Enabled = True
            txKode.Select()
        Else
            txKode.Enabled = False
            txNama.Select()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnUlang_Click(sender As Object, e As EventArgs) Handles btnUlang.Click
        ulangForm()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txKode.Text = "" Or txNama.Text = "" Or cbKategori.Text = "" Or txHarga.Text = "" Or txDiskon.Text = "" Or txStok.Text = "" Then
            MsgBox("Mohon Data Dilengkapi!")
        Else
            If MainMenu.editBarang Then
                BarangTableAdapter.edit(txNama.Text, cbKategori.SelectedValue, Decimal.Parse(txHarga.Text), Integer.Parse(txDiskon.Text), Integer.Parse(txStok.Text), txKode.Text)
            Else
                BarangTableAdapter.Insert(txKode.Text, txNama.Text, cbKategori.SelectedValue, Decimal.Parse(txHarga.Text), Integer.Parse(txDiskon.Text), Integer.Parse(txStok.Text))
            End If
            Me.Close()
        End If
    End Sub
    Sub banInt(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txDiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskon.KeyPress
        banInt(e)
    End Sub

    Private Sub txHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txHarga.KeyPress
        banInt(e)
    End Sub

    Private Sub txStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txStok.KeyPress
        banInt(e)
    End Sub
End Class