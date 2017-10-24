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
        }

        private void _add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _reset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _print_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _about_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
