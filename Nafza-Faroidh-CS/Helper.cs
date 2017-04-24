
public partial class Helper
{
    public static void TentukanJatah()
    {
        //mnjalankan perinyah : sub
        foreach (UnitAnggota u in anggotas)
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
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0) {
			return Jatah.SatuPerEnam;
		} else if (Adakah[TipeAnggota.AnakPerempuan] > 0 | Adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0) {
			return Jatah.ADanSeperenam;
		} else {
			return Jatah.A;
		}
	}

	public static Jatah Jatah_Ibu()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.AnakPerempuan] > 0 | Adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0 | Adakah[TipeAnggota.SaudaraLelakiSebapak] > 1 | Adakah[TipeAnggota.SaudaraLelakiSekandung] > 1 | Adakah[TipeAnggota.SaudaraPerempuanSebapak] > 1 | Adakah[TipeAnggota.SaudaraPerempuanSekandung] > 1 | Adakah[TipeAnggota.SaudaraSeibu] > 1) {
			return Jatah.SatuPerEnam;
		} else {
			return Jatah.SatuPerTiga;
		}
	}
	public static Jatah Jatah_kakek()
	{
		if (Adakah[TipeAnggota.Bapak] > 0) {
			return Jatah.M;
		} else if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0) {
			return Jatah.SatuPerEnam;
		} else if (Adakah[TipeAnggota.AnakPerempuan] > 0 | Adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0) {
			return Jatah.ADanSeperenam;
		} else {
			return Jatah.A;
		}
	}
	public static Jatah Jatah_Nenek()
	{
		if (Adakah[TipeAnggota.Ibu] > 0) {
			return Jatah.M;
		} else {
			return Jatah.SatuPerEnam;
		}
	}
	public static Jatah Jatah_AnakLelaki()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0) {
			return Jatah.A;
		} else {
			return Jatah.A;
		}
	}
	public static Jatah Jatah_AnakPerempuan()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0) {
			return Jatah.AB;
		} else if (Adakah[TipeAnggota.AnakPerempuan] > 1) {
			return Jatah.DuaPerTiga;
		} else {
			return Jatah.SatuPerDua;
		}
	}
	public static Jatah Jatah_CucuLelakiAnakLelaki()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0) {
			return Jatah.M;
		} else {
			return Jatah.A;
		}
	}
	public static Jatah Jatah_CucuPerempuanAnakLelaki()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | (Adakah[TipeAnggota.AnakPerempuan] > 1 & !(Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0))) {
			return Jatah.M;
		} else if (Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0) {
			return Jatah.AB;
		} else if (Adakah[TipeAnggota.AnakPerempuan] > 0) {
			return Jatah.SatuPerEnam;
		} else if (Adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 1) {
			return Jatah.DuaPerTiga;
		} else {
			return Jatah.SatuPerDua;
		}
	}
	public static Jatah Jatah_Suami()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.AnakPerempuan] > 0 | Adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0) {
			return Jatah.SatuPerEmpat;
		} else {
			return Jatah.SatuPerDua;
		}
	}

	public static Jatah Jatah_Istri()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.AnakPerempuan] > 0 | Adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0) {
			return Jatah.SatuPerDelapan;
		} else {
			return Jatah.SatuPerEmpat;
		}
	}
	public static Jatah Jatah_SaudaraPerempuanSekandung()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.Bapak] > 0) {
			return Jatah.M;
		} else if (Adakah[TipeAnggota.SaudaraLelakiSekandung] > 0) {
			return Jatah.AB;
		} else if (Adakah[TipeAnggota.AnakPerempuan] > 0 | Adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0) {
			return Jatah.AM;
		} else if (Adakah[TipeAnggota.SaudaraPerempuanSekandung] > 1) {
			return Jatah.DuaPerTiga;
		} else {
			return Jatah.SatuPerDua;
		}
	}
	public static Jatah Jatah_SaudaraPerempuanSebapak()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.Bapak] > 0 | Adakah[TipeAnggota.SaudaraLelakiSekandung] > 0) {
			return Jatah.M;
		} else if (Adakah[TipeAnggota.SaudaraPerempuanSekandung] > 0 & (Adakah[TipeAnggota.AnakPerempuan] > 0 | Adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0) & !(Adakah[TipeAnggota.SaudaraLelakiSekandung] > 0) & !(Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.Bapak] > 0)) {
			return Jatah.M;
		} else if ((Adakah[TipeAnggota.SaudaraPerempuanSekandung] > 1 & !(Adakah[TipeAnggota.SaudaraLelakiSebapak] > 0))) {
			return Jatah.M;
		} else if (Adakah[TipeAnggota.SaudaraLelakiSebapak] > 0) {
			return Jatah.AB;
		} else if (Adakah[TipeAnggota.AnakPerempuan] > 0 | Adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0 & !(Adakah[TipeAnggota.SaudaraPerempuanSekandung] > 0)) {
			return Jatah.AM;
		} else if (Adakah[TipeAnggota.SaudaraPerempuanSebapak] > 1) {
			return Jatah.DuaPerTiga;
		} else if (Adakah[TipeAnggota.SaudaraPerempuanSekandung] > 0) {
			return Jatah.SatuPerEnam;
		} else {
			return Jatah.SatuPerDua;
		}
	}
	public static Jatah Jatah_SaudaraLelakiSebapak()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.Kakek] > 0 | Adakah[TipeAnggota.Bapak] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.SaudaraLelakiSekandung] > 0) {
			return Jatah.M;
		} else {
			return Jatah.A;
		}
	}
	public static Jatah Jatah_SaudaraLelakiSekandung()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.Kakek] > 0 | Adakah[TipeAnggota.Bapak] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0) {
			return Jatah.M;
		} else {
			return Jatah.A;
		}
	}
	public static Jatah Jatah_AnakLelakiSaudaraLelakiSekandung()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.Kakek] > 0 | Adakah[TipeAnggota.Bapak] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.SaudaraLelakiSebapak] > 0) {
			return Jatah.M;
		} else {
			return Jatah.A;
		}
	}
	public static Jatah Jatah_AnakLelakiSaudaraLelakiSebapak()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.Kakek] > 0 | Adakah[TipeAnggota.Bapak] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | Adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0) {
			return Jatah.M;
		} else {
			return Jatah.A;
		}
	}
	public static Jatah Jatah_PamanBapakSekandung()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.Kakek] > 0 | Adakah[TipeAnggota.Bapak] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | Adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.AnakLelakiSaudaraLelakiSebapak] > 0) {
			return Jatah.M;
		} else {
			return Jatah.A;
		}
	}
	public static Jatah Jatah_PamanBapakSebapak()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.Kakek] > 0 | Adakah[TipeAnggota.Bapak] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | Adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.AnakLelakiSaudaraLelakiSebapak] > 0 | Adakah[TipeAnggota.PamanBapakSekandung] > 0) {
			return Jatah.M;
		} else {
			return Jatah.A;
		}
	}
	public static Jatah Jatah_AnakLelakiPamanBapakSebapak()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.Kakek] > 0 | Adakah[TipeAnggota.Bapak] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | Adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.AnakLelakiSaudaraLelakiSebapak] > 0 | Adakah[TipeAnggota.PamanBapakSekandung] > 0 | Adakah[TipeAnggota.PamanBapakSebapak] > 0 | Adakah[TipeAnggota.AnakLelakiPamanBapakSekandung] > 0) {
			return Jatah.M;
		} else {
			return Jatah.A;
		}
	}
	public static Jatah Jatah_AnakLelakiPamanBapakSekandung()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.Kakek] > 0 | Adakah[TipeAnggota.Bapak] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | Adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.AnakLelakiSaudaraLelakiSebapak] > 0 | Adakah[TipeAnggota.PamanBapakSekandung] > 0 | Adakah[TipeAnggota.PamanBapakSebapak] > 0) {
			return Jatah.M;
		} else {
			return Jatah.A;
		}
	}
	public static Jatah Jatah_SaudaraSeibu()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.Bapak] > 0 | Adakah[TipeAnggota.Kakek] > 0 | Adakah[TipeAnggota.AnakPerempuan] > 0 | Adakah[TipeAnggota.CucuPerempuanAnakLelaki] > 0) {
			return Jatah.M;
		} else if (Adakah[TipeAnggota.SaudaraSeibu] > 1) {
			return Jatah.SatuPerTiga;
		} else {
			return Jatah.SatuPerEnam;
		}
	}
	public static Jatah Jatah_Wala()
	{
		if (Adakah[TipeAnggota.AnakLelaki] > 0 | Adakah[TipeAnggota.Kakek] > 0 | Adakah[TipeAnggota.Bapak] > 0 | Adakah[TipeAnggota.CucuLelakiAnakLelaki] > 0 | Adakah[TipeAnggota.SaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.SaudaraLelakiSebapak] > 0 | Adakah[TipeAnggota.AnakLelakiSaudaraLelakiSekandung] > 0 | Adakah[TipeAnggota.AnakLelakiSaudaraLelakiSebapak] > 0 | Adakah[TipeAnggota.PamanBapakSekandung] > 0 | Adakah[TipeAnggota.PamanBapakSebapak] > 0 | Adakah[TipeAnggota.AnakLelakiPamanBapakSekandung] > 0 | Adakah[TipeAnggota.AnakLelakiPamanBapakSebapak] > 0) {
			return Jatah.M;
		} else {
			return Jatah.A;
		}
	}
}

public class UnitAnggota
{
	public string nama;
	public TipeAnggota tipe;
	public Jatah hasil_jatah;
	public double hasil_waris;
}

public sealed class Jatah : RichEnum<int, Jatah>
{
    public static readonly Jatah SatuPerDua = new Jatah(0);
	public static readonly Jatah SatuPerEmpat = new Jatah(1);
	public static readonly Jatah DuaPerTiga = new Jatah(2);
	public static readonly Jatah SatuPerDelapan = new Jatah(3);
	public static readonly Jatah SatuPerEnam = new Jatah(4);
	public static readonly Jatah SatuPerTiga = new Jatah(5);
	public static readonly Jatah ADanSeperenam = new Jatah(6);
	public static readonly Jatah AB = new Jatah(7);
	public static readonly Jatah AM = new Jatah(8);
	public static readonly Jatah A = new Jatah(9);
	public static readonly Jatah M = new Jatah(10);

    private Jatah(int value) : base (value) { }
    public static implicit operator Jatah(int value) { return Convert(value); }
}

public sealed class TipeAnggota : RichEnum<int, TipeAnggota>
{
    public static readonly TipeAnggota Bapak = new TipeAnggota(0);
	public static readonly TipeAnggota Ibu = new TipeAnggota(1);
	public static readonly TipeAnggota Kakek = new TipeAnggota(2);
	public static readonly TipeAnggota Nenek = new TipeAnggota(3);
	public static readonly TipeAnggota AnakLelaki = new TipeAnggota(4);
	public static readonly TipeAnggota AnakPerempuan = new TipeAnggota(5);
	public static readonly TipeAnggota CucuLelakiAnakLelaki = new TipeAnggota(6);
	public static readonly TipeAnggota CucuPerempuanAnakLelaki = new TipeAnggota(7);
	public static readonly TipeAnggota Suami = new TipeAnggota(8);
	public static readonly TipeAnggota Istri = new TipeAnggota(9);
	public static readonly TipeAnggota SaudaraLelakiSekandung = new TipeAnggota(10);
	public static readonly TipeAnggota SaudaraPerempuanSekandung = new TipeAnggota(11);
	public static readonly TipeAnggota SaudaraLelakiSebapak = new TipeAnggota(12);
	public static readonly TipeAnggota SaudaraPerempuanSebapak = new TipeAnggota(13);
	public static readonly TipeAnggota AnakLelakiSaudaraLelakiSekandung = new TipeAnggota(14);
	public static readonly TipeAnggota AnakLelakiSaudaraLelakiSebapak = new TipeAnggota(15);
	public static readonly TipeAnggota PamanBapakSekandung = new TipeAnggota(16);
	public static readonly TipeAnggota PamanBapakSebapak = new TipeAnggota(17);
	public static readonly TipeAnggota AnakLelakiPamanBapakSekandung = new TipeAnggota(18);
	public static readonly TipeAnggota AnakLelakiPamanBapakSebapak = new TipeAnggota(19);
	public static readonly TipeAnggota SaudaraSeibu = new TipeAnggota(20);
	public static readonly TipeAnggota Wala = new TipeAnggota(21);
    
    private TipeAnggota(int value) : base (value) { }
    public static implicit operator TipeAnggota(int value) { return Convert(value); }
}

public enum ModelPenghitungan
{
	Normal = 0,
	Aul = 1,
	Radd = 2
}
