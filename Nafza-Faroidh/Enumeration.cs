using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafza_Faroidh
{
    /// <summary>
    /// Data setiap anggota waris
    /// </summary>
    public class Anggota
    {
        /// <summary> Nama anggota </summary>
        public string nama;
        /// <summary> Rincian anggota </summary>
        public TipeAnggota tipe;
        /// <summary> Hasil tipe jatah (kategori) </summary>
        public Jatah hasil_jatah;
        /// <summary> Hasil waris jatah (rupiah) </summary>
        public double hasil_waris;
    }

    public enum Jatah
    {
        SatuPerDua = 0,
        SatuPerEmpat = 1,
        DuaPerTiga = 2,
        SatuPerDelapan = 3,
        SatuPerEnam = 4,
        SatuPerTiga = 5,
        ADanSeperenam = 6,
        AB = 7,
        AM = 8,
        A = 9,
        M = 10
    }

    public enum TipeAnggota
    {
        Bapak = 0,
        Ibu = 1,
        Kakek = 2,
        Nenek = 3,
        AnakLelaki = 4,
        AnakPerempuan = 5,
        CucuLelakiAnakLelaki = 6,
        CucuPerempuanAnakLelaki = 7,
        Suami = 8,
        Istri = 9,
        SaudaraLelakiSekandung = 10,
        SaudaraPerempuanSekandung = 11,
        SaudaraLelakiSebapak = 12,
        SaudaraPerempuanSebapak = 13,
        AnakLelakiSaudaraLelakiSekandung = 14,
        AnakLelakiSaudaraLelakiSebapak = 15,
        PamanBapakSekandung = 16,
        PamanBapakSebapak = 17,
        AnakLelakiPamanBapakSekandung = 18,
        AnakLelakiPamanBapakSebapak = 19,
        SaudaraSeibu = 20,
        Wala = 21
    }

    public static class Util
    {
        public static Dictionary<Jatah, string> Jatah2String = new Dictionary<Jatah, string>
        {
            { Jatah.SatuPerDua, "1/2" },
            { Jatah.SatuPerEmpat, "1/4" },
            { Jatah.DuaPerTiga, "2/3" },
            { Jatah.SatuPerDelapan, "1/8" },
            { Jatah.SatuPerEnam, "1/6" },
            { Jatah.SatuPerTiga, "1/3" },
            { Jatah.M, "Mahjub" },
            { Jatah.AB, "Ashobah Bil Ghoir" },
            { Jatah.AM, "Ashobah Ma'al Ghoir" },
            { Jatah.A, "Ashobah" },
            { Jatah.ADanSeperenam, "1/6 + Ashobah" },
        };

        public static Dictionary<TipeAnggota, string> Anggota2String = new Dictionary<TipeAnggota, string>
        {
            { TipeAnggota.AnakLelaki, "Anak Lelaki" },
            { TipeAnggota.AnakLelakiPamanBapakSebapak, "Anak Lelaki Paman Seayah" },
            { TipeAnggota.AnakLelakiPamanBapakSekandung,  "Anak Lelaki Paman Sekandung" },
            { TipeAnggota.AnakLelakiSaudaraLelakiSebapak, "Anak Lelaki Sdr Lelaki Seayah" },
            { TipeAnggota.AnakLelakiSaudaraLelakiSekandung, "Anak Lelaki Sdr Lelaki Sekandung" },
            { TipeAnggota.CucuLelakiAnakLelaki,  "Cucu Lelaki dr Anak Lelaki" },
            { TipeAnggota.AnakPerempuan, "Anak Perempuan" },
            { TipeAnggota.CucuPerempuanAnakLelaki, "Cucu Perempuan dr Anak Lelaki" },
            { TipeAnggota.PamanBapakSebapak,  "Paman Bapak Seayah" },
            { TipeAnggota.PamanBapakSekandung, "Paman Bapak Sekandung" },
            { TipeAnggota.SaudaraLelakiSebapak, "Sdr Lelaki Seayah" },
            { TipeAnggota.SaudaraLelakiSekandung, "Sdr Lelaki Sekandung" },
            { TipeAnggota.SaudaraPerempuanSebapak, "Sdr Perempuan Seayah" },
            { TipeAnggota.SaudaraPerempuanSekandung, "Sdr Perempuan Sekandung" },
            { TipeAnggota.SaudaraSeibu , "Saudara Seibu" },
            { TipeAnggota.Bapak, "Bapak" },
            { TipeAnggota.Ibu, "Ibu" },
            { TipeAnggota.Istri, "Istri" },
            { TipeAnggota.Kakek, "Kakek" },
            { TipeAnggota.Nenek, "Nenek" },
            { TipeAnggota.Suami, "Suami" },
            { TipeAnggota.Wala, "Wala'" }
        };

        public static V GetValue<K, V>(this Dictionary<K, V> dict, K key, V val)
        {
            if (!dict.TryGetValue(key, out V v)) v = val;
            return v;
        }
    }

    public class Dict<K, V> : Dictionary<K, V>
    {
        public new V this[K key]
        {
            get
            {
                if (!TryGetValue(key, out V v)) v = default(V);
                return v;
            }
            set
            {
                base[key] = value;
            }
        }

        public V this[K key, V defaultValue]
        {
            get
            {
                if (!TryGetValue(key, out V v)) v = defaultValue;
                return v;
            }
            set
            {
                base[key] = value;
            }
        }
    }

}
