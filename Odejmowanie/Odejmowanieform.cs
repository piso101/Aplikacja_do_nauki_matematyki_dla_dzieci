using System.Windows.Forms;
using WMPLib;
using AxWMPLib;
using System;

namespace Odejmowanie
{
    public partial class Odejmowanie : Form
    {
        public int liczba1;
        public int liczba2;
        public int Score_kod;
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
    }
}