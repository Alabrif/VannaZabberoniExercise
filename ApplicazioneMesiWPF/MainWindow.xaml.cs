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

namespace ApplicazioneMesiWPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Mese> numeroMesiGiorni;
 


        public MainWindow ()
        {
            InitializeComponent();

            numeroMesiGiorni = new List<Mese>();
            numeroMesiGiorni.Add( new Mese( Mesi.Gennaio , 31 , Stagioni.Inverno.ToString() ) );
            numeroMesiGiorni.Add( new Mese( Mesi.Febbraio , 28 , Stagioni.Inverno.ToString() ) );
            numeroMesiGiorni.Add( new Mese( Mesi.Marzo , 31 , Stagioni.Primavera.ToString() ) );
            numeroMesiGiorni.Add( new Mese( Mesi.Aprile , 30 , Stagioni.Primavera.ToString() ) );
            numeroMesiGiorni.Add( new Mese( Mesi.Maggio , 31 , Stagioni.Primavera.ToString() ) );
            numeroMesiGiorni.Add( new Mese( Mesi.Giugno , 30 , Stagioni.Primavera.ToString() ) );
            numeroMesiGiorni.Add( new Mese( Mesi.Luglio , 31 , Stagioni.Estate.ToString() ) );
            numeroMesiGiorni.Add( new Mese( Mesi.Agosto , 31 , Stagioni.Estate.ToString() ) );
            numeroMesiGiorni.Add( new Mese( Mesi.Settembre , 30 , Stagioni.Estate.ToString() ) );
            numeroMesiGiorni.Add( new Mese( Mesi.Ottobre , 31 , Stagioni.Estate.ToString() ) );
            numeroMesiGiorni.Add( new Mese( Mesi.Novembre , 30 , Stagioni.Inverno.ToString() ) );
            numeroMesiGiorni.Add( new Mese( Mesi.Dicembre , 31 , Stagioni.Inverno.ToString() ) );
        }

        private void calcolaButton_Click ( object sender , RoutedEventArgs e )
        {
            lblnomeMese.Content = "";
            lblnumeroMese.Content = "";
            lblstagioneMese.Content = "";

            int scelta;
            if ( !int.TryParse(meseTextBox.Text, out scelta ))
            {
                MessageBox.Show( "Hai sbagliato a inserire il numero!" );
            }
            else
            {
                
                switch ( (Mesi)scelta -1 )
                {
                    case Mesi.Gennaio:
                        DeterminaMese( scelta );
                        break;
                    case Mesi.Febbraio:
                        DeterminaMese( scelta );
                        break;
                    case Mesi.Marzo:
                        DeterminaMese( scelta );
                        break;
                    case Mesi.Aprile:
                        DeterminaMese( scelta );
                        break;
                    case Mesi.Maggio:
                        DeterminaMese( scelta );
                        break;
                    case Mesi.Giugno:
                        DeterminaMese( scelta );
                        break;
                    case Mesi.Luglio:
                        DeterminaMese( scelta );
                        break;
                    case Mesi.Agosto:
                        DeterminaMese( scelta );
                        break;
                    case Mesi.Settembre:
                        DeterminaMese( scelta );
                        break;
                    case Mesi.Ottobre:
                        DeterminaMese( scelta );
                        break;
                    case Mesi.Novembre:
                        DeterminaMese( scelta );
                        break;
                    case Mesi.Dicembre:
                        DeterminaMese( scelta );
                        break;
                    default:
                        MessageBox.Show( "Inserisci un numero più basso!" );
                        break;
                }
            }
           
        }

        private void DeterminaMese(int scelta )
        {
            scelta = scelta - 1;
            if ( scelta > 0 && scelta <= 12 )
            {
                Mese temp = new Mese();
                temp = numeroMesiGiorni.ElementAt( scelta );
                lblnomeMese.Content = temp.Nome;
                lblstagioneMese.Content = temp.Stagione;
                lblnumeroMese.Content = temp.GiorniMese;
            }
            else
            {
                MessageBox.Show( "Inserisci un numero adeguato!" );
            }
           
        }
    }
}
