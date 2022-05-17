
namespace ProgramRestore
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
            this.tDosya = new System.Windows.Forms.TextBox();
            this.bSec = new System.Windows.Forms.Button();
            this.bYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tDosya
            // 
            this.tDosya.Location = new System.Drawing.Point(15, 16);
            this.tDosya.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tDosya.Name = "tDosya";
            this.tDosya.Size = new System.Drawing.Size(379, 26);
            this.tDosya.TabIndex = 0;
            // 
            // bSec
            // 
            this.bSec.Location = new System.Drawing.Point(401, 15);
            this.bSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bSec.Name = "bSec";
            this.bSec.Size = new System.Drawing.Size(126, 29);
            this.bSec.TabIndex = 1;
            this.bSec.Text = "Yedek Seç";
            this.bSec.UseVisualStyleBackColor = true;
            this.bSec.Click += new System.EventHandler(this.bSec_Click);
            // 
            // bYukle
            // 
            this.bYukle.BackColor = System.Drawing.Color.ForestGreen;
            this.bYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bYukle.Image = global::ProgramRestore.Properties.Resources.restore4854;
            this.bYukle.Location = new System.Drawing.Point(401, 65);
            this.bYukle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bYukle.Name = "bYukle";
            this.bYukle.Size = new System.Drawing.Size(126, 78);
            this.bYukle.TabIndex = 2;
            this.bYukle.Text = "YÜKLE";
            this.bYukle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bYukle.UseVisualStyleBackColor = false;
            this.bYukle.Click += new System.EventHandler(this.bYukle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "En son aldığınız yedeği seçip yükle butonuna tıklayınız.\r\n\r\nBu işlemi yaptığınızd" +
    "a mevcut veriler silinip \r\nyedekteki verileriniz yüklenecektir!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bYukle);
            this.Controls.Add(this.bSec);
            this.Controls.Add(this.tDosya);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(552, 202);
            this.MinimumSize = new System.Drawing.Size(552, 202);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YEDEKTEN GERİ YÜKLEME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tDosya;
        private System.Windows.Forms.Button bSec;
        private System.Windows.Forms.Button bYukle;
        private System.Windows.Forms.Label label1;
    }
}

