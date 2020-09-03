namespace ProjeYaz2020
{
    partial class Kaydet
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KayitEdildi = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyunu kaydetmek ister misiniz ?\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(280, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Evet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(133, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KayitEdildi
            // 
            this.KayitEdildi.AutoSize = true;
            this.KayitEdildi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayitEdildi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.KayitEdildi.Location = new System.Drawing.Point(200, 93);
            this.KayitEdildi.Name = "KayitEdildi";
            this.KayitEdildi.Size = new System.Drawing.Size(22, 23);
            this.KayitEdildi.TabIndex = 3;
            this.KayitEdildi.Text = "  ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(133, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 65);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sıfırla";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Kaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 302);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.KayitEdildi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Kaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kaydet";
            this.Load += new System.EventHandler(this.Kaydet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label KayitEdildi;
        private System.Windows.Forms.Button button3;
    }
}