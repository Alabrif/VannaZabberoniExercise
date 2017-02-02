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
using WindowsPresentationFoundation;

namespace ApplicazioneCalcoloTemperature
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GestioneTemperature myGestione = new GestioneTemperature( 15 , 25 , 0 );
        int[] temperature;

        public MainWindow ()
        {
            InitializeComponent();
        }

        private void generaTemp_Click ( object sender , RoutedEventArgs e )
        {
            temperature = myGestione.GetTemeperature();
            foreach ( var temp in temperature )
            {
                temperatureGenerate.Text += temp.ToString() + " | " ;
            }
        }

        private void calcolaTemperature_Click ( object sender , RoutedEventArgs e )
        {
            int min = 0;
            int max = 0;
            double media = 0;

            bool buonFine = false;
            if ( (buonFine = myGestione.AnalizzaTemp(temperature, out min, out max, out media)) )
            {
                massimoTextBlock.Text = max.ToString();
                minimoTextBlock.Text = min.ToString();
                medioTextBlock.Text = media.ToString();
            }
        }
    }
}
