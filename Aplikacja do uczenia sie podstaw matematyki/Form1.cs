using System.Windows.Forms;

namespace Aplikacja_do_uczenia_sie_podstaw_matematyki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dodawanie_btn(object sender, MouseEventArgs e)
        {
            Dodawanie.Form1 odwolanie_do_dodawania = new Dodawanie.Form1();
            odwolanie_do_dodawania.Show();
        }

        private void odejmowanie_btn(object sender, MouseEventArgs e)
        {
            Odejmowanie.Form1 odwolanie_do_odejmowanie = new Odejmowanie.Form1();
            odwolanie_do_odejmowanie.Show();
        }

        private void mnozenie_btn(object sender, MouseEventArgs e)
        {
            Mnozenie.Form1 odwolanie_do_mnozenia = new Mnozenie.Form1();
            odwolanie_do_mnozenia.Show();
        }

        private void dzielenie_btn(object sender, MouseEventArgs e)
        {
            Dzielenie.Form1 odwolanie_do_dzielenia = new Dzielenie.Form1();
            odwolanie_do_dzielenia.Show();
        }
    }
}