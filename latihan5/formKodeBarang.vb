Public Class formKodeBarang
    Dim kodeBarang As String
    Dim namaBarang As String
    Dim kodeKategori As String
    Dim hargabarang As Decimal
    Dim diskonBarang As Integer
    Dim stokBarang As Integer
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
    Private Sub formKodeBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BreadShopDataSet.lihatBarang' table. You can move, or remove it, as needed.
        Me.LihatBarangTableAdapter.Fill(Me.BreadShopDataSet.lihatBarang)
        txCariBarang.Focus()
        txCariBarang.Select()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
    Private Sub tabelDataBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataBarang.CellClick
        Dim i As Integer = e.RowIndex
        If i >= 0 Then
            kodeBarang = tabelDataBarang.Rows(i).Cells(0).Value
            namaBarang = tabelDataBarang.Rows(i).Cells(1).Value
            hargabarang = tabelDataBarang.Rows(i).Cells(3).Value
            diskonBarang = tabelDataBarang.Rows(i).Cells(4).Value
            stokBarang = tabelDataBarang.Rows(i).Cells(5).Value
        Else
            kodeBarang = ""
        End If
    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        If kodeBarang = "" Then
            MsgBox("Mohon Pilih Data!")
            txCariBarang.Focus()
            txCariBarang.Select()
        Else
            Me.Close()
            MainMenu.txKodeBarang.Text = kodeBarang
            MainMenu.txNamaBarang.Text = namaBarang
            MainMenu.txHargaBarang.Text = hargabarang
            MainMenu.txDiskon.Text = diskonBarang
            MainMenu.txStokBarang.Text = stokBarang
            MainMenu.txQty.Select()
            MainMenu.txQty.Focus()
        End If
    End Sub
End Class