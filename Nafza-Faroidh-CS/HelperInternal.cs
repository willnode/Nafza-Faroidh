using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

public partial class Helper
{
    //clas : WADAH U/ FUNGSI2 N VARIABLE
    //Public : clas (helper bsa d akses oleh kelas lainya
    //Partial : karena ada 2 helper yg sama ( helper ini aslinya bagian dari helper yg lain

    // tmpat daftar anggota 
    public static List<UnitAnggota> anggotas = new List<UnitAnggota>();
    //list : variable majemuk yg fleksible 
    //shared : variable global : bsa di akses tanpa membuat variable baru 
    //..................................................."apakah anggota tipe sekian hadir???"
    public static int[] Adakah;
    //boolean : true or false
    //adakah: di bagi brdasarkan jatah
    //..................................................."Berapakah banya anggota???"
    public static int[] SumJatah;
    //integer : angka bulat
    // sumjatah: berapa kah jumlah anggota dari bagian jatah
    //...................................................."setiap tipe jatah berapakah rasio warisnya???"
    public static double[] UnitHasil;
    //unit hasil : rasio waris yg didapat setia jatah 
    // double :angka real 
    //...................................................."berapakah total warisnya???" 

    public static double TotalWaris;

    public static double Hasil_Total;

    public static double Hasil_Sisa;
    /// <summary>
    /// 0 = cukup, 1 = lebih, 2 = kurang dari persediaan waris
    /// </summary>
    public static int Hasil_Cukup;

    public static bool ModelAulRodd;

    // Rekalikuasi: proses lengkap dari penentuan setiap anggota hasil
    //...................................................."proses penghitungan dimulai dari sini!!!"
    public static void Rekalkulasi()
    {
        LoadAdakah();
        TentukanJatah();
        LoadMasuk();
        HitungUnitJatah();
        OutputWaris();
    }

    public static UnitAnggota TambahAnggota(string nama, TipeAnggota tipe)
    {
        UnitAnggota u = new UnitAnggota();
        u.nama = nama;
        u.tipe = tipe;
        anggotas.Add(u);
        return u;
    }

    public static void LoadAdakah()
    {
        //fungsi true n false bagian u/ pemisalan bagian bapak mnjadi 1/2 or 1/4
        Adakah = new int[51];
        foreach (UnitAnggota u in anggotas)
        {
            //each ; setiap 
            Adakah[u.tipe] += 1;
        }
    }
    public static void LoadMasuk()
    {
        SumJatah = new int[12];
        foreach (UnitAnggota u in anggotas)
        {
            SumJatah[u.hasil_jatah] += 1;
        }
    }

    public static void HitungUnitJatah()
    {
        double sisa = 1;
        UnitHasil = new double[12];
        // Hitung untuk bagian asli (pecahan)
        for (int i = 0; i <= 6; i++)
        {
            var jatah = (Jatah)i;
            if (SumJatah[i] > 0)
            {
                if ((jatah == Jatah.SatuPerDua))
                    UnitHasil[i] = 1.0 / 2.0;
                if ((jatah == Jatah.SatuPerTiga))
                    UnitHasil[i] = 1.0 / 3.0;
                if ((jatah == Jatah.SatuPerEmpat))
                    UnitHasil[i] = 1.0 / 4.0;
                if ((jatah == Jatah.SatuPerEnam))
                    UnitHasil[i] = 1.0 / 6.0;
                if ((jatah == Jatah.SatuPerDelapan))
                    UnitHasil[i] = 1.0 / 8.0;
                if ((jatah == Jatah.DuaPerTiga))
                    UnitHasil[i] = 2.0 / 3.0;
                if ((jatah == Jatah.ADanSeperenam))
                    UnitHasil[i] = 1.0 / 6.0;


                sisa -= UnitHasil[i] * SumJatah[i];

            }
        }
        //Hitung untuk mencegah anggota yang >1... kehitung >1
        for (int i = 0; i < 22; i++)
        {
            if ((Adakah[i] > 1 & Macro_TermasukDaftarDouble(i)))
            {
                var iT = (TipeAnggota)i;
                var tipeJatah = (int)anggotas.First(x => x.tipe == iT).hasil_jatah;
                sisa += UnitHasil[tipeJatah] * (SumJatah[tipeJatah] - 1);
                // Gak pate' yakin?
                UnitHasil[tipeJatah] /= SumJatah[tipeJatah];
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
                S += SumJatah[(int)Jatah.A];
                // wadon mesti AB
                if ((Jatah)i == Jatah.AB)
                {
                    UnitHasil[i] += sisaReal / S;
                    // iki wadon
                }
                else if (i == Jatah.A)
                {
                    UnitHasil[i] += sisaReal / S * (2.0);
                    // iki lanang
                }
                else
                {
                    UnitHasil[i] += sisaReal / S;
                }
            }
            else
            {
                UnitHasil[i] += sisaReal / S;
            }
            // UnitHasil[i] /= SumJatah[i]
        }

    }
    public static int Macro_JumlahFuruPerempuan()
    {
        return Adakah[TipeAnggota.AnakPerempuan] + Adakah[TipeAnggota.CucuPerempuanAnakLelaki];
    }
    public static bool Macro_TermasukDaftarDouble(TipeAnggota tipenya)
    {
        return tipenya == (TipeAnggota.AnakPerempuan) | tipenya == (TipeAnggota.CucuPerempuanAnakLelaki) | tipenya == (TipeAnggota.SaudaraSeibu) | tipenya == (TipeAnggota.SaudaraPerempuanSebapak) | tipenya == (TipeAnggota.SaudaraPerempuanSekandung);
    }
    public static int Macro_JumlahFuruLakiLaki()
    {
        return Adakah[TipeAnggota.AnakLelaki];
    }
    public static int Macro_JumlahAshobah()
    {
        return SumJatah[Jatah.AM] + SumJatah[Jatah.AB] + SumJatah[Jatah.A] + SumJatah[Jatah.ADanSeperenam];
    }
    public static int Macro_JumlahNonAshobah()
    {
        return SumJatah[Jatah.AM] + SumJatah[Jatah.AB] + SumJatah[Jatah.A];
    }
    public static bool HitungPrioritasZaujah(double jumlah)
    {
        // Cek jika Rodd ada dan memang ada Suami/Istri
        var suamiIstri = Adakah[(int)TipeAnggota.Suami] + Adakah[(int)TipeAnggota.Istri];
        if (!((suamiIstri > 0) & ModelAulRodd))
            return false;

        // Atur kalkulasi sendiri 
        if ((suamiIstri == anggotas.Count))
        {
            // Cuma ada suami/istri doang
            var rasio = jumlah / suamiIstri;
            foreach (UnitAnggota u in anggotas)
            {
                u.hasil_waris = rasio;
            }
        }
        else
        {
            var jatahZauj = anggotas.Where((a) => (a.tipe == TipeAnggota.Suami | a.tipe == TipeAnggota.Istri)).First().hasil_waris;

            var rasio = (TotalWaris - jatahZauj) / (jumlah - jatahZauj);
            foreach (UnitAnggota u in anggotas)
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
        foreach (UnitAnggota u in anggotas)
        {
            u.hasil_waris = TotalWaris * UnitHasil[u.hasil_jatah];
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
            foreach (UnitAnggota u in anggotas)
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
    public static string Jatah2String(Jatah j)
    {
        if (j == Jatah.SatuPerDua)
        {
            return "1/2";
        }
        else if (j == Jatah.SatuPerEmpat)
        {
            return "1/4";
        }
        else if (j == Jatah.DuaPerTiga)
        {
            return "2/3";
        }
        else if (j == Jatah.SatuPerDelapan)
        {
            return "1/8";
        }
        else if (j == Jatah.SatuPerEnam)
        {
            return "1/6";
        }
        else if (j == Jatah.SatuPerTiga)
        {
            return "1/3";
        }
        else if (j == Jatah.M)
        {
            return "Mahjub";
        }
        else if (j == Jatah.AB)
        {
            return "Ashobah Bil Ghoir";
        }
        else if (j == Jatah.AM)
        {
            return "Ashobah Ma'al Ghoir";
        }
        else if (j == Jatah.A)
        {
            return "Ashobah";
        }
        else if (j == Jatah.ADanSeperenam)
        {
            return "1/6 + Ashobah";
        }
        return "";
    }

    public static string Anggota2String(TipeAnggota t)
    {
        if (t == TipeAnggota.AnakLelaki)
        {
            return "Anak Lelaki";
        }
        else if (t == TipeAnggota.AnakLelakiPamanBapakSebapak)
        {
            return "Anak Lelaki Paman Seayah";
        }
        else if (t == TipeAnggota.AnakLelakiPamanBapakSekandung)
        {
            return "Anak Lelaki Paman Sekandung";
        }
        else if (t == TipeAnggota.AnakLelakiSaudaraLelakiSebapak)
        {
            return "Anak Lelaki Sdr Lelaki Seayah";
        }
        else if (t == TipeAnggota.AnakLelakiSaudaraLelakiSekandung)
        {
            return "Anak Lelaki Sdr Lelaki Sekandung";
        }
        else if (t == TipeAnggota.CucuLelakiAnakLelaki)
        {
            return "Cucu Lelaki dr Anak Lelaki";
        }
        else if (t == TipeAnggota.AnakPerempuan)
        {
            return "Anak Perempuan";
        }
        else if (t == TipeAnggota.CucuPerempuanAnakLelaki)
        {
            return "Cucu Perempuan dr Anak Lelaki";
        }
        else if (t == TipeAnggota.PamanBapakSebapak)
        {
            return "Paman Bapak Seayah";
        }
        else if (t == TipeAnggota.PamanBapakSekandung)
        {
            return "Paman Bapak Sekandung";
        }
        else if (t == TipeAnggota.SaudaraLelakiSebapak)
        {
            return "Sdr Lelaki Seayah";
        }
        else if (t == TipeAnggota.SaudaraLelakiSekandung)
        {
            return "Sdr Lelaki Sekandung";
        }
        else if (t == TipeAnggota.SaudaraPerempuanSebapak)
        {
            return "Sdr Perempuan Seayah";
        }
        else if (t == TipeAnggota.SaudaraPerempuanSekandung)
        {
            return "Sdr Perempuan Sekandung";
        }
        else if (t == TipeAnggota.SaudaraSeibu)
        {
            return "Saudara Seibu";
        }
        else if (t == TipeAnggota.Bapak)
        {
            return "Bapak";
        }
        else if (t == TipeAnggota.Ibu)
        {
            return "Ibu";
        }
        else if (t == TipeAnggota.Istri)
        {
            return "Istri";
        }
        else if (t == TipeAnggota.Kakek)
        {
            return "Kakek";
        }
        else if (t == TipeAnggota.Nenek)
        {
            return "Nenek";
        }
        else if (t == TipeAnggota.Suami)
        {
            return "Suami";
        }
        else if (t == TipeAnggota.Wala)
        {
            return "Wala'";
        }
        return "";
    }

    public static string PickAnyNama()
    {
        var x = Math.Floor(randomer.NextDouble() * namaKarep.Length);
        return namaKarep[(int)(x)];
    }

    public static bool VerifikasiAnggota(TipeAnggota kandidat)
    {
        LoadAdakah();
        if ((kandidat == TipeAnggota.Bapak & Adakah[TipeAnggota.Bapak] > 0))
        {
            
            MessageBox.Show("Gak mungkin, kawan,,!!!", "Mustahil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        if ((kandidat == TipeAnggota.Suami & Adakah[TipeAnggota.Istri] > 0))
        {
            MessageBox.Show("terus siapa yang meniggal..???", "Mustahil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        if ((kandidat == TipeAnggota.Istri & Adakah[TipeAnggota.Suami] > 0))
        {
            MessageBox.Show("terus siapa yang meniggal..???", "Mustahil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        if ((kandidat == TipeAnggota.Ibu & Adakah[TipeAnggota.Ibu] > 0))
        {
            MessageBox.Show("cukup satu ibu kandung di Dunia ini,,,", "melanggar hukum alam", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        if ((kandidat == TipeAnggota.Suami & Adakah[TipeAnggota.Suami] > 0))
        {
            MessageBox.Show("Seorang istri tidak boleh memiliki 2 suami", "Melanggar syari'at", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        if ((kandidat == TipeAnggota.Istri & Adakah[TipeAnggota.Istri] > 3))
        {
            MessageBox.Show("4 istri cukup.. !!!, Gak boleh serakah kawan!", "Poligami", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        if ((kandidat == TipeAnggota.Kakek & Adakah[TipeAnggota.Kakek] > 0))
        {
            MessageBox.Show("Hanya kakek Shohih yang dapat bagian..!! ", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        if ((kandidat == TipeAnggota.Nenek & Adakah[TipeAnggota.Nenek] > 1))
        {
            MessageBox.Show("Hanya Nenek Shohihah yang dapat bagian..!! ", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        return true;
    }

    static Random randomer = new Random();
    static string[] namaKarep = new string[] {
        "Fulan",
        "Insan",
        "Nizam",
        "Zaki",
        "Syaiful",
        "Faiz",
        "Afif",
        "Irfan",
        "Ali",
        "Samba",
        "Rusli",
        "Rifqy",
        "Himam",
        "Obey",
        "Faza"
    };
    public class AComparer : Comparer<UnitAnggota>
    {

        public override int Compare(UnitAnggota x, UnitAnggota y)
        {
            return ((int)x.hasil_jatah).CompareTo(y.hasil_jatah);
        }
    }
}
