using System.IO;
using System;
using System.Windows.Forms;

namespace Aplikacja_do_uczenia_sie_podstaw_matematyki
{
    public partial class HUBFORM : Form
    {
        public HUBFORM()
        {
            InitializeComponent();
        }
        private int Score_kod;
        public void odczytaj()
        {
            try
            {
                string pobierzwynik = File.ReadAllText(@"D:\GitHub\wynik.txt");
                Score_kod = int.Parse(pobierzwynik);
                Wynik.Text = ("Wynik: " + Score_kod);

            }
            catch
            {
                using (StreamWriter writer = new StreamWriter(@"D:\GitHub\wynik.txt"))
                {
                    writer.Write("0");
                }
            }
        }

        private void Dodawanie_btn(object sender, MouseEventArgs e)
        {
            Dodawanie.Dodawanieform odwolanie_do_dodawania = new Dodawanie.Dodawanieform();
            odwolanie_do_dodawania.TopMost = true;
            odwolanie_do_dodawania.Show();
        }

        private void odejmowanie_btn(object sender, MouseEventArgs e)
        {
            Odejmowanie.Odejmowanie odwolanie_do_odejmowanie = new Odejmowanie.Odejmowanie();
            odwolanie_do_odejmowanie.TopMost = true;
            odwolanie_do_odejmowanie.Show();
        }

        private void mnozenie_btn(object sender, MouseEventArgs e)
        {
            Mnozenie.mnozenieform odwolanie_do_mnozenia = new Mnozenie.mnozenieform();
            odwolanie_do_mnozenia.TopMost = true;
            odwolanie_do_mnozenia.Show();
        }

        private void dzielenie_btn(object sender, MouseEventArgs e)
        {
            Dzielenie.Dzielenieform odwolanie_do_dzielenia = new Dzielenie.Dzielenieform();
            odwolanie_do_dzielenia.TopMost = true;
            odwolanie_do_dzielenia.Show();
        }

        private void HUBFORM_Activated(object sender, System.EventArgs e)
        {
            odczytaj();
        }
    }
}