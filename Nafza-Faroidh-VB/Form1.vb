Public Class Form1
    Dim PilihanSaiki As UserControl


    Sub TambahKeDaftar(nama As String, tipe As TipeAnggota)
        If (Not Helper.VerifikasiAnggota(tipe)) Then Return
        If (String.IsNullOrWhiteSpace(nama)) Then nama = Helper.PickAnyNama()
        Dim u = Helper.TambahAnggota(nama, tipe)
        Dim l = _Tabel.Items.Add(New ListViewItem())
        l.Tag = u
        l.SubItems.AddRange(New String() {"", "", ""})
        RefreshAnggota()
    End Sub

    Function TranslateTipe(index As String) As TipeAnggota
        If (index > 23) Then Return index - 3
        If (index > 11) Then Return index - 2
        If (index > 0) Then Return index - 1
        Return index
    End Function
    Sub RefreshAnggota()
        Helper.Rekalkulasi()
        _Tabel.BeginUpdate()
        For Each x As ListViewItem In _Tabel.Items
            Dim u As UnitAnggota = x.Tag
            x.Text = u.nama
            x.SubItems(1).Text = Helper.Anggota2String(u.tipe)
            x.SubItems(2).Text = Helper.Jatah2String(u.hasil_jatah)
            x.SubItems(3).Text = "Rp. " + u.hasil_waris.ToString("##,#0")
        Next
        If (_Tabel.SelectedItems.Count = 0) Then
            Button1.Text = "Reset"
        Else
            Button1.Text = "Hapus"
        End If

        RefreshStatusMode()
        _Tabel.EndUpdate()
    End Sub

    Sub RefreshStatusMode()
        If (Helper.Hasil_Cukup = 0) Then
            _ModeAulRodd.Text = "Tidak ada Sisa"
            _ModeAulRodd.Enabled = False
            _ModeAulRodd.Checked = False
        ElseIf Helper.Hasil_Cukup = 2 Then
            _ModeAulRodd.Text = "Ar Rodd"
            _ModeAulRodd.Enabled = True
        Else _ModeAulRodd.Text = "Al 'Aul"
            _ModeAulRodd.Enabled = True
        End If
        If Not _ModeAulRodd.Checked And Not Helper.Hasil_Cukup = 0 Then
            _Total.Text = "Total: " + Math.Round(Helper.Hasil_Total).ToString("#,##0.##")
            _Sisa.Text = "Sisa: " + Math.Round(Helper.Hasil_Sisa).ToString("#,##0.##")

        Else
            _Total.Text = ""
            _Sisa.Text = ""


        End If
    End Sub

    Sub KirimKePrinter()
        'Print = New PrintJob()
        ' PrintDiag.Document = PrintDoc
        'PrintPrev.ShowDialog()
        If (PrintDiag.ShowDialog() = DialogResult.OK) Then PrintDoc.Print()
    End Sub

    Private Sub _Modal_TextChanged(sender As Object, e As EventArgs) Handles _Modal.TextChanged
        If Double.TryParse(_Modal.Text, Helper.TotalWaris) Then RefreshAnggota()
    End Sub

    Private Sub _ModeAulRodd_CheckedChanged(sender As Object, e As EventArgs) Handles _ModeAulRodd.CheckedChanged
        Helper.ModelAulRodd = _ModeAulRodd.Checked
        RefreshAnggota()

    End Sub

    Private Sub _Submit_Click_1(sender As Object, e As EventArgs) Handles _Submit.Click
        TambahKeDaftar(_Nama.Text, TranslateTipe(_Tingkat.SelectedIndex))
        _Nama.Text = String.Empty
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If _Tabel.SelectedItems.Count = 0 Then
            If (MsgBox("Yakin ingin menghapus semua anggota?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No) Then Return
            _Tabel.Items.Clear()
            Helper.anggotas.Clear()
        Else
            For Each x As ListViewItem In _Tabel.SelectedItems
                Helper.anggotas.Remove(x.Tag)
                _Tabel.Items.Remove(x)
            Next
        End If
        RefreshAnggota()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub _Tabel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _Tabel.SelectedIndexChanged
        If (_Tabel.SelectedItems.Count = 0) Then
            Button1.Text = "Reset"
        Else
            Button1.Text = "Hapus"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KirimKePrinter()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        _Tingkat.SelectedIndex = 0
    End Sub
End Class