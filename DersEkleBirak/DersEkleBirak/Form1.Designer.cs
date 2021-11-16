
namespace DersEkleBirak
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
            this.lstDersler = new System.Windows.Forms.ListBox();
            this.lstSecilenDersler = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDersler
            // 
            this.lstDersler.FormattingEnabled = true;
            this.lstDersler.ItemHeight = 16;
            this.lstDersler.Location = new System.Drawing.Point(12, 12);
            this.lstDersler.Name = "lstDersler";
            this.lstDersler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDersler.Size = new System.Drawing.Size(280, 420);
            this.lstDersler.TabIndex = 0;
            // 
            // lstSecilenDersler
            // 
            this.lstSecilenDersler.FormattingEnabled = true;
            this.lstSecilenDersler.ItemHeight = 16;
            this.lstSecilenDersler.Location = new System.Drawing.Point(377, 13);
            this.lstSecilenDersler.Name = "lstSecilenDersler";
            this.lstSecilenDersler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSecilenDersler.Size = new System.Drawing.Size(279, 420);
            this.lstSecilenDersler.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstSecilenDersler);
            this.Controls.Add(this.lstDersler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Seçme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDersler;
        private System.Windows.Forms.ListBox lstSecilenDersler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

