namespace Dzielenie
{
    partial class Dzielenieform
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
            this.components = new System.ComponentModel.Container();
            this.Odpowiedz = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.Label();
            this.Sprawdz = new System.Windows.Forms.Button();
            this.Generuj = new System.Windows.Forms.Button();
            this.rownanie = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Odpowiedz
            // 
            this.Odpowiedz.AutoSize = true;
            this.Odpowiedz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Odpowiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odpowiedz.Location = new System.Drawing.Point(111, 153);
            this.Odpowiedz.Name = "Odpowiedz";
            this.Odpowiedz.Size = new System.Drawing.Size(0, 38);
            this.Odpowiedz.TabIndex = 21;
            // 
            // wynik
            // 
            this.wynik.BackColor = System.Drawing.Color.LightGray;
            this.wynik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(462, 96);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(162, 31);
            this.wynik.TabIndex = 20;
            this.wynik.TextChanged += new System.EventHandler(this.wynik_TextChanged);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(787, 75);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(143, 38);
            this.score.TabIndex = 19;
            this.score.Text = "Wynik: 0";
            // 
            // Sprawdz
            // 
            this.Sprawdz.BackColor = System.Drawing.Color.Transparent;
            this.Sprawdz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sprawdz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sprawdz.Location = new System.Drawing.Point(401, 392);
            this.Sprawdz.Name = "Sprawdz";
            this.Sprawdz.Size = new System.Drawing.Size(143, 132);
            this.Sprawdz.TabIndex = 18;
            this.Sprawdz.UseVisualStyleBackColor = false;
            this.Sprawdz.Click += new System.EventHandler(this.button2_Click);
            // 
            // Generuj
            // 
            this.Generuj.BackColor = System.Drawing.Color.Transparent;
            this.Generuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generuj.Location = new System.Drawing.Point(165, 392);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(143, 132);
            this.Generuj.TabIndex = 17;
            this.Generuj.UseVisualStyleBackColor = false;
            this.Generuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // rownanie
            // 
            this.rownanie.AutoSize = true;
            this.rownanie.BackColor = System.Drawing.Color.Transparent;
            this.rownanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rownanie.Location = new System.Drawing.Point(56, 75);
            this.rownanie.Name = "rownanie";
            this.rownanie.Size = new System.Drawing.Size(295, 69);
            this.rownanie.TabIndex = 16;
            this.rownanie.Text = "Równanie";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dzielenieform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dzielenie.Properties.Resources.dzielenie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 522);
            this.Controls.Add(this.Odpowiedz);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Sprawdz);
            this.Controls.Add(this.Generuj);
            this.Controls.Add(this.rownanie);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dzielenieform";
            this.Text = "Dzielenie";
            this.Activated += new System.EventHandler(this.Dzielenieform_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Odpowiedz;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button Sprawdz;
        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.Label rownanie;
        public System.Windows.Forms.Timer timer1;
    }
}

