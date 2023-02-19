namespace Odejmowanie
{
    partial class Odejmowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odejmowanie));
            this.generuj = new System.Windows.Forms.Button();
            this.sprawdz = new System.Windows.Forms.Button();
            this.rownanie = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.Odpowiedz = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // generuj
            // 
            this.generuj.BackColor = System.Drawing.Color.Transparent;
            this.generuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generuj.Location = new System.Drawing.Point(175, 397);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(132, 122);
            this.generuj.TabIndex = 0;
            this.generuj.UseVisualStyleBackColor = false;
            this.generuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // sprawdz
            // 
            this.sprawdz.BackColor = System.Drawing.Color.Transparent;
            this.sprawdz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sprawdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sprawdz.Location = new System.Drawing.Point(408, 397);
            this.sprawdz.Name = "sprawdz";
            this.sprawdz.Size = new System.Drawing.Size(132, 122);
            this.sprawdz.TabIndex = 1;
            this.sprawdz.UseVisualStyleBackColor = false;
            this.sprawdz.Click += new System.EventHandler(this.button2_Click);
            // 
            // rownanie
            // 
            this.rownanie.AutoSize = true;
            this.rownanie.BackColor = System.Drawing.Color.Transparent;
            this.rownanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rownanie.Location = new System.Drawing.Point(55, 77);
            this.rownanie.Name = "rownanie";
            this.rownanie.Size = new System.Drawing.Size(295, 69);
            this.rownanie.TabIndex = 2;
            this.rownanie.Text = "Równanie";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(805, 77);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(143, 38);
            this.score.TabIndex = 4;
            this.score.Text = "Wynik: 0";
            // 
            // Odpowiedz
            // 
            this.Odpowiedz.AutoSize = true;
            this.Odpowiedz.BackColor = System.Drawing.Color.Silver;
            this.Odpowiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odpowiedz.Location = new System.Drawing.Point(153, 254);
            this.Odpowiedz.Name = "Odpowiedz";
            this.Odpowiedz.Size = new System.Drawing.Size(0, 38);
            this.Odpowiedz.TabIndex = 5;
            // 
            // wynik
            // 
            this.wynik.BackColor = System.Drawing.Color.Gainsboro;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(456, 95);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(169, 34);
            this.wynik.TabIndex = 6;
            this.wynik.TextChanged += new System.EventHandler(this.wynik_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Odejmowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Odejmowanie.Properties.Resources.Odejmowanie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 522);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.Odpowiedz);
            this.Controls.Add(this.score);
            this.Controls.Add(this.rownanie);
            this.Controls.Add(this.sprawdz);
            this.Controls.Add(this.generuj);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Odejmowanie";
            this.Text = "Odejmowanie";
            this.Activated += new System.EventHandler(this.Odejmowanie_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generuj;
        private System.Windows.Forms.Button sprawdz;
        private System.Windows.Forms.Label rownanie;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label Odpowiedz;
        private System.Windows.Forms.TextBox wynik;
        public System.Windows.Forms.Timer timer1;
    }
}

