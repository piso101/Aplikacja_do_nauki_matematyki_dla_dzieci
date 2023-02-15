namespace Dodawanie
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.rownanie = new System.Windows.Forms.Label();
            this.Generuj = new System.Windows.Forms.Button();
            this.Sprawdz = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Odpowiedz = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj te liczby!";
            // 
            // rownanie
            // 
            this.rownanie.AutoSize = true;
            this.rownanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rownanie.Location = new System.Drawing.Point(135, 93);
            this.rownanie.Name = "rownanie";
            this.rownanie.Size = new System.Drawing.Size(125, 32);
            this.rownanie.TabIndex = 3;
            this.rownanie.Text = "Rowanie";
            // 
            // Generuj
            // 
            this.Generuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Generuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generuj.Location = new System.Drawing.Point(126, 155);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(134, 50);
            this.Generuj.TabIndex = 4;
            this.Generuj.Text = "Generuj!";
            this.Generuj.UseVisualStyleBackColor = false;
            this.Generuj.Click += new System.EventHandler(this.Generuj_Click);
            // 
            // Sprawdz
            // 
            this.Sprawdz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sprawdz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sprawdz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sprawdz.Location = new System.Drawing.Point(430, 146);
            this.Sprawdz.Name = "Sprawdz";
            this.Sprawdz.Size = new System.Drawing.Size(134, 50);
            this.Sprawdz.TabIndex = 5;
            this.Sprawdz.Text = "Sprawdz";
            this.Sprawdz.UseVisualStyleBackColor = false;
            this.Sprawdz.Click += new System.EventHandler(this.Sprawdz_Click);
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(446, 103);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(87, 22);
            this.wynik.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(386, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tutaj wpisz wynik";
            // 
            // Odpowiedz
            // 
            this.Odpowiedz.AutoSize = true;
            this.Odpowiedz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Odpowiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odpowiedz.Location = new System.Drawing.Point(94, 266);
            this.Odpowiedz.Name = "Odpowiedz";
            this.Odpowiedz.Size = new System.Drawing.Size(0, 54);
            this.Odpowiedz.TabIndex = 8;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(770, 28);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(147, 39);
            this.score.TabIndex = 9;
            this.score.Text = "Wynik: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1002, 522);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Odpowiedz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.Sprawdz);
            this.Controls.Add(this.Generuj);
            this.Controls.Add(this.rownanie);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Dodawanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rownanie;
        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.Button Sprawdz;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Odpowiedz;
        private System.Windows.Forms.Label score;
    }
}

