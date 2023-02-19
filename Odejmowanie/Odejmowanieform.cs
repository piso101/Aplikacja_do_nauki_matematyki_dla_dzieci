using System.Windows.Forms;
using WMPLib;
using AxWMPLib;
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;


namespace Odejmowanie
{
    public partial class Odejmowanie : Form
    {
        public int liczba1;
        public int liczba2;
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
        public Odejmowanie()
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
            liczba1 = random.Next(1, 30);
            liczba2 = random.Next(1, 30);
            string liczba1_string = liczba1.ToString();
            string liczba2_string = liczba2.ToString();
            if (liczba1 > liczba2)
            {
                rownanie.Text = (liczba1_string + "-" + liczba2_string + "=");
            }
            else
            {
                rownanie.Text = (liczba2_string + "-" + liczba1_string + "=");
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            
            try
            {
                int wynik_kod = int.Parse(wynik.Text);
                if (((liczba1 - liczba2) == wynik_kod)|| ((liczba2 - liczba1) == wynik_kod))
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

        private void Odejmowanie_Activated(object sender, EventArgs e)
        {
            button1_Click(false, e);
            odczytaj();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zapisz();
            odczytaj();
            
        }
    }
}