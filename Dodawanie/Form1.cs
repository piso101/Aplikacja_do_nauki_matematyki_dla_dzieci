using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dodawanie
{
    public partial class Form1 : Form
    {
        public int liczba1;
        public int liczba2;
        public int Score_kod;
        public Form1()
        {
            InitializeComponent();
        }

        private void Generuj_Click(object sender, EventArgs e)
        {
            label1.Text = ("Dodaj liczby");
            Random random = new Random();
            liczba1 = random.Next(1,30);
            liczba2 = random.Next(1,30);
            string liczba1_string = liczba1.ToString();
            string liczba2_string = liczba2.ToString();
            
            rownanie.Text = (liczba1_string+ "+" +liczba2_string+"=");
        }

        private void Sprawdz_Click(object sender, EventArgs e)
        {

            int wynik_kod = int.Parse(wynik.Text);
            try
            {

                if ((liczba1 + liczba2) == wynik_kod)
                {
                    Odpowiedz.Text = ("BRAWO DOBRY WYNIK!!");
                    wynik.Text = "";
                    Generuj_Click(true,e);
                    Score_kod+=1;
                    score.Text = ("Wynik: " + Score_kod);
                }
                else
                {
                    Odpowiedz.Text = ("Spróbuj Ponownie");
                    wynik.Text = "";
                    score.Text = ("Wynik: " + Score_kod);
                }
            }
            catch { }
        }
    }
}
