using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace paszport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void numerText_TextChanged(object sender, TextChangedEventArgs e)
        {
            string sciezkaZdjecie = $"/{numerText.Text}-zdjecie.jpg";

            //leweZdjecie.Source = new BitmapImage(new Uri(sciezkaZdjecie, UriKind.RelativeOrAbsolute));
        }

        private void przyciskOk_Click(object sender, RoutedEventArgs e)
        {
            string oczy="";

            if (kolorZielony.IsChecked == true)
            {
                oczy = "zielone";
            }
            else if (kolorNiebieski.IsChecked == true)
            {
                oczy = "niebieski";
            }
            else if(kolorPiwne.IsChecked == true) 
            {
                oczy = "piwne";
            }

            if (imieText.Text == "" || naziwskoText.Text == "")
            {
                MessageBox.Show("Wypelnij wszystkie dane");
            }
            else
            {
                MessageBox.Show($"{imieText.Text} {naziwskoText.Text} kolor oczu: {oczy}");
            }
            
        }
    }
}