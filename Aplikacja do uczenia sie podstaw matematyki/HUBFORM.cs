using System.Windows.Forms;

namespace Aplikacja_do_uczenia_sie_podstaw_matematyki
{
    public partial class HUBFORM : Form
    {
        public HUBFORM()
        {
            InitializeComponent();
        }

        private void Dodawanie_btn(object sender, MouseEventArgs e)
        {
            Dodawanie.Dodawanieform odwolanie_do_dodawania = new Dodawanie.Dodawanieform();
            odwolanie_do_dodawania.Show();
        }

        private void odejmowanie_btn(object sender, MouseEventArgs e)
        {
            Odejmowanie.Odejmowanie odwolanie_do_odejmowanie = new Odejmowanie.Odejmowanie();
            odwolanie_do_odejmowanie.Show();
        }

        private void mnozenie_btn(object sender, MouseEventArgs e)
        {
            Mnozenie.mnozenieform odwolanie_do_mnozenia = new Mnozenie.mnozenieform();
            odwolanie_do_mnozenia.Show();
        }

        private void dzielenie_btn(object sender, MouseEventArgs e)
        {
            Dzielenie.Form1 odwolanie_do_dzielenia = new Dzielenie.Form1();
            odwolanie_do_dzielenia.Show();
        }
    }
}