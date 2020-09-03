namespace ProjeYaz2020
{
    partial class AnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.YeniOyuncu = new System.Windows.Forms.Button();
            this.OncekiOyun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GirilenAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OyuncuListe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AsamaBox = new System.Windows.Forms.TextBox();
            this.PuanBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YeniOyuncu
            // 
            this.YeniOyuncu.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YeniOyuncu.Location = new System.Drawing.Point(452, 133);
            this.YeniOyuncu.Name = "YeniOyuncu";
            this.YeniOyuncu.Size = new System.Drawing.Size(220, 40);
            this.YeniOyuncu.TabIndex = 0;
            this.YeniOyuncu.Text = "Yeni Oyuncu Olustur";
            this.YeniOyuncu.UseVisualStyleBackColor = true;
            this.YeniOyuncu.Click += new System.EventHandler(this.button1_Click);
            // 
            // OncekiOyun
            // 
            this.OncekiOyun.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OncekiOyun.Location = new System.Drawing.Point(133, 180);
            this.OncekiOyun.Name = "OncekiOyun";
            this.OncekiOyun.Size = new System.Drawing.Size(213, 42);
            this.OncekiOyun.TabIndex = 1;
            this.OncekiOyun.Text = "Oyunu Başlat";
            this.OncekiOyun.UseVisualStyleBackColor = true;
            this.OncekiOyun.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(458, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yeni Oyunun Adi Giriniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GirilenAd
            // 
            this.GirilenAd.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirilenAd.Location = new System.Drawing.Point(452, 59);
            this.GirilenAd.Name = "GirilenAd";
            this.GirilenAd.Size = new System.Drawing.Size(220, 29);
            this.GirilenAd.TabIndex = 3;
            this.GirilenAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oyuncular Listesi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OyuncuListe
            // 
            this.OyuncuListe.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OyuncuListe.FormattingEnabled = true;
            this.OyuncuListe.Location = new System.Drawing.Point(133, 59);
            this.OyuncuListe.Name = "OyuncuListe";
            this.OyuncuListe.Size = new System.Drawing.Size(208, 30);
            this.OyuncuListe.TabIndex = 6;
            this.OyuncuListe.SelectedIndexChanged += new System.EventHandler(this.OyuncuListe_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aşama No";
            // 
            // AsamaBox
            // 
            this.AsamaBox.Location = new System.Drawing.Point(241, 103);
            this.AsamaBox.Name = "AsamaBox";
            this.AsamaBox.ReadOnly = true;
            this.AsamaBox.Size = new System.Drawing.Size(100, 24);
            this.AsamaBox.TabIndex = 8;
            // 
            // PuanBox
            // 
            this.PuanBox.Location = new System.Drawing.Point(241, 133);
            this.PuanBox.Name = "PuanBox";
            this.PuanBox.ReadOnly = true;
            this.PuanBox.Size = new System.Drawing.Size(100, 24);
            this.PuanBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puanlar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(458, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "  ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(786, 276);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PuanBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AsamaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OyuncuListe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GirilenAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OncekiOyun);
            this.Controls.Add(this.YeniOyuncu);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menu";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YeniOyuncu;
        private System.Windows.Forms.Button OncekiOyun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GirilenAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox OyuncuListe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AsamaBox;
        private System.Windows.Forms.TextBox PuanBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

