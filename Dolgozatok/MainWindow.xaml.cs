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

namespace Dolgozatok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Ember
        {
            public Ember(string nev, int eletkor, int pontszam)
            {
                Nev = nev;
                Eletkor = eletkor;
                Pontszam = pontszam;
            }

            public string Nev { get; set; }
            public int Eletkor{ get; set; }
            public int Pontszam { get; set; }

        }

        public List<Ember> emberek = new List<Ember>();

        public string nev;
        public int eletkor;
        public int pontszam;
        public MainWindow()
        {
            InitializeComponent();
            Ember test1 = new Ember("Kiss József", 15, 10);
            emberek.Add(test1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}