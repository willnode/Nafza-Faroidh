Imports System.Drawing.Printing

Partial Public Class Form1

    Dim Queried As Integer
    Dim QueriedPage As Integer
    Dim PanjangLaman As Decimal
    Dim PosisiLaman As Point
    Dim f As Font
    Const MaxListPerPage = 25

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDoc.BeginPrint
        Queried = 0
        QueriedPage = 0
        f = New Font("Times New Roman", 12)
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        e.PageSettings.Margins = New Margins(50, 50, 100, 100)
        Dim m = e.PageSettings.Margins
        PosisiLaman = New Point(m.Left, m.Top)
        PanjangLaman = e.PageSettings.PrintableArea.Width - m.Left - m.Right
        'MyBase.OnPrintPage(e)
        'QueriedPage += 1
        QueriedPage = 0
        DrawHeader(e.Graphics)
        For index = 0 To MaxListPerPage
            If Helper.anggotas.Count >= Queried + QueriedPage * MaxListPerPage Then Exit For
            DrawPerAnggota(e.Graphics)
            Queried += 1
        Next
        e.HasMorePages = Helper.anggotas.Count > (QueriedPage + 1) * MaxListPerPage
    End Sub

    Sub DrawPerAnggota(g As Graphics)
        Dim idx = Queried + QueriedPage * MaxListPerPage
        Dim a = Helper.anggotas(idx)
        Dim b = New SolidBrush(Color.Black)
        Dim r As Integer
        Math.DivRem(idx, 2, r)
        If r = 0 Then
            g.FillRectangle(New SolidBrush(Color.WhiteSmoke), New Rectangle(LokasiAngka(), New Size(PanjangLaman, 20)))
        End If
        g.DrawString(idx + 1, f, b, LokasiAngka())
        g.DrawString(a.nama, f, b, LokasiNama())
        g.DrawString(Helper.Anggota2String(a.tipe), f, b, LokasiTipe())
        g.DrawString(Helper.Jatah2String(a.hasil_jatah), f, b, LokasiJatah())
        g.DrawString("Rp. " + a.hasil_waris.ToString("##,#0"), f, b, LokasiWaris())

    End Sub

    Sub DrawHeader(g As Graphics)
        Queried = -2
        Dim b = New SolidBrush(Color.Black)
        g.DrawImage(My.Resources.HeaderImg, PosisiLaman.X, CInt(PosisiLaman.Y - PanjangLaman * 0.121 + 50), CInt(PanjangLaman), CInt(PanjangLaman * 0.121))
        g.FillRectangle(New SolidBrush(Color.DarkGray), New Rectangle(PosisiLaman.X, PosisiLaman.Y + 50, PanjangLaman, 40))
        g.DrawString("NO", f, b, LokasiAngka())
        g.DrawString("NAMA", f, b, LokasiNama())
        g.DrawString("STATUS", f, b, LokasiTipe())
        g.DrawString("BAGIAN", f, b, LokasiJatah())
        g.DrawString("JATAH", f, b, LokasiWaris())
        g.DrawLine(New Pen(b), PosisiLaman.X, PosisiLaman.Y + 90, PosisiLaman.X + PanjangLaman, PosisiLaman.Y + 90)
        g.DrawLine(New Pen(b), PosisiLaman.X, PosisiLaman.Y + 50, PosisiLaman.X + PanjangLaman, PosisiLaman.Y + 50)
        Queried = 0
    End Sub

    Function LokasiAngka() As Point
        Return New Point(PosisiLaman.X + PanjangLaman * 0.0, PosisiLaman.Y + Queried * 20 + 100)
    End Function

    Function LokasiNama() As Point
        Return New Point(PosisiLaman.X + PanjangLaman * 0.05, PosisiLaman.Y + Queried * 20 + 100)
    End Function

    Function LokasiTipe() As Point
        Return New Point(PosisiLaman.X + PanjangLaman * 0.25, PosisiLaman.Y + Queried * 20 + 100)
    End Function

    Function LokasiJatah() As Point
        Return New Point(PosisiLaman.X + PanjangLaman * 0.6, PosisiLaman.Y + Queried * 20 + 100)
    End Function

    Function LokasiWaris() As Point
        Return New Point(PosisiLaman.X + PanjangLaman * 0.8, PosisiLaman.Y + Queried * 20 + 100)
    End Function


End Class
