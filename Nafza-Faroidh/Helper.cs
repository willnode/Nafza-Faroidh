using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nafza_Faroidh
{
    public partial class Helper
    {
        public static void TentukanJatah()
        {
            foreach (Anggota u in anggotas)
            {

                if (u.tipe == TipeAnggota.Bapak)
                    u.hasil_jatah = Jatah_Bapak();

                if (u.tipe == TipeAnggota.Ibu)
                    u.hasil_jatah = Jatah_Ibu();

                if (u.tipe == TipeAnggota.Kakek)
                    u.hasil_jatah = Jatah_kakek();

                if (u.tipe == TipeAnggota.Nenek)
                    u.hasil_jatah = Jatah_Nenek();

                if (u.tipe == TipeAnggota.AnakLelaki)
                    u.hasil_jatah = Jatah_AnakLelaki();

                if (u.tipe == TipeAnggota.AnakPerempuan)
                    u.hasil_jatah = Jatah_AnakPerempuan();

                if (u.tipe == TipeAnggota.CucuLelakiAnakLelaki)
                    u.hasil_jatah = Jatah_CucuLelakiAnakLelaki();

                if (u.tipe == TipeAnggota.CucuPerempuanAnakLelaki)
                    u.hasil_jatah = Jatah_CucuPerempuanAnakLelaki();

                if (u.tipe == TipeAnggota.Suami)
                    u.hasil_jatah = Jatah_Suami();

                if (u.tipe == TipeAnggota.Istri)
                    u.hasil_jatah = Jatah_Istri();

                if (u.tipe == TipeAnggota.SaudaraLelakiSekandung)
                    u.hasil_jatah = Jatah_SaudaraLelakiSekandung();

                if (u.tipe == TipeAnggota.SaudaraPerempuanSekandung)
                    u.hasil_jatah = Jatah_SaudaraPerempuanSekandung();

                if (u.tipe == TipeAnggota.SaudaraLelakiSebapak)
                    u.hasil_jatah = Jatah_SaudaraLelakiSebapak();

                if (u.tipe == TipeAnggota.SaudaraPerempuanSebapak)
                    u.hasil_jatah = Jatah_SaudaraPerempuanSebapak();

                if (u.tipe == TipeAnggota.AnakLelakiSaudaraLelakiSekandung)
                    u.hasil_jatah = Jatah_AnakLelakiSaudaraLelakiSekandung();

                if (u.tipe == TipeAnggota.AnakLelakiSaudaraLelakiSebapak)
                    u.hasil_jatah = Jatah_AnakLelakiSaudaraLelakiSebapak();

                if (u.tipe == TipeAnggota.PamanBapakSekandung)
                    u.hasil_jatah = Jatah_PamanBapakSekandung();

                if (u.tipe == TipeAnggota.PamanBapakSebapak)
                    u.hasil_jatah = Jatah_PamanBapakSebapak();

                if (u.tipe == TipeAnggota.AnakLelakiPamanBapakSekandung)
                    u.hasil_jatah = Jatah_AnakLelakiPamanBapakSekandung();

                if (u.tipe == TipeAnggota.AnakLelakiPamanBapakSebapak)
                    u.hasil_jatah = Jatah_AnakLelakiPamanBapakSebapak();

                if (u.tipe == TipeAnggota.SaudaraSeibu)
                    u.hasil_jatah = Jatah_SaudaraSeibu();
                if (u.tipe == TipeAnggota.Wala)
                    u.hasil_jatah = Jatah_Wala();
            }
        }
        public static Jatah Jatah_Bapak()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0)
            {
                return Jatah.SatuPerEnam;
            }
            else if (adakah[TipeAnggota.AnakPerempuan] > 0 | adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0)
            {
                return Jatah.ADanSeperenam;
            }
            else
            {
                return Jatah.A;
            }
        }

        public static Jatah Jatah_Ibu()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.AnakPerempuan] > 0 | adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0 | adakah[TipeAnggota.SaudaraLelakiSebapak] > 1 | adakah[TipeAnggota.SaudaraLelakiSekandung] > 1 | adakah[TipeAnggota.SaudaraPerempuanSebapak] > 1 | adakah[TipeAnggota.SaudaraPerempuanSekandung] > 1 | adakah[TipeAnggota.SaudaraSeibu] > 1)
            {
                return Jatah.SatuPerEnam;
            }
            else
            {
                return Jatah.SatuPerTiga;
            }
        }

        public static Jatah Jatah_kakek()
        {
            if (adakah[TipeAnggota.Bapak] > 0)
            {
                return Jatah.M;
            }
            else if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0)
            {
                return Jatah.SatuPerEnam;
            }
            else if (adakah[TipeAnggota.AnakPerempuan] > 0 | adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0)
            {
                return Jatah.ADanSeperenam;
            }
            else
            {
                return Jatah.A;
            }
        }
        public static Jatah Jatah_Nenek()
        {
            if (adakah[TipeAnggota.Ibu] > 0)
            {
                return Jatah.M;
            }
            else
            {
                return Jatah.SatuPerEnam;
            }
        }
        public static Jatah Jatah_AnakLelaki()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0)
            {
                return Jatah.A;
            }
            else
            {
                return Jatah.A;
            }
        }
        public static Jatah Jatah_AnakPerempuan()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0)
            {
                return Jatah.AB;
            }
            else if (adakah[TipeAnggota.AnakPerempuan] > 1)
            {
                return Jatah.DuaPerTiga;
            }
            else
            {
                return Jatah.SatuPerDua;
            }
        }
        public static Jatah Jatah_CucuLelakiAnakLelaki()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0)
            {
                return Jatah.M;
            }
            else
            {
                return Jatah.A;
            }
        }
        public static Jatah Jatah_CucuPerempuanAnakLelaki()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | (adakah[TipeAnggota.AnakPerempuan] > 1 & !(adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0)))
            {
                return Jatah.M;
            }
            else if (adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0)
            {
                return Jatah.AB;
            }
            else if (adakah[TipeAnggota.AnakPerempuan] > 0)
            {
                return Jatah.SatuPerEnam;
            }
            else if (adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 1)
            {
                return Jatah.DuaPerTiga;
            }
            else
            {
                return Jatah.SatuPerDua;
            }
        }
        public static Jatah Jatah_Suami()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.AnakPerempuan] > 0 | adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0)
            {
                return Jatah.SatuPerEmpat;
            }
            else
            {
                return Jatah.SatuPerDua;
            }
        }

        public static Jatah Jatah_Istri()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.AnakPerempuan] > 0 | adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0)
            {
                return Jatah.SatuPerDelapan;
            }
            else
            {
                return Jatah.SatuPerEmpat;
            }
        }
        public static Jatah Jatah_SaudaraPerempuanSekandung()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.Bapak] > 0)
            {
                return Jatah.M;
            }
            else if (adakah[TipeAnggota.SaudaraLelakiSekandung] > 0)
            {
                return Jatah.AB;
            }
            else if (adakah[TipeAnggota.AnakPerempuan] > 0 | adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0)
            {
                return Jatah.AM;
            }
            else if (adakah[TipeAnggota.SaudaraPerempuanSekandung] > 1)
            {
                return Jatah.DuaPerTiga;
            }
            else
            {
                return Jatah.SatuPerDua;
            }
        }
        public static Jatah Jatah_SaudaraPerempuanSebapak()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.Bapak] > 0 | adakah[TipeAnggota.SaudaraLelakiSekandung] > 0)
            {
                return Jatah.M;
            }
            else if (adakah[TipeAnggota.SaudaraPerempuanSekandung] > 0 & (adakah[TipeAnggota.AnakPerempuan] > 0 | adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0) & !(adakah[TipeAnggota.SaudaraLelakiSekandung] > 0) & !(adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.Bapak] > 0))
            {
                return Jatah.M;
            }
            else if ((adakah[TipeAnggota.SaudaraPerempuanSekandung] > 1 & !(adakah[TipeAnggota.SaudaraLelakiSebapak] > 0)))
            {
                return Jatah.M;
            }
            else if (adakah[TipeAnggota.SaudaraLelakiSebapak] > 0)
            {
                return Jatah.AB;
            }
            else if (adakah[TipeAnggota.AnakPerempuan] > 0 | adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0 & !(adakah[TipeAnggota.SaudaraPerempuanSekandung] > 0))
            {
                return Jatah.AM;
            }
            else if (adakah[TipeAnggota.SaudaraPerempuanSebapak] > 1)
            {
                return Jatah.DuaPerTiga;
            }
            else if (adakah[TipeAnggota.SaudaraPerempuanSekandung] > 0)
            {
                return Jatah.SatuPerEnam;
            }
            else
            {
                return Jatah.SatuPerDua;
            }
        }
        public static Jatah Jatah_SaudaraLelakiSebapak()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.Kakek] > 0 | adakah[TipeAnggota.Bapak] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.SaudaraLelakiSekandung] > 0)
            {
                return Jatah.M;
            }
            else
            {
                return Jatah.A;
            }
        }
        public static Jatah Jatah_SaudaraLelakiSekandung()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.Kakek] > 0 | adakah[TipeAnggota.Bapak] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0)
            {
                return Jatah.M;
            }
            else
            {
                return Jatah.A;
            }
        }
        public static Jatah Jatah_AnakLelakiSaudaraLelakiSekandung()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.Kakek] > 0 | adakah[TipeAnggota.Bapak] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.SaudaraLelakiSebapak] > 0)
            {
                return Jatah.M;
            }
            else
            {
                return Jatah.A;
            }
        }
        public static Jatah Jatah_AnakLelakiSaudaraLelakiSebapak()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.Kakek] > 0 | adakah[TipeAnggota.Bapak] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0)
            {
                return Jatah.M;
            }
            else
            {
                return Jatah.A;
            }
        }
        public static Jatah Jatah_PamanBapakSekandung()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.Kakek] > 0 | adakah[TipeAnggota.Bapak] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.AnakLelakiSaudaraLelakiSebapak] > 0)
            {
                return Jatah.M;
            }
            else
            {
                return Jatah.A;
            }
        }
        public static Jatah Jatah_PamanBapakSebapak()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.Kakek] > 0 | adakah[TipeAnggota.Bapak] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.AnakLelakiSaudaraLelakiSebapak] > 0 | adakah[TipeAnggota.PamanBapakSekandung] > 0)
            {
                return Jatah.M;
            }
            else
            {
                return Jatah.A;
            }
        }
        public static Jatah Jatah_AnakLelakiPamanBapakSebapak()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.Kakek] > 0 | adakah[TipeAnggota.Bapak] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.AnakLelakiSaudaraLelakiSebapak] > 0 | adakah[TipeAnggota.PamanBapakSekandung] > 0 | adakah[TipeAnggota.PamanBapakSebapak] > 0 | adakah[TipeAnggota.AnakLelakiPamanBapakSekandung] > 0)
            {
                return Jatah.M;
            }
            else
            {
                return Jatah.A;
            }
        }
        public static Jatah Jatah_AnakLelakiPamanBapakSekandung()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.Kakek] > 0 | adakah[TipeAnggota.Bapak] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.AnakLelakiSaudaraLelakiSebapak] > 0 | adakah[TipeAnggota.PamanBapakSekandung] > 0 | adakah[TipeAnggota.PamanBapakSebapak] > 0)
            {
                return Jatah.M;
            }
            else
            {
                return Jatah.A;
            }
        }
        public static Jatah Jatah_SaudaraSeibu()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.Bapak] > 0 | adakah[TipeAnggota.Kakek] > 0 | adakah[TipeAnggota.AnakPerempuan] > 0 | adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0)
            {
                return Jatah.M;
            }
            else if (adakah[TipeAnggota.SaudaraSeibu] > 1)
            {
                return Jatah.SatuPerTiga;
            }
            else
            {
                return Jatah.SatuPerEnam;
            }
        }
        public static Jatah Jatah_Wala()
        {
            if (adakah[TipeAnggota.AnakLelaki] > 0 | adakah[TipeAnggota.Kakek] > 0 | adakah[TipeAnggota.Bapak] > 0 | adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0 | adakah[TipeAnggota.AnakLelakiSaudaraLelakiSebapak] > 0 | adakah[TipeAnggota.PamanBapakSekandung] > 0 | adakah[TipeAnggota.PamanBapakSebapak] > 0 | adakah[TipeAnggota.AnakLelakiPamanBapakSekandung] > 0 | adakah[TipeAnggota.AnakLelakiPamanBapakSebapak] > 0)
            {
                return Jatah.M;
            }
            else
            {
                return Jatah.A;
            }
        }


        // -------------------------
        public static bool VerifikasiAnggota(TipeAnggota kandidat)
        {
            LoadAdakah();
            if ((kandidat == TipeAnggota.Bapak & adakah[TipeAnggota.Bapak] > 0))
            {

                MessageBox.Show("Gak mungkin, kawan,,!!!", "Mustahil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if ((kandidat == TipeAnggota.Suami & adakah[TipeAnggota.Istri] > 0))
            {
                MessageBox.Show("terus siapa yang meniggal..???", "Mustahil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if ((kandidat == TipeAnggota.Istri & adakah[TipeAnggota.Suami] > 0))
            {
                MessageBox.Show("terus siapa yang meniggal..???", "Mustahil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if ((kandidat == TipeAnggota.Ibu & adakah[TipeAnggota.Ibu] > 0))
            {
                MessageBox.Show("cukup satu ibu kandung di Dunia ini,,,", "melanggar hukum alam", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if ((kandidat == TipeAnggota.Suami & adakah[TipeAnggota.Suami] > 0))
            {
                MessageBox.Show("Seorang istri tidak boleh memiliki 2 suami", "Melanggar syari'at", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if ((kandidat == TipeAnggota.Istri & adakah[TipeAnggota.Istri] > 3))
            {
                MessageBox.Show("4 istri cukup.. !!!, Gak boleh serakah kawan!", "Poligami", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if ((kandidat == TipeAnggota.Kakek & adakah[TipeAnggota.Kakek] > 0))
            {
                MessageBox.Show("Hanya kakek Shohih yang dapat bagian..!! ", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if ((kandidat == TipeAnggota.Nenek & adakah[TipeAnggota.Nenek] > 1))
            {
                MessageBox.Show("Hanya Nenek Shohihah yang dapat bagian..!! ", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }


    }
}
