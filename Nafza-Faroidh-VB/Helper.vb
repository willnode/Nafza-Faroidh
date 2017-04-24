Public Class Helper
    Public Shared Sub TentukanJatah()
        'mnjalankan perinyah : sub
        For Each u As UnitAnggota In anggotas
            Select Case u.tipe
                Case TipeAnggota.Bapak
                    u.hasil_jatah = Jatah_Bapak()
                Case TipeAnggota.Ibu
                    u.hasil_jatah = Jatah_Ibu()
                Case TipeAnggota.Kakek
                    u.hasil_jatah = Jatah_kakek()
                Case TipeAnggota.Nenek
                    u.hasil_jatah = Jatah_Nenek()
                Case TipeAnggota.AnakLelaki
                    u.hasil_jatah = Jatah_AnakLelaki()
                Case TipeAnggota.AnakPerempuan
                    u.hasil_jatah = Jatah_AnakPerempuan()
                Case TipeAnggota.CucuLelakiAnakLelaki
                    u.hasil_jatah = Jatah_CucuLelakiAnakLelaki()
                Case TipeAnggota.CucuPerempuanAnakLelaki
                    u.hasil_jatah = Jatah_CucuPerempuanAnakLelaki()
                Case TipeAnggota.Suami
                    u.hasil_jatah = Jatah_Suami()
                Case TipeAnggota.Istri
                    u.hasil_jatah = Jatah_Istri()
                Case TipeAnggota.SaudaraLelakiSekandung
                    u.hasil_jatah = Jatah_SaudaraLelakiSekandung()
                Case TipeAnggota.SaudaraPerempuanSekandung
                    u.hasil_jatah = Jatah_SaudaraPerempuanSekandung()
                Case TipeAnggota.SaudaraLelakiSebapak
                    u.hasil_jatah = Jatah_SaudaraLelakiSebapak()
                Case TipeAnggota.SaudaraPerempuanSebapak
                    u.hasil_jatah = Jatah_SaudaraPerempuanSebapak()
                Case TipeAnggota.AnakLelakiSaudaraLelakiSekandung
                    u.hasil_jatah = Jatah_AnakLelakiSaudaraLelakiSekandung()
                Case TipeAnggota.AnakLelakiSaudaraLelakiSebapak
                    u.hasil_jatah = Jatah_AnakLelakiSaudaraLelakiSebapak()
                Case TipeAnggota.PamanBapakSekandung
                    u.hasil_jatah = Jatah_PamanBapakSekandung()
                Case TipeAnggota.PamanBapakSebapak
                    u.hasil_jatah = Jatah_PamanBapakSebapak()
                Case TipeAnggota.AnakLelakiPamanBapakSekandung
                    u.hasil_jatah = Jatah_AnakLelakiPamanBapakSekandung()
                Case TipeAnggota.AnakLelakiPamanBapakSebapak
                    u.hasil_jatah = Jatah_AnakLelakiPamanBapakSebapak()
                Case TipeAnggota.SaudaraSeibu
                    u.hasil_jatah = Jatah_SaudaraSeibu()
                Case TipeAnggota.Wala
                    u.hasil_jatah = Jatah_Wala()
            End Select
        Next
    End Sub
    Shared Function Jatah_Bapak() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Then
            Return Jatah.SatuPerEnam
        ElseIf Adakah(TipeAnggota.AnakPerempuan) Or Adakah(TipeAnggota.CucuPerempuanAnakLelaki) Then
            Return Jatah.ADanSeperenam
        Else
            Return Jatah.A
        End If
    End Function

    Shared Function Jatah_Ibu() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) _
            Or Adakah(TipeAnggota.AnakPerempuan) Or Adakah(TipeAnggota.CucuPerempuanAnakLelaki) _
            Or Adakah(TipeAnggota.SaudaraLelakiSebapak) > 1 _
            Or Adakah(TipeAnggota.SaudaraLelakiSekandung) > 1 _
            Or Adakah(TipeAnggota.SaudaraPerempuanSebapak) > 1 _
            Or Adakah(TipeAnggota.SaudaraPerempuanSekandung) > 1 _
            Or Adakah(TipeAnggota.SaudaraSeibu) > 1 Then
            Return Jatah.SatuPerEnam
        Else
            Return Jatah.SatuPerTiga
        End If
    End Function
    Shared Function Jatah_kakek() As Jatah
        If Adakah(TipeAnggota.Bapak) Then
            Return Jatah.M
        ElseIf Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Then
            Return Jatah.SatuPerEnam
        ElseIf Adakah(TipeAnggota.AnakPerempuan) Or Adakah(TipeAnggota.CucuPerempuanAnakLelaki) Then
            Return Jatah.ADanSeperenam
        Else
            Return Jatah.A
        End If
    End Function
    Shared Function Jatah_Nenek() As Jatah
        If Adakah(TipeAnggota.Ibu) Then
            Return Jatah.M
        Else
            Return Jatah.SatuPerEnam
        End If
    End Function
    Shared Function Jatah_AnakLelaki() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Then
            Return Jatah.A
        Else
            Return Jatah.A
        End If
    End Function
    Shared Function Jatah_AnakPerempuan() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Then
            Return Jatah.AB
        ElseIf Adakah(TipeAnggota.AnakPerempuan) > 1 Then
            Return Jatah.DuaPerTiga
        Else
            Return Jatah.SatuPerDua
        End If
    End Function
    Shared Function Jatah_CucuLelakiAnakLelaki() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Then
            Return Jatah.M
        Else
            Return Jatah.A
        End If
    End Function
    Shared Function Jatah_CucuPerempuanAnakLelaki() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or (Adakah(TipeAnggota.AnakPerempuan) > 1 _
            And Not Adakah(TipeAnggota.CucuLelakiAnakLelaki) > 0) Then
            Return Jatah.M
        ElseIf Adakah(TipeAnggota.CucuLelakiAnakLelaki) Then
            Return Jatah.AB
        ElseIf Adakah(TipeAnggota.AnakPerempuan) Then
            Return Jatah.SatuPerEnam
        ElseIf Adakah(TipeAnggota.CucuPerempuanAnakLelaki) > 1 Then
            Return Jatah.DuaPerTiga
        Else
            Return Jatah.SatuPerDua
        End If
    End Function
    Shared Function Jatah_Suami() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) _
            Or Adakah(TipeAnggota.AnakPerempuan) Or Adakah(TipeAnggota.CucuPerempuanAnakLelaki) Then
            Return Jatah.SatuPerEmpat
        Else
            Return Jatah.SatuPerDua
        End If
    End Function

    Shared Function Jatah_Istri() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) _
            Or Adakah(TipeAnggota.AnakPerempuan) Or Adakah(TipeAnggota.CucuPerempuanAnakLelaki) Then
            Return Jatah.SatuPerDelapan
        Else
            Return Jatah.SatuPerEmpat
        End If
    End Function
    Shared Function Jatah_SaudaraPerempuanSekandung() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) _
            Or Adakah(TipeAnggota.Bapak) Then
            Return Jatah.M
        ElseIf Adakah(TipeAnggota.SaudaraLelakiSekandung) Then
            Return Jatah.AB
        ElseIf Adakah(TipeAnggota.AnakPerempuan) Or Adakah(TipeAnggota.CucuPerempuanAnakLelaki) Then
            Return Jatah.AM
        ElseIf Adakah(TipeAnggota.SaudaraPerempuanSekandung) > 1 Then
            Return Jatah.DuaPerTiga
        Else
            Return Jatah.SatuPerDua
        End If
    End Function
    Shared Function Jatah_SaudaraPerempuanSebapak() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) _
            Or Adakah(TipeAnggota.Bapak) Or Adakah(TipeAnggota.SaudaraLelakiSekandung) Then
            Return Jatah.M
        ElseIf Adakah(TipeAnggota.SaudaraPerempuanSekandung) And
            (Adakah(TipeAnggota.AnakPerempuan) Or Adakah(TipeAnggota.CucuPerempuanAnakLelaki)) And
            Not Adakah(TipeAnggota.SaudaraLelakiSekandung) > 0 And Not (Adakah(TipeAnggota.AnakLelaki) > 0 _
            Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Or Adakah(TipeAnggota.Bapak)) Then
            Return Jatah.M
        ElseIf (Adakah(TipeAnggota.SaudaraPerempuanSekandung) > 1 And Not Adakah(TipeAnggota.SaudaraLelakiSebapak) > 0) Then
            Return Jatah.M
        ElseIf Adakah(TipeAnggota.SaudaraLelakiSebapak) Then
            Return Jatah.AB
        ElseIf Adakah(TipeAnggota.AnakPerempuan) Or Adakah(TipeAnggota.CucuPerempuanAnakLelaki) _
            And Not Adakah(TipeAnggota.SaudaraPerempuanSekandung) > 0 Then
            Return Jatah.AM
        ElseIf Adakah(TipeAnggota.SaudaraPerempuanSebapak) > 1 Then
            Return Jatah.DuaPerTiga
        ElseIf Adakah(TipeAnggota.SaudaraPerempuanSekandung) Then
            Return Jatah.SatuPerEnam
        Else
            Return Jatah.SatuPerDua
        End If
    End Function
    Shared Function Jatah_SaudaraLelakiSebapak() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.Kakek) Or Adakah(TipeAnggota.Bapak) _
            Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Or Adakah(TipeAnggota.SaudaraLelakiSekandung) Then
            Return Jatah.M
        Else
            Return Jatah.A
        End If
    End Function
    Shared Function Jatah_SaudaraLelakiSekandung() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.Kakek) Or Adakah(TipeAnggota.Bapak) _
            Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Then
            Return Jatah.M
        Else
            Return Jatah.A
        End If
    End Function
    Shared Function Jatah_AnakLelakiSaudaraLelakiSekandung() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.Kakek) Or Adakah(TipeAnggota.Bapak) _
            Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Or Adakah(TipeAnggota.SaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.SaudaraLelakiSebapak) Then
            Return Jatah.M
        Else
            Return Jatah.A
        End If
    End Function
    Shared Function Jatah_AnakLelakiSaudaraLelakiSebapak() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.Kakek) Or Adakah(TipeAnggota.Bapak) _
            Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Or Adakah(TipeAnggota.SaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.SaudaraLelakiSebapak) Or Adakah(TipeAnggota.AnakLelakiSaudaraLelakiSekandung) Then
            Return Jatah.M
        Else
            Return Jatah.A
        End If
    End Function
    Shared Function Jatah_PamanBapakSekandung() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.Kakek) Or Adakah(TipeAnggota.Bapak) _
            Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Or Adakah(TipeAnggota.SaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.SaudaraLelakiSebapak) Or Adakah(TipeAnggota.AnakLelakiSaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.AnakLelakiSaudaraLelakiSebapak) Then
            Return Jatah.M
        Else
            Return Jatah.A
        End If
    End Function
    Shared Function Jatah_PamanBapakSebapak() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.Kakek) Or Adakah(TipeAnggota.Bapak) _
            Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Or Adakah(TipeAnggota.SaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.SaudaraLelakiSebapak) Or Adakah(TipeAnggota.AnakLelakiSaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.AnakLelakiSaudaraLelakiSebapak) _
            Or Adakah(TipeAnggota.PamanBapakSekandung) Then
            Return Jatah.M
        Else
            Return Jatah.A
        End If
    End Function
    Shared Function Jatah_AnakLelakiPamanBapakSebapak() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.Kakek) Or Adakah(TipeAnggota.Bapak) _
            Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Or Adakah(TipeAnggota.SaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.SaudaraLelakiSebapak) Or Adakah(TipeAnggota.AnakLelakiSaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.AnakLelakiSaudaraLelakiSebapak) _
            Or Adakah(TipeAnggota.PamanBapakSekandung) Or Adakah(TipeAnggota.PamanBapakSebapak) _
            Or Adakah(TipeAnggota.AnakLelakiPamanBapakSekandung) Then
            Return Jatah.M
        Else
            Return Jatah.A
        End If
    End Function
    Shared Function Jatah_AnakLelakiPamanBapakSekandung() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.Kakek) Or Adakah(TipeAnggota.Bapak) _
            Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Or Adakah(TipeAnggota.SaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.SaudaraLelakiSebapak) Or Adakah(TipeAnggota.AnakLelakiSaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.AnakLelakiSaudaraLelakiSebapak) _
            Or Adakah(TipeAnggota.PamanBapakSekandung) Or Adakah(TipeAnggota.PamanBapakSebapak) Then
            Return Jatah.M
        Else
            Return Jatah.A
        End If
    End Function
    Shared Function Jatah_SaudaraSeibu() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) _
            Or Adakah(TipeAnggota.Bapak) Or Adakah(TipeAnggota.Kakek) _
            Or Adakah(TipeAnggota.AnakPerempuan) Or Adakah(TipeAnggota.CucuPerempuanAnakLelaki) Then
            Return Jatah.M
        ElseIf Adakah(TipeAnggota.SaudaraSeibu) > 1 Then
            Return Jatah.SatuPerTiga
        Else
            Return Jatah.SatuPerEnam
        End If
    End Function
    Shared Function Jatah_Wala() As Jatah
        If Adakah(TipeAnggota.AnakLelaki) Or Adakah(TipeAnggota.Kakek) Or Adakah(TipeAnggota.Bapak) _
            Or Adakah(TipeAnggota.CucuLelakiAnakLelaki) Or Adakah(TipeAnggota.SaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.SaudaraLelakiSebapak) Or Adakah(TipeAnggota.AnakLelakiSaudaraLelakiSekandung) _
            Or Adakah(TipeAnggota.AnakLelakiSaudaraLelakiSebapak) _
            Or Adakah(TipeAnggota.PamanBapakSekandung) Or Adakah(TipeAnggota.PamanBapakSebapak) _
            Or Adakah(TipeAnggota.AnakLelakiPamanBapakSekandung) Or Adakah(TipeAnggota.AnakLelakiPamanBapakSebapak) Then
            Return Jatah.M
        Else
            Return Jatah.A
        End If
    End Function
End Class

Public Class UnitAnggota
    Public nama As String
    Public tipe As TipeAnggota
    Public hasil_jatah As Jatah
    Public hasil_waris As Double
End Class

Public Enum Jatah
    SatuPerDua = 0
    SatuPerEmpat = 1
    DuaPerTiga = 2
    SatuPerDelapan = 3
    SatuPerEnam = 4
    SatuPerTiga = 5
    ADanSeperenam = 6
    AB = 7
    AM = 8
    A = 9
    M = 10
End Enum

Public Enum TipeAnggota
    Bapak = 0
    Ibu = 1
    Kakek = 2
    Nenek = 3
    AnakLelaki = 4
    AnakPerempuan = 5
    CucuLelakiAnakLelaki = 6
    CucuPerempuanAnakLelaki = 7
    Suami = 8
    Istri = 9
    SaudaraLelakiSekandung = 10
    SaudaraPerempuanSekandung = 11
    SaudaraLelakiSebapak = 12
    SaudaraPerempuanSebapak = 13
    AnakLelakiSaudaraLelakiSekandung = 14
    AnakLelakiSaudaraLelakiSebapak = 15
    PamanBapakSekandung = 16
    PamanBapakSebapak = 17
    AnakLelakiPamanBapakSekandung = 18
    AnakLelakiPamanBapakSebapak = 19
    SaudaraSeibu = 20
    Wala = 21
End Enum

Public Enum ModelPenghitungan
    Normal = 0
    Aul = 1
    Radd = 2
End Enum