namespace Dodawanie
{
    partial class Dodawanieform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodawanieform));
            this.rownanie = new System.Windows.Forms.Label();
            this.Generuj = new System.Windows.Forms.Button();
            this.Sprawdz = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.TextBox();
            this.Odpowiedz = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rownanie
            // 
            this.rownanie.AutoSize = true;
            this.rownanie.BackColor = System.Drawing.Color.Transparent;
            this.rownanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rownanie.Location = new System.Drawing.Point(90, 77);
            this.rownanie.Name = "rownanie";
            this.rownanie.Size = new System.Drawing.Size(262, 69);
            this.rownanie.TabIndex = 3;
            this.rownanie.Text = "Rowanie";
            this.rownanie.Click += new System.EventHandler(this.rownanie_Click);
            // 
            // Generuj
            // 
            this.Generuj.BackColor = System.Drawing.Color.Transparent;
            this.Generuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generuj.Location = new System.Drawing.Point(178, 405);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(116, 117);
            this.Generuj.TabIndex = 4;
            this.Generuj.UseVisualStyleBackColor = false;
            this.Generuj.Click += new System.EventHandler(this.Generuj_Click);
            // 
            // Sprawdz
            // 
            this.Sprawdz.BackColor = System.Drawing.Color.Transparent;
            this.Sprawdz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sprawdz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sprawdz.Location = new System.Drawing.Point(411, 405);
            this.Sprawdz.Name = "Sprawdz";
            this.Sprawdz.Size = new System.Drawing.Size(116, 117);
            this.Sprawdz.TabIndex = 5;
            this.Sprawdz.UseVisualStyleBackColor = false;
            this.Sprawdz.Click += new System.EventHandler(this.Sprawdz_Click);
            // 
            // wynik
            // 
            this.wynik.BackColor = System.Drawing.Color.LightGray;
            this.wynik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(460, 98);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(162, 31);
            this.wynik.TabIndex = 6;
            // 
            // Odpowiedz
            // 
            this.Odpowiedz.AutoSize = true;
            this.Odpowiedz.BackColor = System.Drawing.Color.DimGray;
            this.Odpowiedz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Odpowiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odpowiedz.Location = new System.Drawing.Point(121, 252);
            this.Odpowiedz.Name = "Odpowiedz";
            this.Odpowiedz.Size = new System.Drawing.Size(0, 51);
            this.Odpowiedz.TabIndex = 8;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(796, 77);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(143, 38);
            this.score.TabIndex = 9;
            this.score.Text = "Wynik: 0";
            // 
            // Dodawanieform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::Dodawanie.Properties.Resources.Desktop___1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 522);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Odpowiedz);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.Sprawdz);
            this.Controls.Add(this.Generuj);
            this.Controls.Add(this.rownanie);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dodawanieform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dodawanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label rownanie;
        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.Button Sprawdz;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Label Odpowiedz;
        private System.Windows.Forms.Label score;
    }
}

