using System;
using System.Windows.Forms;

namespace Aplikacja_do_uczenia_sie_podstaw_matematyki
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HUBFORM());
        }
    }
}