
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Drawing;

public partial class Form1
{


	int Queried;
	int QueriedPage;
	float PanjangLaman;
	Point PosisiLaman;
	Font f;

	const int  MaxListPerPage = 25;
	private void PrintDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
	{
		Queried = 0;
		QueriedPage = 0;
		f = new Font("Times New Roman", 12);
	}

	private void PrintDocument1_PrintPage(System.Object sender, PrintPageEventArgs e)
	{
		e.PageSettings.Margins = new Margins(50, 50, 100, 100);
		var m = e.PageSettings.Margins;
		PosisiLaman = new Point(m.Left, m.Top);
		PanjangLaman = e.PageSettings.PrintableArea.Width - m.Left - m.Right;

        QueriedPage = 0;
		DrawHeader(e.Graphics);
		for (int index = 0; index <= MaxListPerPage; index++) {
			if (Helper.anggotas.Count >= Queried + QueriedPage * MaxListPerPage)
				break; 
			DrawPerAnggota(e.Graphics);
			Queried += 1;
		}
		e.HasMorePages = Helper.anggotas.Count > (QueriedPage + 1) * MaxListPerPage;
	}

	public void DrawPerAnggota(Graphics g)
	{
		dynamic idx = Queried + QueriedPage * MaxListPerPage;
		dynamic a = Helper.anggotas[idx];
		dynamic b = new SolidBrush(Color.Black);
		int r = 0;
		Math.DivRem(idx, 2, out r);
		if (r == 0) {
			g.FillRectangle(new SolidBrush(Color.WhiteSmoke), new Rectangle(LokasiAngka(), new Size((int)PanjangLaman, 20)));
		}
		g.DrawString((idx + 1).ToString(), f, b, LokasiAngka());
		g.DrawString(a.nama, f, b, LokasiNama());
		g.DrawString(Helper.Anggota2String(a.tipe), f, b, LokasiTipe());
		g.DrawString(Helper.Jatah2String(a.hasil_jatah), f, b, LokasiJatah());
		g.DrawString("Rp. " + a.hasil_waris.ToString("##,#0"), f, b, LokasiWaris());

	}

	public void DrawHeader(Graphics g)
	{
		Queried = -2;
		dynamic b = new SolidBrush(Color.Black);
		g.DrawImage(Faroidh.Properties.Resources.HeaderImg, PosisiLaman.X, Convert.ToInt32(PosisiLaman.Y - PanjangLaman * 0.121 + 50), Convert.ToInt32(PanjangLaman), Convert.ToInt32(PanjangLaman * 0.121));
		g.FillRectangle(new SolidBrush(Color.DarkGray), new Rectangle(PosisiLaman.X, PosisiLaman.Y + 50, (int)PanjangLaman, 40));
		g.DrawString("NO", f, b, LokasiAngka());
		g.DrawString("NAMA", f, b, LokasiNama());
		g.DrawString("STATUS", f, b, LokasiTipe());
		g.DrawString("BAGIAN", f, b, LokasiJatah());
		g.DrawString("JATAH", f, b, LokasiWaris());
		g.DrawLine(new Pen(b), PosisiLaman.X, PosisiLaman.Y + 90, PosisiLaman.X + PanjangLaman, PosisiLaman.Y + 90);
		g.DrawLine(new Pen(b), PosisiLaman.X, PosisiLaman.Y + 50, PosisiLaman.X + PanjangLaman, PosisiLaman.Y + 50);
		Queried = 0;
	}

	public Point LokasiAngka()
	{
		return new Point((int)(PosisiLaman.X + PanjangLaman * 0.00), PosisiLaman.Y + Queried * 20 + 100);
	}

	public Point LokasiNama()
	{
		return new Point((int)(PosisiLaman.X + PanjangLaman * 0.05), PosisiLaman.Y + Queried * 20 + 100);
	}

	public Point LokasiTipe()
	{
		return new Point((int)(PosisiLaman.X + PanjangLaman * 0.25), PosisiLaman.Y + Queried * 20 + 100);
	}

	public Point LokasiJatah()
	{
		return new Point((int)(PosisiLaman.X + PanjangLaman * 0.6), PosisiLaman.Y + Queried * 20 + 100);
	}

	public Point LokasiWaris()
	{
		return new Point((int)(PosisiLaman.X + PanjangLaman * 0.8), PosisiLaman.Y + Queried * 20 + 100);
	}


}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
