namespace Mnozenie
{
    partial class mnozenieform
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
            this.score = new System.Windows.Forms.Label();
            this.Sprawdz = new System.Windows.Forms.Button();
            this.Generuj = new System.Windows.Forms.Button();
            this.rownanie = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.TextBox();
            this.Odpowiedz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(846, 78);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(143, 38);
            this.score.TabIndex = 13;
            this.score.Text = "Wynik: 0";
            // 
            // Sprawdz
            // 
            this.Sprawdz.BackColor = System.Drawing.Color.Transparent;
            this.Sprawdz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sprawdz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sprawdz.Location = new System.Drawing.Point(443, 403);
            this.Sprawdz.Name = "Sprawdz";
            this.Sprawdz.Size = new System.Drawing.Size(116, 132);
            this.Sprawdz.TabIndex = 12;
            this.Sprawdz.UseVisualStyleBackColor = false;
            this.Sprawdz.Click += new System.EventHandler(this.Sprawdz_Click);
            // 
            // Generuj
            // 
            this.Generuj.BackColor = System.Drawing.Color.Transparent;
            this.Generuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generuj.Location = new System.Drawing.Point(195, 403);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(116, 132);
            this.Generuj.TabIndex = 11;
            this.Generuj.UseVisualStyleBackColor = false;
            this.Generuj.Click += new System.EventHandler(this.Generuj_Click);
            // 
            // rownanie
            // 
            this.rownanie.AutoSize = true;
            this.rownanie.BackColor = System.Drawing.Color.Transparent;
            this.rownanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rownanie.Location = new System.Drawing.Point(96, 78);
            this.rownanie.Name = "rownanie";
            this.rownanie.Size = new System.Drawing.Size(295, 69);
            this.rownanie.TabIndex = 10;
            this.rownanie.Text = "Równanie";
            // 
            // wynik
            // 
            this.wynik.BackColor = System.Drawing.Color.LightGray;
            this.wynik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(494, 100);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(162, 31);
            this.wynik.TabIndex = 14;
            // 
            // Odpowiedz
            // 
            this.Odpowiedz.AutoSize = true;
            this.Odpowiedz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Odpowiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odpowiedz.Location = new System.Drawing.Point(121, 188);
            this.Odpowiedz.Name = "Odpowiedz";
            this.Odpowiedz.Size = new System.Drawing.Size(0, 38);
            this.Odpowiedz.TabIndex = 15;
            // 
            // mnozenieform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mnozenie.Properties.Resources.Mnozenie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 538);
            this.Controls.Add(this.Odpowiedz);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Sprawdz);
            this.Controls.Add(this.Generuj);
            this.Controls.Add(this.rownanie);
            this.DoubleBuffered = true;
            this.Name = "mnozenieform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button Sprawdz;
        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.Label rownanie;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Label Odpowiedz;
    }
}

