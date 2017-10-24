using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafza_Faroidh
{
    public partial class Helper
    {
        /// <summary> Daftar anggota waris </summary>
        public static List<Anggota> anggotas = new List<Anggota>();

        public static Dict<TipeAnggota, int> adakah = new Dict<TipeAnggota, int>();

        public static Dict<Jatah, int> sumJatah = new Dict<Jatah, int>();

        public static Dict<Jatah, double> unitHasil = new Dict<Jatah, double>();
        
        public static double TotalWaris;

        public static bool ModelAulRodd;

        public static double Hasil_Total;

        public static double Hasil_Sisa;

        /// <summary>
        /// 0 = cukup, 1 = lebih, 2 = kurang dari persediaan waris
        /// </summary>
        public static int Hasil_Cukup;

        /// <summary>
        /// Rekalikuasi: proses lengkap dari penentuan setiap anggota hasil
        /// </summary>
        public static void Rekalkulasi()
        {
            // "proses penghitungan dimulai dari sini!!!"
            LoadAdakah();
            TentukanJatah();
            LoadMasuk();
            HitungUnitJatah();
            OutputWaris();
        }
        
        public static void LoadAdakah()
        {
            adakah.Clear();
            foreach (Anggota u in anggotas)
                adakah[u.tipe]++;
        }

        public static void LoadMasuk()
        {
            sumJatah.Clear();
            foreach (Anggota u in anggotas)
            {
                sumJatah[u.hasil_jatah] += 1;
            }
        }


        public static void HitungUnitJatah()
        {
            double sisa = 1;
            unitHasil.Clear();
            // Hitung untuk bagian asli (pecahan)
            for (int i = 0; i <= 6; i++)
            {
                var jatah = (Jatah)i;
                if (sumJatah[jatah] > 0)
                {
                    if ((jatah == Jatah.SatuPerDua))
                        unitHasil[jatah] = 1.0 / 2.0;
                    if ((jatah == Jatah.SatuPerTiga))
                        unitHasil[jatah] = 1.0 / 3.0;
                    if ((jatah == Jatah.SatuPerEmpat))
                        unitHasil[jatah] = 1.0 / 4.0;
                    if ((jatah == Jatah.SatuPerEnam))
                        unitHasil[jatah] = 1.0 / 6.0;
                    if ((jatah == Jatah.SatuPerDelapan))
                        unitHasil[jatah] = 1.0 / 8.0;
                    if ((jatah == Jatah.DuaPerTiga))
                        unitHasil[jatah] = 2.0 / 3.0;
                    if ((jatah == Jatah.ADanSeperenam))
                        unitHasil[jatah] = 1.0 / 6.0;


                    sisa -= unitHasil[jatah] * sumJatah[jatah];

                }
            }
            //Hitung untuk mencegah anggota yang >1... kehitung >1
            for (int i = 0; i < 22; i++)
            {
                var tipe = (TipeAnggota)i;
                if ((adakah[tipe] > 1 & Macro_TermasukDaftarDouble(tipe)))
                {
                    var iT = (TipeAnggota)i;
                    var tipeJatah = anggotas.First(x => x.tipe == iT).hasil_jatah;
                    sisa += unitHasil[tipeJatah] * (sumJatah[tipeJatah] - 1);
                    // Gak pate' yakin?
                    unitHasil[tipeJatah] /= sumJatah[tipeJatah];
                }
            }
            //Hitung untuk bagian ashobah
            var sisaReal = Math.Max(0, sisa);
            for (int i = 6; i <= 9; i++)
            {
                var P = Macro_JumlahFuruPerempuan();
                var L = Macro_JumlahFuruLakiLaki();
                var S = Macro_JumlahAshobah();
                if (S == 0)
                    return;
                if (P > 0 | L > 0)
                {
                    S += sumJatah[Jatah.A];
                    var jatah = (Jatah)i;
                    // wadon mesti AB
                    if (jatah == Jatah.AB)
                    {
                        unitHasil[jatah] += sisaReal / S;
                        // iki wadon
                    }
                    else if (jatah == Jatah.A)
                    {
                        unitHasil[jatah] += sisaReal / S * (2.0);
                        // iki lanang
                    }
                    else
                    {
                        unitHasil[jatah] += sisaReal / S;
                    }
                }
                else
                {
                    unitHasil[(Jatah)i] += sisaReal / S;
                }
            }

        }
        public static int Macro_JumlahFuruPerempuan()
        {
            return adakah[TipeAnggota.AnakPerempuan] + adakah[TipeAnggota.CucuPerempuanAnakLelaki];
        }
        public static bool Macro_TermasukDaftarDouble(TipeAnggota tipenya)
        {
            return tipenya == (TipeAnggota.AnakPerempuan) | tipenya == (TipeAnggota.CucuPerempuanAnakLelaki) | tipenya == (TipeAnggota.SaudaraSeibu) | tipenya == (TipeAnggota.SaudaraPerempuanSebapak) | tipenya == (TipeAnggota.SaudaraPerempuanSekandung);
        }
        public static int Macro_JumlahFuruLakiLaki()
        {
            return adakah[TipeAnggota.AnakLelaki];
        }
        public static int Macro_JumlahAshobah()
        {
            return sumJatah[Jatah.AM] + sumJatah[Jatah.AB] + sumJatah[Jatah.A] + sumJatah[Jatah.ADanSeperenam];
        }
        public static int Macro_JumlahNonAshobah()
        {
            return sumJatah[Jatah.AM] + sumJatah[Jatah.AB] + sumJatah[Jatah.A];
        }
        public static bool HitungPrioritasZaujah(double jumlah)
        {
            // Cek jika Rodd ada dan memang ada Suami/Istri
            var suamiIstri = adakah[TipeAnggota.Suami] + adakah[TipeAnggota.Istri];
            if (!((suamiIstri > 0) & ModelAulRodd))
                return false;

            // Atur kalkulasi sendiri 
            if ((suamiIstri == anggotas.Count))
            {
                // Cuma ada suami/istri doang
                var rasio = jumlah / suamiIstri;
                foreach (Anggota u in anggotas)
                {
                    u.hasil_waris = rasio;
                }
            }
            else
            {
                var jatahZauj = anggotas.Where((a) => (a.tipe == TipeAnggota.Suami | a.tipe == TipeAnggota.Istri)).First().hasil_waris;

                var rasio = (TotalWaris - jatahZauj) / (jumlah - jatahZauj);
                foreach (Anggota u in anggotas)
                {
                    if ((u.tipe == TipeAnggota.Suami | u.tipe == TipeAnggota.Istri))
                    {
                        u.hasil_waris = jatahZauj;
                    }
                    else
                    {
                        u.hasil_waris *= rasio;
                    }
                }
            }
            return true;
        }
        public static void OutputWaris()
        {
            // Memori total dari jumlah waris dari tiap anggota
            var jumlah = 0.0;
            // Di setiap anggotas ..
            foreach (Anggota u in anggotas)
            {
                u.hasil_waris = TotalWaris * unitHasil[u.hasil_jatah];
                if (Math.Abs(u.hasil_waris) < 0.01)
                    u.hasil_waris = 0;
                jumlah += Math.Max(u.hasil_waris, 0);
            }
            var rasio = 1.0;

            if (jumlah == TotalWaris)
            {
                Hasil_Cukup = 0;
            }
            else if (jumlah > TotalWaris)
            {
                // Aul
                Hasil_Cukup = 1;
            }
            else
            {
                // Rodd
                Hasil_Cukup = 2;
            }

            //'If (Hasil_Cukup = 2) Then 

            if ((!(jumlah == TotalWaris) & ModelAulRodd))
            {
                rasio = TotalWaris / jumlah;
                Hasil_Total = TotalWaris;
                Hasil_Sisa = 0;
                if ((Hasil_Cukup == 2 && HitungPrioritasZaujah(jumlah)))
                {
                    return;
                }
            }
            else
            {
                Hasil_Total = jumlah;
                Hasil_Sisa = TotalWaris - jumlah;
            }
            if (Math.Abs(Hasil_Sisa) < 0.01)
                Hasil_Sisa = 0;
            if (Math.Abs(Hasil_Total) < 0.01)
                Hasil_Total = 0;

            if (!(rasio == 1))
            {
                foreach (Anggota u in anggotas)
                {
                    if (u.hasil_waris < 0)
                    {
                        u.hasil_waris = 0;
                    }
                    else
                    {
                        u.hasil_waris *= rasio;
                    }
                }
            }
        }

    }
}
