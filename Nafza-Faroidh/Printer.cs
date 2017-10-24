using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nafza_Faroidh
{
    public class PrintJob
    {

        static int Queried;
        static int QueriedPage;
        static float PanjangLaman;
        static Point PosisiLaman;
        static Font f;

        const int MaxListPerPage = 25;

        public static void Print ()
        {
            var doc = new PrintDocument();
            doc.BeginPrint += PrintDocument1_BeginPrint;
            doc.PrintPage += PrintDocument1_PrintPage;
            //var prev = new PrintPreviewDialog();
            //prev.Document = doc;
            //prev.Show();
            var set = new PrintDialog();
            set.Document = doc;
            if (set.ShowDialog() == DialogResult.OK)
                doc.Print();
        }
        private static void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            Queried = 0;
            QueriedPage = 0;
            f = new Font("Times New Roman", 12);
        }

        private static void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.PageSettings.Margins = new Margins(50, 50, 100, 100);
            var m = e.PageSettings.Margins;
            PosisiLaman = new Point(m.Left, m.Top);
            PanjangLaman = e.PageSettings.PrintableArea.Width - m.Left - m.Right;

            QueriedPage = 0;
            DrawHeader(e.Graphics);
            for (int index = 0; index <= MaxListPerPage; index++)
            {
                if (Helper.anggotas.Count <= Queried + QueriedPage * MaxListPerPage)
                    break;
                DrawPerAnggota(e.Graphics);
                Queried += 1;
            }
            e.HasMorePages = Helper.anggotas.Count > (QueriedPage + 1) * MaxListPerPage;
        }

        private static  void DrawPerAnggota(Graphics g)
        {
            var idx = Queried + QueriedPage * MaxListPerPage;
            var a = Helper.anggotas[idx];
            var b = new SolidBrush(Color.Black);
            int r = 0;
            Math.DivRem(idx, 2, out r);
            if (r == 0)
            {
                g.FillRectangle(new SolidBrush(Color.WhiteSmoke), new Rectangle(LokasiAngka(), new Size((int)PanjangLaman, 20)));
            }
            g.DrawString((idx + 1).ToString(), f, b, LokasiAngka());
            g.DrawString(a.Nama, f, b, LokasiNama());
            g.DrawString(a.Tipe, f, b, LokasiTipe());
            g.DrawString(a.HasilJatah, f, b, LokasiJatah());
            g.DrawString(a.HasilWaris, f, b, LokasiWaris());

        }

        private static  void DrawHeader(Graphics g)
        {
            Queried = -2;
            dynamic b = new SolidBrush(Color.Black);
          //  g.DrawImage(Faroidh.Properties.Resources.HeaderImg, PosisiLaman.X, Convert.ToInt32(PosisiLaman.Y - PanjangLaman * 0.121 + 50), Convert.ToInt32(PanjangLaman), Convert.ToInt32(PanjangLaman * 0.121));
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

        private static  Point LokasiAngka()
        {
            return new Point((int)(PosisiLaman.X + PanjangLaman * 0.00), PosisiLaman.Y + Queried * 20 + 100);
        }

        private static  Point LokasiNama()
        {
            return new Point((int)(PosisiLaman.X + PanjangLaman * 0.05), PosisiLaman.Y + Queried * 20 + 100);
        }

        private static  Point LokasiTipe()
        {
            return new Point((int)(PosisiLaman.X + PanjangLaman * 0.25), PosisiLaman.Y + Queried * 20 + 100);
        }

        private static  Point LokasiJatah()
        {
            return new Point((int)(PosisiLaman.X + PanjangLaman * 0.6), PosisiLaman.Y + Queried * 20 + 100);
        }

        private static  Point LokasiWaris()
        {
            return new Point((int)(PosisiLaman.X + PanjangLaman * 0.8), PosisiLaman.Y + Queried * 20 + 100);
        }

    }
}
