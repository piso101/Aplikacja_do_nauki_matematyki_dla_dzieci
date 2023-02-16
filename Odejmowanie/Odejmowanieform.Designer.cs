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
            this.label2 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.Odpowiedz = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // generuj
            // 
            this.generuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generuj.Location = new System.Drawing.Point(175, 397);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(180, 57);
            this.generuj.TabIndex = 0;
            this.generuj.Text = "Generuj";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // sprawdz
            // 
            this.sprawdz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sprawdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sprawdz.Location = new System.Drawing.Point(476, 397);
            this.sprawdz.Name = "sprawdz";
            this.sprawdz.Size = new System.Drawing.Size(180, 57);
            this.sprawdz.TabIndex = 1;
            this.sprawdz.Text = "Sprawdź";
            this.sprawdz.UseVisualStyleBackColor = true;
            this.sprawdz.Click += new System.EventHandler(this.button2_Click);
            // 
            // rownanie
            // 
            this.rownanie.AutoSize = true;
            this.rownanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rownanie.Location = new System.Drawing.Point(206, 115);
            this.rownanie.Name = "rownanie";
            this.rownanie.Size = new System.Drawing.Size(170, 39);
            this.rownanie.TabIndex = 2;
            this.rownanie.Text = "Równanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(539, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tutaj Wpisz Wynik";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(810, 48);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(147, 39);
            this.score.TabIndex = 4;
            this.score.Text = "Wynik: 0";
            // 
            // Odpowiedz
            // 
            this.Odpowiedz.AutoSize = true;
            this.Odpowiedz.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Odpowiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odpowiedz.Location = new System.Drawing.Point(153, 254);
            this.Odpowiedz.Name = "Odpowiedz";
            this.Odpowiedz.Size = new System.Drawing.Size(37, 39);
            this.Odpowiedz.TabIndex = 5;
            this.Odpowiedz.Text = "1";
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(539, 130);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(113, 22);
            this.wynik.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(757, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 521);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Odejmowanie.Properties.Resources.DALL_E_2023_02_15_22_18_26___cute_icon_of_arrows_poiting_at_eachother_in_circle_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(237, 341);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Odejmowanie.Properties.Resources.DALL_E_2023_02_15_22_22_45___cute_icon_of_character_showing_to_add_those_numbers_removebg_preview;
            this.pictureBox5.Location = new System.Drawing.Point(12, 52);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(20);
            this.pictureBox5.Size = new System.Drawing.Size(178, 135);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Odejmowanie.Properties.Resources.DALL_E_2023_02_15_22_20_42___cute_icon_of_checking_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(542, 341);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Odejmowanie.Properties.Resources.DALL_E_2023_02_15_22_29_05___cute_icon_of_happy__character_looking_like_cute_boy__pointing_downwards_to_write_there_anwser_removebg_preview;
            this.pictureBox6.Location = new System.Drawing.Point(536, 37);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(120, 87);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Image = global::Odejmowanie.Properties.Resources.DALL_E_2023_02_15_22_11_15___Cute_icon_of_apple_character_smiling_removebg_preview;
            this.pictureBox1.InitialImage = global::Odejmowanie.Properties.Resources.DALL_E_2023_02_15_22_11_15___Cute_icon_of_apple_character_smiling_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(1, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Odejmowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 518);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Odpowiedz);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rownanie);
            this.Controls.Add(this.sprawdz);
            this.Controls.Add(this.generuj);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Odejmowanie";
            this.Text = "Odejmowanie";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generuj;
        private System.Windows.Forms.Button sprawdz;
        private System.Windows.Forms.Label rownanie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label Odpowiedz;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

