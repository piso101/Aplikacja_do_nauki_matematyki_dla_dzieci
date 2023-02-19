using System.Windows.Forms;
using WMPLib;
using AxWMPLib;
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Dzielenie
{
    public partial class Dzielenieform : Form
    {
        public int liczba1;
        public int liczba2;
        public int liczba_podzielna;
        public int Score_kod;
        public void zapisz()
        {

            string score_string = Score_kod.ToString();
            using (StreamWriter writer = new StreamWriter(@"D:\GitHub\wynik.txt"))
            {
                writer.WriteLine(score_string);
                Console.WriteLine(score_string);
            }
        }
        public void odczytaj()
        {
            try
            {
                string pobierzwynik = File.ReadAllText(@"D:\GitHub\wynik.txt");
                Score_kod = int.Parse(pobierzwynik);
                score.Text = ("Wynik: " + Score_kod);

            }
            catch
            {
                using (StreamWriter writer = new StreamWriter(@"D:\GitHub\wynik.txt"))
                {
                    writer.Write("0");
                }
            }
        }
        public Dzielenieform()
        {
            InitializeComponent();
        }
        private void zagrajpozytywnydzwiek()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"D:\GitHub\Aplikacja_do_nauki_matematyki_dla_dzieci\Muzyka\success-1-6297.mp3";
            wplayer.controls.play();
        }
        private void zagrajnegatywnydzwiek()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"D:\GitHub\Aplikacja_do_nauki_matematyki_dla_dzieci\Muzyka\negative_beeps-6008.mp3";
            wplayer.controls.play();


        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            odczytaj();
            Random random = new Random();
            liczba1 = random.Next(1, 10);
            liczba2 = random.Next(1, 10);
            liczba_podzielna = (liczba1 * liczba2);
            string liczba_podzielna_string = liczba_podzielna.ToString();
            string liczba2_string = liczba2.ToString();
            rownanie.Text = (liczba_podzielna_string + ":" + liczba2_string + "=");
        }
        private void button2_Click(object sender, System.EventArgs e)
        {

            try
            {
                int wynik_kod = int.Parse(wynik.Text);
                if (((liczba_podzielna/liczba2) == wynik_kod))
                {

                    Odpowiedz.Text = ("BRAWO DOBRY WYNIK!!");
                    zagrajpozytywnydzwiek();
                    wynik.Text = "";
                    button1_Click(true, e);
                    Score_kod += 1;
                    score.Text = ("Wynik: " + Score_kod);
                    zapisz();
                }
                else
                {
                    Odpowiedz.Text = ("Spróbuj Ponownie");
                    zagrajnegatywnydzwiek();
                    wynik.Text = "";
                    score.Text = ("Wynik: " + Score_kod);
                }
            }
            catch { }
        }
        private void wynik_TextChanged(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            zapisz();
            odczytaj();

        }

        private void Dzielenieform_Activated(object sender, EventArgs e)
        {
            button1_Click(true, e);
            odczytaj();
        }
    }
}
