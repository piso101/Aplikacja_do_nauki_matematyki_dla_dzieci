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
            this.rownanie = new System.Windows.Forms.Label();
            this.Generuj = new System.Windows.Forms.Button();
            this.Sprawdz = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Odpowiedz = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rownanie
            // 
            this.rownanie.AutoSize = true;
            this.rownanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rownanie.Location = new System.Drawing.Point(178, 93);
            this.rownanie.Name = "rownanie";
            this.rownanie.Size = new System.Drawing.Size(125, 32);
            this.rownanie.TabIndex = 3;
            this.rownanie.Text = "Rowanie";
            // 
            // Generuj
            // 
            this.Generuj.BackColor = System.Drawing.Color.Transparent;
            this.Generuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generuj.Location = new System.Drawing.Point(141, 347);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(134, 50);
            this.Generuj.TabIndex = 4;
            this.Generuj.Text = "Generuj!";
            this.Generuj.UseVisualStyleBackColor = false;
            this.Generuj.Click += new System.EventHandler(this.Generuj_Click);
            // 
            // Sprawdz
            // 
            this.Sprawdz.BackColor = System.Drawing.Color.Transparent;
            this.Sprawdz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sprawdz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sprawdz.Location = new System.Drawing.Point(392, 347);
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(415, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tutaj wpisz wynik";
            // 
            // Odpowiedz
            // 
            this.Odpowiedz.AutoSize = true;
            this.Odpowiedz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Odpowiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odpowiedz.Location = new System.Drawing.Point(57, 206);
            this.Odpowiedz.Name = "Odpowiedz";
            this.Odpowiedz.Size = new System.Drawing.Size(0, 52);
            this.Odpowiedz.TabIndex = 8;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(799, 52);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(143, 38);
            this.score.TabIndex = 9;
            this.score.Text = "Wynik: 0";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Dodawanie.Properties.Resources.DALL_E_2023_02_15_22_29_05___cute_icon_of_happy__character_looking_like_cute_boy__pointing_downwards_to_write_there_anwser_removebg_preview;
            this.pictureBox6.Location = new System.Drawing.Point(435, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(120, 87);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Dodawanie.Properties.Resources.DALL_E_2023_02_15_22_22_45___cute_icon_of_character_showing_to_add_those_numbers_removebg_preview;
            this.pictureBox5.Location = new System.Drawing.Point(-6, 24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(20);
            this.pictureBox5.Size = new System.Drawing.Size(178, 135);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Dodawanie.Properties.Resources.DALL_E_2023_02_15_22_20_42___cute_icon_of_checking_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(435, 291);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Dodawanie.Properties.Resources.DALL_E_2023_02_15_22_18_26___cute_icon_of_arrows_poiting_at_eachother_in_circle_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(184, 297);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::Dodawanie.Properties.Resources.DALL_E_2023_02_15_22_11_15___Cute_icon_of_apple_character_smiling_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(749, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox2.Location = new System.Drawing.Point(749, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 524);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1002, 522);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Odpowiedz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.Sprawdz);
            this.Controls.Add(this.Generuj);
            this.Controls.Add(this.rownanie);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dodawanie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label rownanie;
        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.Button Sprawdz;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Odpowiedz;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

