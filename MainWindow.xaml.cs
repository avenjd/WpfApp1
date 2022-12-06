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
        static int numerWybranegoChartaJanka;
        static int numerWybranegoChartaBartka;
        static int numerWybranegoChartaArka;


        static int stanKontaJanka;
        static int stanKontaBartka;
        static int stanKontaArka;

        static int ileStawiaJanek;
        static int ileStawiaBartek;
        static int ileStawiaArek;

        static int licznikRund = 0;
        static int liczbaWygranychJanka=0;
        static int liczbaWygranychBartka=0;
        static int liczbaWygranychArka=0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Postaw_Click(object sender, RoutedEventArgs e)
        {
            //1. czy dobra kwote postawili 5-15zl
            if (widokRadioJanek.IsChecked == true)
            {
                string ktoStawia = "Janek";
                widokKtoStawia.Content = ktoStawia;
                stanKontaJanka = Convert.ToInt32(widokRadioJanek.Content);
                ileStawiaJanek = Convert.ToInt32(widokIleStawia.Text);
                if(ileStawiaJanek>=5 && ileStawiaJanek <= 15)
                {
                    numerWybranegoChartaJanka = Convert.ToInt32(widokNumerCharta.Text);
                    widokJanekPodsumowanie.Content = $"{ktoStawia} stawia {ileStawiaJanek} na charta numer {numerWybranegoChartaJanka}";
                }
                else
                {
                    MessageBox.Show("Zaklad 5-15! zł");
                }
             
            }
            else if (widokRadioBartek.IsChecked == true)
            {
                string ktoStawia = "Bartek";
                widokKtoStawia.Content = ktoStawia;
                stanKontaBartka = Convert.ToInt32(widokRadioBartek.Content);
                ileStawiaBartek = Convert.ToInt32(widokIleStawia.Text);
                if (ileStawiaBartek >= 5 && ileStawiaBartek <= 15)
                {
                    numerWybranegoChartaBartka = Convert.ToInt32(widokNumerCharta.Text);
                    widokBartekPodsumowanie.Content = $"{ktoStawia} stawia {ileStawiaBartek} na charta numer {numerWybranegoChartaBartka}";
                }
                else
                {
                    MessageBox.Show("Zaklad 5-15! zł");
                }
            }
            else if (widokRadioArek.IsChecked == true)
            {
                string ktoStawia = "Arek";
                widokKtoStawia.Content = ktoStawia;
                stanKontaArka = Convert.ToInt32(widokRadioArek.Content);
                ileStawiaArek = Convert.ToInt32(widokIleStawia.Text);
                if(ileStawiaArek >=5 && ileStawiaArek <= 15)
                {
                    numerWybranegoChartaArka= Convert.ToInt32(widokNumerCharta.Text);
                    widokArekPodsumowanie.Content = $"{ktoStawia} stawia {ileStawiaArek} na charta numer {numerWybranegoChartaArka}";
                }
                else
                {
                    MessageBox.Show("Zaklad 5-15! zł");
                }

            }
            else { }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (licznikRund < 10)
            {
                //1 sprawdzenie czy kazdy zawarl zaklad
                if (widokJanekPodsumowanie.Content == null)
                {
                    MessageBox.Show("Janek nie obstawił");
                }
                if (widokBartekPodsumowanie.Content == null)
                {
                    MessageBox.Show("Bartek nie obstawił");
                }
                if (widokArekPodsumowanie.Content == null)
                {
                    MessageBox.Show("Arek nie obstawił");
                }


                //2 tworzenie 4 obiektow Czartow, ktore w konstruktorze maja tworzona pseudolosowa zmienna z wynikiem
                Charty chart1 = new Charty();
                Charty chart2 = new Charty();
                Charty chart3 = new Charty();
                Charty chart4 = new Charty();
                int c1 = chart1.randomNum;
                int c2 = chart2.randomNum;
                int c3 = chart3.randomNum;
                int c4 = chart4.randomNum;

                int[] punktyCzartow = new int[] { c1, c2, c3, c4 };
                int MaxWynikCzarta = punktyCzartow.Max();
                int IndexMaxCzarta = Array.IndexOf(punktyCzartow, MaxWynikCzarta);

                //sprawdzenie janka 
                if (numerWybranegoChartaJanka - 1 == IndexMaxCzarta) //-wygrana
                {
                    stanKontaJanka += ileStawiaJanek;
                    widokRadioJanek.Content = stanKontaJanka;
/*                    MessageBox.Show("Janek wygral!");
*/                    liczbaWygranychJanka += 1;
                }
                else //-przegrana
                {
                    stanKontaJanka -= ileStawiaJanek;
                    widokRadioJanek.Content = stanKontaJanka;
/*                    MessageBox.Show("Janek przegral!");
*/                }

                //sprawdzenie bartka 
                if (numerWybranegoChartaBartka - 1 == IndexMaxCzarta) //-wygrana
                {
                    stanKontaBartka += ileStawiaBartek;
                    widokRadioBartek.Content = stanKontaBartka;
/*                    MessageBox.Show("Bartek wygral!");
*/                    liczbaWygranychBartka += 1;
                }
                else //-przegrana
                {
                    stanKontaBartka -= ileStawiaBartek;
                    widokRadioBartek.Content = stanKontaBartka;
/*                    MessageBox.Show("Bartek przegral!");
*/                }

                //sprawdzenie arka 
                if (numerWybranegoChartaArka - 1 == IndexMaxCzarta) //-wygrana
                {
                    stanKontaArka += ileStawiaArek;
                    widokRadioArek.Content = stanKontaArka;
/*                    MessageBox.Show("Arek wygral!");
*/                    liczbaWygranychArka += 1;
                }
                else //-przegrana
                {
                    stanKontaArka -= ileStawiaArek;
                    widokRadioArek.Content = stanKontaArka;
/*                    MessageBox.Show("Arek przegral!");
*/                }
                IndexMaxCzarta += 1;
                licznikRund += 1;
                MessageBox.Show($"Najwieksza ilosc pkt w rundzie {licznikRund}  mial czart z numerem {IndexMaxCzarta}");
            }
            else
            {
                if(liczbaWygranychJanka > liczbaWygranychBartka)
                {
                    if (liczbaWygranychJanka > liczbaWygranychArka)
                    {
                        MessageBox.Show("Najwiecej wygranych mial Janek: " + liczbaWygranychJanka);
                    }
                }
                if (liczbaWygranychBartka > liczbaWygranychJanka)
                {
                    if (liczbaWygranychBartka > liczbaWygranychArka)
                    {
                        MessageBox.Show("Najwiecej wygranych mial Bartek: " + liczbaWygranychBartka);
                    }
                }
                if (liczbaWygranychArka > liczbaWygranychJanka)
                {
                    if (liczbaWygranychArka > liczbaWygranychBartka)
                    {
                        MessageBox.Show("Najwiecej wygranych mial Arek: " + liczbaWygranychArka);
                    }
                }
            }
        } 
    }
}
