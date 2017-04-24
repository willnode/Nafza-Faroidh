
using System;
using System.Windows.Forms;

public partial class Form1
{

	UserControl PilihanSaiki;

	public void TambahKeDaftar(string nama, TipeAnggota tipe)
	{
		if ((!Helper.VerifikasiAnggota(tipe)))
			return;
		if ((string.IsNullOrWhiteSpace(nama)))
			nama = Helper.PickAnyNama();
		dynamic u = Helper.TambahAnggota(nama, tipe);
		dynamic l = _Tabel.Items.Add(new ListViewItem());
		l.Tag = u;
		l.SubItems.AddRange(new string[] {
			"",
			"",
			""
		});
		RefreshAnggota();
	}

	public TipeAnggota TranslateTipe(int index)
	{
		if ((index > 23))
			return index - 3;
		if ((index > 11))
			return index - 2;
		if ((index > 0))
			return index - 1;
		return index;
	}
	public void RefreshAnggota()
	{
		Helper.Rekalkulasi();
		_Tabel.BeginUpdate();
		foreach (ListViewItem x in _Tabel.Items) {
			UnitAnggota u = (UnitAnggota)x.Tag;
			x.Text = u.nama;
			x.SubItems[1].Text = Helper.Anggota2String(u.tipe);
			x.SubItems[2].Text = Helper.Jatah2String(u.hasil_jatah);
			x.SubItems[3].Text = "Rp. " + u.hasil_waris.ToString("##,#0");
		}
		if ((_Tabel.SelectedItems.Count == 0)) {
			Button1.Text = "Reset";
		} else {
			Button1.Text = "Hapus";
		}

		RefreshStatusMode();
		_Tabel.EndUpdate();
	}

	public void RefreshStatusMode()
	{
		if ((Helper.Hasil_Cukup == 0)) {
			_ModeAulRodd.Text = "Tidak ada Sisa";
			_ModeAulRodd.Enabled = false;
			_ModeAulRodd.Checked = false;
		} else if (Helper.Hasil_Cukup == 2) {
			_ModeAulRodd.Text = "Ar Rodd";
			_ModeAulRodd.Enabled = true;
		} else {
			_ModeAulRodd.Text = "Al 'Aul";
			_ModeAulRodd.Enabled = true;
		}
		if (!_ModeAulRodd.Checked & !(Helper.Hasil_Cukup == 0)) {
			_Total.Text = "Total: " + Math.Round(Helper.Hasil_Total).ToString("#,##0.##");
			_Sisa.Text = "Sisa: " + Math.Round(Helper.Hasil_Sisa).ToString("#,##0.##");

		} else {
			_Total.Text = "";
			_Sisa.Text = "";


		}
	}

	public void KirimKePrinter()
	{
		if ((PrintDiag.ShowDialog() == DialogResult.OK))
			PrintDoc.Print();
	}

	private void _Modal_TextChanged(object sender, EventArgs e)
	{
        Helper.TotalWaris = (double)_Modal.Value;
	    RefreshAnggota();
	}

	private void _ModeAulRodd_CheckedChanged(object sender, EventArgs e)
	{
		Helper.ModelAulRodd = _ModeAulRodd.Checked;
		RefreshAnggota();

	}

	private void _Submit_Click_1(object sender, EventArgs e)
	{
		TambahKeDaftar(_Nama.Text, TranslateTipe(_Tingkat.SelectedIndex));
		_Nama.Text = string.Empty;
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		if (_Tabel.SelectedItems.Count == 0) {
			if ((MessageBox.Show("Yakin ingin menghapus semua anggota?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.No))
				return;
			_Tabel.Items.Clear();
			Helper.anggotas.Clear();
		} else {
			foreach (ListViewItem x in _Tabel.SelectedItems) {
				Helper.anggotas.Remove((UnitAnggota)x.Tag);
				_Tabel.Items.Remove(x);
			}
		}
		RefreshAnggota();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
        var a = new AboutBox();
        a.ShowDialog();
	}

	private void _Tabel_SelectedIndexChanged(object sender, EventArgs e)
	{
		if ((_Tabel.SelectedItems.Count == 0)) {
			Button1.Text = "Reset";
		} else {
			Button1.Text = "Hapus";
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		KirimKePrinter();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		_Tingkat.SelectedIndex = 0;
	}
	public Form1()
	{
        InitializeComponent();
        PrintDoc.BeginPrint += PrintDocument1_BeginPrint;
        PrintDoc.PrintPage += PrintDocument1_PrintPage;
	}
}