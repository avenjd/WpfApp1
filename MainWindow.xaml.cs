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

namespace WpfApp1
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

        //stworzyc 4 obiekty czartow (kazdy czart ma miec losowa liczbe w sobie).
        ///jesli gracz postawi na czarta z naiwkesza iloscia punktow to wygrywa 2x

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Charty chart1 = new Charty();
            Charty chart2 = new Charty();
            Charty chart3 = new Charty();
            Charty chart4 = new Charty();
            //l czratyow
            int[] punktyCzartow = new int[] {chart1.randomNum, chart2.randomNum, chart3.randomNum, chart4.randomNum };

            if (widokRadioJanek.IsChecked == true)
            {
                int stanKontaJanka = Convert.ToInt32(widokRadioJanek.Content);
                string ktoStawia = "Janek";
                widokKtoStawia.Content = ktoStawia;
                int ileStawia = Convert.ToInt32(widokIleStawia.Text);
                int numerWybranegoCharta = Convert.ToInt32(widokNumerCharta.Text);
                widokJanekPodsumowanie.Content = $"{ktoStawia} stawia {ileStawia} na charta numer {numerWybranegoCharta}";
                //sprawdzanie czy wybrany czart ma najwiekszy nr

                var najwiecejPunktow = punktyCzartow.Max();

                if (numerWybranegoCharta == 1)
                {

                    if (chart1.randomNum == najwiecejPunktow)//win
                    {
                        stanKontaJanka = stanKontaJanka + ileStawia;
                        widokRadioJanek.Content = stanKontaJanka;

                    }
                    else//lose
                    {
                        stanKontaJanka = stanKontaJanka - ileStawia;
                        widokRadioJanek.Content = stanKontaJanka;
                    }

                }
                else if (numerWybranegoCharta == 2)
                {
                    if (chart2.randomNum == najwiecejPunktow)//win
                    {
                        stanKontaJanka = stanKontaJanka + ileStawia;
                        widokRadioJanek.Content = stanKontaJanka;

                    }
                    else//lose
                    {
                        stanKontaJanka = stanKontaJanka - ileStawia;
                        widokRadioJanek.Content = stanKontaJanka;
                    }
                }
                else if(numerWybranegoCharta == 3)
                {
                    if (chart3.randomNum == najwiecejPunktow)//win
                    {
                        stanKontaJanka = stanKontaJanka + ileStawia;
                        widokRadioJanek.Content = stanKontaJanka;

                    }
                    else//lose
                    {
                        stanKontaJanka = stanKontaJanka - ileStawia;
                        widokRadioJanek.Content = stanKontaJanka;
                    }
                }
                else if(numerWybranegoCharta == 4)
                {
                    if (chart4.randomNum == najwiecejPunktow)//win
                    {
                        stanKontaJanka = stanKontaJanka + ileStawia;
                        widokRadioJanek.Content = stanKontaJanka;

                    }
                    else//lose
                    {
                        stanKontaJanka = stanKontaJanka - ileStawia;
                        widokRadioJanek.Content = stanKontaJanka;
                    }
                }
                else { }
            }
            else if(widokRadioBartek.IsChecked == true)
            {
                string ktoStawia = "Bartek";
                widokKtoStawia.Content = ktoStawia;
                int ileStawia = Convert.ToInt32(widokIleStawia.Text);
                int numerWybranegoCharta = Convert.ToInt32(widokNumerCharta.Text);
                widokBartekPodsumowanie.Content = $"{ktoStawia} stawia {ileStawia} na charta numer {numerWybranegoCharta}";

            }
            else if (widokRadioArek.IsChecked == true)
            {
                string ktoStawia = "Arek";
                widokKtoStawia.Content = ktoStawia;
                int ileStawia = Convert.ToInt32(widokIleStawia.Text);
                int numerWybranegoCharta = Convert.ToInt32(widokNumerCharta.Text);
                widokArekPodsumowanie.Content = $"{ktoStawia} stawia {ileStawia} na charta numer {numerWybranegoCharta}";

            }
            else { }
        }
       
    }
}
