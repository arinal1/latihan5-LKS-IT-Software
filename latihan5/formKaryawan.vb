Public Class formKaryawan
    'drag
    Dim drag As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    'foto
    Dim foto As Byte()
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
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub formBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        ulangForm()
        If MainMenu.editKaryawan Then
            txID.Text = MainMenu.idKaryawan
            txNama.Text = MainMenu.namaKaryawan
            cbLevel.SelectedIndex = MainMenu.levelKaryawan + 1
            txPassword.Text = MainMenu.password
            foto = MainMenu.fotoKaryawan
            If foto IsNot Nothing Then
                Dim ms As New IO.MemoryStream(foto)
                fotoBox.BackgroundImage = Image.FromStream(ms)
            End If
            txNama.Select()
        End If
    End Sub

    Sub ulangForm()
        txNama.Clear()
        cbLevel.SelectedIndex = 0
        txPassword.Clear()
        fotoBox.BackgroundImage = Nothing
        foto = Nothing
        If MainMenu.editKaryawan = False Then
            txID.Clear()
            txID.Enabled = True
            txID.Select()
        Else
            txID.Enabled = False
            txNama.Select()
        End If
    End Sub

    Private Sub btnUlang_Click(sender As Object, e As EventArgs) Handles btnUlang.Click
        ulangForm()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txID.Text = "" Or txNama.Text = "" Or cbLevel.Text = "" Or txPassword.Text = "" Then
            MsgBox("Mohon Data Dilengkapi!")
        Else
            If MainMenu.editKaryawan Then
                KaryawanTableAdapter.edit(txNama.Text, cbLevel.SelectedIndex + 1, foto, txPassword.Text, txID.Text)
            Else
                KaryawanTableAdapter.Insert(txID.Text, txNama.Text, cbLevel.SelectedIndex - 1, foto, txPassword.Text)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        OpenFileDialog1.Filter = "Image Files (*.jpg , *.png) | *.jpg; *.png"
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            Dim ms As New IO.MemoryStream()
            fotoBox.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            fotoBox.BackgroundImage.Save(ms, fotoBox.BackgroundImage.RawFormat)
            foto = ms.GetBuffer
        End If
    End Sub
End Class