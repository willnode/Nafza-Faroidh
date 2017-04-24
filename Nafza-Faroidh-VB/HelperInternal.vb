
Partial Public Class Helper
    'clas : WADAH U/ FUNGSI2 N VARIABLE
    'Public : clas (helper bsa d akses oleh kelas lainya
    'Partial : karena ada 2 helper yg sama ( helper ini aslinya bagian dari helper yg lain

    ' tmpat daftar anggota 
    Public Shared anggotas As List(Of UnitAnggota) = New List(Of UnitAnggota)()
    'list : variable majemuk yg fleksible 
    'shared : variable global : bsa di akses tanpa membuat variable baru 
    '..................................................."apakah anggota tipe sekian hadir???"
    Public Shared Adakah As Integer()
    'boolean : true or false
    'adakah: di bagi brdasarkan jatah
    '..................................................."Berapakah banya anggota???"
    Public Shared SumJatah As Integer()
    'integer : angka bulat
    ' sumjatah: berapa kah jumlah anggota dari bagian jatah
    '...................................................."setiap tipe jatah berapakah rasio warisnya???"
    Public Shared UnitHasil As Double()
    'unit hasil : rasio waris  yg didapat setia jatah 
    ' double :angka real 
    '...................................................."berapakah total warisnya???" 
    Public Shared TotalWaris As Double

    Public Shared Hasil_Total As Double

    Public Shared Hasil_Sisa As Double

    ''' <summary>
    ''' 0 = cukup, 1 = lebih, 2 = kurang dari persediaan waris
    ''' </summary>
    Public Shared Hasil_Cukup As Integer

    Public Shared ModelAulRodd As Boolean

    ' Rekalikuasi: proses lengkap dari penentuan setiap anggota hasil
    '...................................................."proses penghitungan dimulai dari sini!!!"
    Public Shared Sub Rekalkulasi()
        LoadAdakah()
        TentukanJatah()
        LoadMasuk()
        HitungUnitJatah()
        OutputWaris()
    End Sub

    Public Shared Function TambahAnggota(nama As String, tipe As TipeAnggota) As UnitAnggota
        Dim u As New UnitAnggota()
        u.nama = nama
        u.tipe = tipe
        anggotas.Add(u)
        Return u
    End Function

    Shared Sub LoadAdakah()
        'fungsi true n false bagian u/ pemisalan bagian bapak mnjadi 1/2 or 1/4
        Adakah = New Integer(50) {}
        For Each u As UnitAnggota In anggotas
            'each ; setiap 
            Adakah(u.tipe) += 1
        Next
    End Sub
    Shared Sub LoadMasuk()
        SumJatah = New Integer(11) {}
        For Each u As UnitAnggota In anggotas
            SumJatah(u.hasil_jatah) += 1
        Next
    End Sub

    Shared Sub HitungUnitJatah()
        Dim sisa As Double = 1
        UnitHasil = New Double(11) {}
        ' Hitung untuk bagian asli (pecahan)
        For i = 0 To 6
            If SumJatah(i) > 0 Then
                If (i = Jatah.SatuPerDua) Then UnitHasil(i) = 1.0 / 2.0
                If (i = Jatah.SatuPerTiga) Then UnitHasil(i) = 1.0 / 3.0
                If (i = Jatah.SatuPerEmpat) Then UnitHasil(i) = 1.0 / 4.0
                If (i = Jatah.SatuPerEnam) Then UnitHasil(i) = 1.0 / 6.0
                If (i = Jatah.SatuPerDelapan) Then UnitHasil(i) = 1.0 / 8.0
                If (i = Jatah.DuaPerTiga) Then UnitHasil(i) = 2.0 / 3.0
                If (i = Jatah.ADanSeperenam) Then UnitHasil(i) = 1.0 / 6.0


                sisa -= UnitHasil(i) * SumJatah(i)

            End If
        Next
        'Hitung untuk mencegah anggota yang >1... kehitung >1
        For i = 0 To 50
            If (Adakah(i) > 1 And Macro_TermasukDaftarDouble(i)) Then
                Dim iT As TipeAnggota = i
                Dim tipeJatah = anggotas.First(Function(x) x.tipe = iT).hasil_jatah
                sisa += UnitHasil(tipeJatah) * (SumJatah(tipeJatah) - 1)
                ' Gak pate' yakin?
                UnitHasil(tipeJatah) /= SumJatah(tipeJatah)
            End If
        Next
        'Hitung untuk bagian ashobah
        Dim sisaReal = Math.Max(0, sisa)
        For i = 6 To 9
            Dim P = Macro_JumlahFuruPerempuan()
            Dim L = Macro_JumlahFuruLakiLaki()
            Dim S = Macro_JumlahAshobah()
            If S = 0 Then Return
            If P > 0 Or L > 0 Then
                S += SumJatah(Jatah.A)
                If i = Jatah.AB Then ' wadon mesti AB
                    UnitHasil(i) += sisaReal / S ' iki wadon
                ElseIf i = Jatah.A Then
                    UnitHasil(i) += sisaReal / S * (2.0) ' iki lanang
                Else
                    UnitHasil(i) += sisaReal / S
                End If
            Else
                UnitHasil(i) += sisaReal / S
            End If
            ' UnitHasil(i) /= SumJatah(i)
        Next

    End Sub
    Shared Function Macro_JumlahFuruPerempuan() As Integer
        Return Adakah(TipeAnggota.AnakPerempuan) + Adakah(TipeAnggota.CucuPerempuanAnakLelaki)
    End Function
    Shared Function Macro_TermasukDaftarDouble(tipenya As TipeAnggota) As Integer
        Return tipenya = (TipeAnggota.AnakPerempuan) Or tipenya = (TipeAnggota.CucuPerempuanAnakLelaki) _
            Or tipenya = (TipeAnggota.SaudaraSeibu) _
        Or tipenya = (TipeAnggota.SaudaraPerempuanSebapak) Or tipenya = (TipeAnggota.SaudaraPerempuanSekandung)
    End Function
    Shared Function Macro_JumlahFuruLakiLaki() As Integer
        Return Adakah(TipeAnggota.AnakLelaki)
    End Function
    Shared Function Macro_JumlahAshobah() As Integer
        Return SumJatah(Jatah.AM) + SumJatah(Jatah.AB) + SumJatah(Jatah.A) + SumJatah(Jatah.ADanSeperenam)
    End Function
    Shared Function Macro_JumlahNonAshobah() As Integer
        Return SumJatah(Jatah.AM) + SumJatah(Jatah.AB) + SumJatah(Jatah.A)
    End Function
    Shared Function HitungPrioritasZaujah(jumlah As Double) As Boolean
        ' Cek jika Rodd ada dan memang ada Suami/Istri
        Dim suamiIstri = Adakah(TipeAnggota.Suami) + Adakah(TipeAnggota.Istri)
        If Not ((suamiIstri > 0) And ModelAulRodd) Then Return False

        ' Atur kalkulasi sendiri 
        If (suamiIstri = anggotas.Count) Then
            ' Cuma ada suami/istri doang
            Dim rasio = jumlah / suamiIstri
            For Each u As UnitAnggota In anggotas
                u.hasil_waris = rasio
            Next
        Else
            Dim jatahZauj = (From a As UnitAnggota In anggotas
                             Where (a.tipe = TipeAnggota.Suami Or a.tipe = TipeAnggota.Istri))(0).hasil_waris

            Dim rasio = (TotalWaris - jatahZauj) / (jumlah - jatahZauj)
            For Each u As UnitAnggota In anggotas
                If (u.tipe = TipeAnggota.Suami Or u.tipe = TipeAnggota.Istri) Then
                    u.hasil_waris = jatahZauj
                Else
                    u.hasil_waris *= rasio
                End If
            Next
        End If
        Return True
    End Function
    Shared Sub OutputWaris()
        ' Memori total dari jumlah waris dari tiap anggota
        Dim jumlah = 0.0
        ' Di setiap anggotas ..
        For Each u As UnitAnggota In anggotas
            u.hasil_waris = TotalWaris * UnitHasil(u.hasil_jatah)
            If Math.Abs(u.hasil_waris) < 0.01 Then u.hasil_waris = 0
            jumlah += Math.Max(u.hasil_waris, 0)
        Next
        Dim rasio = 1.0

        If jumlah = TotalWaris Then
            Hasil_Cukup = 0
        ElseIf jumlah > TotalWaris Then
            ' Aul
            Hasil_Cukup = 1
        Else
            ' Rodd
            Hasil_Cukup = 2
        End If

        ''If (Hasil_Cukup = 2) Then 

        If (Not jumlah = TotalWaris And ModelAulRodd) Then
            rasio = TotalWaris / jumlah
            Hasil_Total = TotalWaris
            Hasil_Sisa = 0
            If (Hasil_Cukup = 2 AndAlso HitungPrioritasZaujah(jumlah)) Then
                Return
            End If
        Else
            Hasil_Total = jumlah
            Hasil_Sisa = TotalWaris - jumlah
        End If
        If Math.Abs(Hasil_Sisa) < 0.01 Then Hasil_Sisa = 0
        If Math.Abs(Hasil_Total) < 0.01 Then Hasil_Total = 0

        If Not rasio = 1 Then
            For Each u As UnitAnggota In anggotas
                If u.hasil_waris < 0 Then
                    u.hasil_waris = 0
                Else
                    u.hasil_waris *= rasio
                End If
            Next
        End If
    End Sub
    Public Shared Function Jatah2String(j As Jatah) As String
        If j = Jatah.SatuPerDua Then
            Return "1/2"
        ElseIf j = Jatah.SatuPerEmpat Then
            Return "1/4"
        ElseIf j = Jatah.DuaPerTiga Then
            Return "2/3"
        ElseIf j = Jatah.SatuPerDelapan Then
            Return "1/8"
        ElseIf j = Jatah.SatuPerEnam Then
            Return "1/6"
        ElseIf j = Jatah.SatuPerTiga Then
            Return "1/3"
        ElseIf j = Jatah.M Then
            Return "Mahjub"
        ElseIf j = Jatah.AB Then
            Return "Ashobah Bil Ghoir"
        ElseIf j = Jatah.AM Then
            Return "Ashobah Ma'al Ghoir"
        ElseIf j = Jatah.A Then
            Return "Ashobah"
        ElseIf j = Jatah.ADanSeperenam Then
            Return "1/6 + Ashobah"
        End If
        Return ""
    End Function

    Public Shared Function Anggota2String(t As TipeAnggota) As String
        If t = TipeAnggota.AnakLelaki Then
            Return "Anak Lelaki"
        ElseIf t = TipeAnggota.AnakLelakiPamanBapakSebapak Then
            Return "Anak Lelaki Paman Seayah"
        ElseIf t = TipeAnggota.AnakLelakiPamanBapakSekandung Then
            Return "Anak Lelaki Paman Sekandung"
        ElseIf t = TipeAnggota.AnakLelakiSaudaraLelakiSebapak Then
            Return "Anak Lelaki Sdr Lelaki Seayah"
        ElseIf t = TipeAnggota.AnakLelakiSaudaraLelakiSekandung Then
            Return "Anak Lelaki Sdr Lelaki Sekandung"
        ElseIf t = TipeAnggota.CucuLelakiAnakLelaki Then
            Return "Cucu Lelaki dr Anak Lelaki"
        ElseIf t = TipeAnggota.AnakPerempuan Then
            Return "Anak Perempuan"
        ElseIf t = TipeAnggota.CucuPerempuanAnakLelaki Then
            Return "Cucu Perempuan dr Anak Lelaki"
        ElseIf t = TipeAnggota.PamanBapakSebapak Then
            Return "Paman Bapak Seayah"
        ElseIf t = TipeAnggota.PamanBapakSekandung Then
            Return "Paman Bapak Sekandung"
        ElseIf t = TipeAnggota.SaudaraLelakiSebapak Then
            Return "Sdr Lelaki Seayah"
        ElseIf t = TipeAnggota.SaudaraLelakiSekandung Then
            Return "Sdr Lelaki Sekandung"
        ElseIf t = TipeAnggota.SaudaraPerempuanSebapak Then
            Return "Sdr Perempuan Seayah"
        ElseIf t = TipeAnggota.SaudaraPerempuanSekandung Then
            Return "Sdr Perempuan Sekandung"
        ElseIf t = TipeAnggota.SaudaraSeibu Then
            Return "Saudara Seibu"
        ElseIf t = TipeAnggota.Bapak Then
            Return "Bapak"
        ElseIf t = TipeAnggota.Ibu Then
            Return "Ibu"
        ElseIf t = TipeAnggota.Istri Then
            Return "Istri"
        ElseIf t = TipeAnggota.Kakek Then
            Return "Kakek"
        ElseIf t = TipeAnggota.Nenek Then
            Return "Nenek"
        ElseIf t = TipeAnggota.Suami Then
            Return "Suami"
        ElseIf t = TipeAnggota.Wala Then
            Return "Wala'"
        End If
        Return ""
    End Function

    Public Shared Function PickAnyNama()
        Dim x = Math.Floor(randomer.NextDouble() * namaKarep.Length)
        Return namaKarep(CInt(x))
    End Function

    Public Shared Function VerifikasiAnggota(kandidat As TipeAnggota) As Boolean
        LoadAdakah()
        If (kandidat = TipeAnggota.Bapak And Adakah(TipeAnggota.Bapak)) Then
            MsgBox("Gak mungkin, kawan,,!!!", MsgBoxStyle.Exclamation, "Mustahil")
            Return False
        End If
        If (kandidat = TipeAnggota.Suami And Adakah(TipeAnggota.Istri)) Then
            MsgBox("terus siapa yang meniggal..???", MsgBoxStyle.Exclamation, "Mustahil")
            Return False
        End If
        If (kandidat = TipeAnggota.Istri And Adakah(TipeAnggota.Suami)) Then
            MsgBox("terus siapa yang meniggal..???", MsgBoxStyle.Exclamation, "Mustahil")
            Return False
        End If

        If (kandidat = TipeAnggota.Ibu And Adakah(TipeAnggota.Ibu)) Then
            MsgBox("cukup satu ibu kandung di Dunia ini,,,", MsgBoxStyle.Exclamation, "melanggar hukum alam")
            Return False
        End If

        If (kandidat = TipeAnggota.Suami And Adakah(TipeAnggota.Suami)) Then
            MsgBox("Seorang istri tidak boleh memiliki 2 suami", MsgBoxStyle.Exclamation, "Melanggar syari'at")
            Return False
        End If

        If (kandidat = TipeAnggota.Istri And Adakah(TipeAnggota.Istri) > 3) Then
            MsgBox("4 istri cukup.. !!!
Gak boleh serakah,kawan!", MsgBoxStyle.Exclamation, "POligami")
            Return False
        End If
        If (kandidat = TipeAnggota.Kakek And Adakah(TipeAnggota.Kakek)) Then
            MsgBox("Hanya kakek Shohih yang dapat bagian..!! ", MsgBoxStyle.Exclamation, "Problem")
            Return False
        End If
        If (kandidat = TipeAnggota.Nenek And Adakah(TipeAnggota.Nenek) > 1) Then
            MsgBox("Hanya Nenek Shohihah yang dapat bagian..!! ", MsgBoxStyle.Exclamation, "Problem")
            Return False
        End If
        Return True
    End Function

    Shared randomer = New Random()
    Shared namaKarep = New String() {"fulan", "insan", "Nizam", "Zaki", "Syaiful", "Faiz", "Afif", "Irfan", "Ali", "Samba", "Rusli", "Rifqy", "Himam", "Obey", "Faza"}
    Public Class AComparer
        Inherits Comparer(Of UnitAnggota)

        Public Overrides Function Compare(x As UnitAnggota, y As UnitAnggota) As Integer
            Return x.hasil_jatah.CompareTo(y.hasil_jatah)
        End Function
    End Class
End Class
