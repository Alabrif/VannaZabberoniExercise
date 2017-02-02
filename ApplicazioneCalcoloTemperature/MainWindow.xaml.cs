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
        public MainWindow ()
        {
            InitializeComponent();
        }

        private void generaTemp_Click ( object sender , RoutedEventArgs e )
        {
            GestioneTemperature myGestione = new GestioneTemperature(15, 0, 25);

            int[] temperature = myGestione.GetTemeperature();

            foreach ( var temp in temperature )
            {
                temperatureGenerate.Text += temp.ToString() + " - " ;
            }
        }
    }
}
