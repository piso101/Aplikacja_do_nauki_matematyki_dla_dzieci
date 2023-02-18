using System;
using System.Media;
using System.Windows.Forms;
using NAudio;
using WMPLib;
using AxWMPLib;
namespace Dodawanie
{
    
    public partial class Dodawanieform : Form
    {
        private int liczba1;
        private int liczba2;
        private int Score_kod;

        public Dodawanieform()
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

        private void Generuj_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            liczba1 = random.Next(1, 30);
            liczba2 = random.Next(1, 30);
            string liczba1_string = liczba1.ToString();
            string liczba2_string = liczba2.ToString();

            rownanie.Text = (liczba1_string + "+" + liczba2_string + "=");
        }

        private void Sprawdz_Click(object sender, EventArgs e)
        {
            
            try
            {
                int wynik_kod = int.Parse(wynik.Text);
                if ((liczba1 + liczba2) == wynik_kod)
                {
                    Odpowiedz.Text = ("BRAWO DOBRY WYNIK!!");
                    zagrajpozytywnydzwiek();
                    wynik.Text = "";
                    Generuj_Click(true, e);
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
            catch 
            {
                //ten catch jest tylko po to gdy by ktos wpisal w pole cos innego niz liczbe
            }
        }

        private void rownanie_Click(object sender, EventArgs e)
        {

        }
    }
}