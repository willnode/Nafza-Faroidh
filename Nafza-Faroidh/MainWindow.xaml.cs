using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nafza_Faroidh
{
    public struct AnggotaTemplate
    {
        public string Nama { get; set; }
        public TipeAnggota Tipe { get; set; }
        public string Kategori { get; set; }

        public override string ToString()
        {
            return Nama;
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<AnggotaTemplate> templates = new List<AnggotaTemplate>();
        public MainWindow()
        {
            InitializeComponent();
            foreach (TipeAnggota item in Enum.GetValues(typeof(TipeAnggota)))
            {
                templates.Add(new AnggotaTemplate()
                {
                    Nama = Util.Anggota2String[item],
                    Tipe = item,
                    Kategori = item <= TipeAnggota.Istri ? "Keluarga" : "Saudara",
                });
            }

            _tipe.ItemsSource = templates;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(_tipe.ItemsSource);
            view.GroupDescriptions.Add(new PropertyGroupDescription("Kategori"));

            _anggota.ItemsSource = Helper.anggotas;
        }

        private void _add_Click(object sender, RoutedEventArgs e)
        {
            var sel = (AnggotaTemplate)_tipe.SelectedItem;
            if (sel.Nama != null && Helper.VerifikasiAnggota(sel.Tipe))
            {
                Helper.anggotas.Add(new Anggota()
                {
                    nama = "Hamba Allah",
                    tipe = sel.Tipe
                });
            }
            Rekalkulasi();
        }

        private void _tipe_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _add_Click(sender, e);
        }

        private void _reset_Click(object sender, RoutedEventArgs e)
        {
            if (Helper.anggotas.Count == 0) return;
            if (MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                Helper.anggotas.Clear();
                _anggota.Items.Refresh();

            }
        }

        private void _print_Click(object sender, RoutedEventArgs e)
        {
            PrintJob.Print();
        }

        private void _about_Click(object sender, RoutedEventArgs e)
        {
            new About().ShowDialog();

        }

        public void Rekalkulasi()
        {
            decimal parsed;
            if (decimal.TryParse(_harta.Text, out parsed))
            {
                parsed = Math.Abs(parsed);
                Helper.TotalWaris = parsed;
                var tmp = _harta.Text.Length - _harta.CaretIndex;
                _harta.Text = parsed.ToString("##,#0");
                _harta.CaretIndex = Math.Max(0, _harta.Text.Length - tmp);
            }
            else
                Helper.TotalWaris = 0;

            Helper.ModelAulRodd = _aulRodd.IsChecked ?? false;
            Helper.Rekalkulasi();

            {
                // Kosmetik untuk tombol aul rodd
                _aulRodd.IsEnabled = Helper.Hasil_Cukup != 0 && Helper.anggotas.Count > 0;
                _aulRodd.FontWeight = _aulRodd.IsEnabled & (_aulRodd.IsChecked ?? false) ? FontWeights.Bold : FontWeights.Normal;
                switch (Helper.Hasil_Cukup)
                {
                    case 0:
                        _aulRodd.Content = Helper.TotalWaris == 0 ? "Total waris kosong" : "Tak ada sisa"; break;
                    case 1:
                        _aulRodd.Content = "Mode Aul"; break;
                    case 2:
                        _aulRodd.Content = Helper.anggotas.Count == 0 ? "Ahli waris kosong" : "Mode Radd"; break;
                }
            }

            _stat.Content = string.Format("Total: Rp. {0}\r\nSisa: Rp. {1}", Helper.Hasil_Total.ToString("##,#0"), Helper.Hasil_Sisa.ToString("##,#0"));
            _anggota.Items.Refresh();
        }

        public void GantiNama()
        {
            var item = _anggota.SelectedItem as Anggota;
            if (item != null)
            {
                string input = item.Nama;
                if (Util.ShowInputDialog(ref input, "Ganti nama") == System.Windows.Forms.DialogResult.OK)
                {
                    item.nama = input;
                    _anggota.Items.Refresh();
                }
            }
        }

        private void _harta_TextChanged(object sender, TextChangedEventArgs e)
        {
            Rekalkulasi();
        }

        private void _aulRodd_Checked(object sender, RoutedEventArgs e)
        {
            Rekalkulasi();
        }

        private void _anggota_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            GantiNama();
        }

        private void _anggota_KeyUp(object sender, KeyEventArgs e)
        {

        }


        private void _anggota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete || e.Key == Key.Back)
            {
                for (int i = _anggota.SelectedItems.Count; i-- > 0;)
                {
                    Helper.anggotas.Remove((Anggota)_anggota.SelectedItems[i]);
                }
                Rekalkulasi();
            }
            else if (e.Key == Key.Enter || e.Key == Key.F2)
            {
                GantiNama();
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }
    }
}
