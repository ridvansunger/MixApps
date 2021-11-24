
namespace radio_ile_Dort_islem
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdbTopla = new System.Windows.Forms.RadioButton();
            this.rdbCikar = new System.Windows.Forms.RadioButton();
            this.rdbCarp = new System.Windows.Forms.RadioButton();
            this.rdbBol = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 88);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 27);
            this.textBox2.TabIndex = 3;
            // 
            // rdbTopla
            // 
            this.rdbTopla.AutoSize = true;
            this.rdbTopla.Location = new System.Drawing.Point(313, 30);
            this.rdbTopla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbTopla.Name = "rdbTopla";
            this.rdbTopla.Size = new System.Drawing.Size(67, 24);
            this.rdbTopla.TabIndex = 4;
            this.rdbTopla.TabStop = true;
            this.rdbTopla.Text = "Topla";
            this.rdbTopla.UseVisualStyleBackColor = true;
            // 
            // rdbCikar
            // 
            this.rdbCikar.AutoSize = true;
            this.rdbCikar.Location = new System.Drawing.Point(313, 64);
            this.rdbCikar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbCikar.Name = "rdbCikar";
            this.rdbCikar.Size = new System.Drawing.Size(65, 24);
            this.rdbCikar.TabIndex = 5;
            this.rdbCikar.TabStop = true;
            this.rdbCikar.Text = "Çıkar";
            this.rdbCikar.UseVisualStyleBackColor = true;
            // 
            // rdbCarp
            // 
            this.rdbCarp.AutoSize = true;
            this.rdbCarp.Location = new System.Drawing.Point(313, 98);
            this.rdbCarp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbCarp.Name = "rdbCarp";
            this.rdbCarp.Size = new System.Drawing.Size(62, 24);
            this.rdbCarp.TabIndex = 6;
            this.rdbCarp.TabStop = true;
            this.rdbCarp.Text = "Çarp";
            this.rdbCarp.UseVisualStyleBackColor = true;
            // 
            // rdbBol
            // 
            this.rdbBol.AutoSize = true;
            this.rdbBol.Location = new System.Drawing.Point(313, 131);
            this.rdbBol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbBol.Name = "rdbBol";
            this.rdbBol.Size = new System.Drawing.Size(52, 24);
            this.rdbBol.TabIndex = 7;
            this.rdbBol.TabStop = true;
            this.rdbBol.Text = "Böl";
            this.rdbBol.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(155, 145);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(112, 39);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(134, 229);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(51, 20);
            this.lblSonuc.TabIndex = 9;
            this.lblSonuc.Text = "Sonuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 313);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rdbBol);
            this.Controls.Add(this.rdbCarp);
            this.Controls.Add(this.rdbCikar);
            this.Controls.Add(this.rdbTopla);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdbTopla;
        private System.Windows.Forms.RadioButton rdbCikar;
        private System.Windows.Forms.RadioButton rdbCarp;
        private System.Windows.Forms.RadioButton rdbBol;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
    }
}

