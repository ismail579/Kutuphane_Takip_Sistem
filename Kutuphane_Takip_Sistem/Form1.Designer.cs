namespace Kutuphane_Takip_Sistem
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
            this.giris = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGirilenSifre = new System.Windows.Forms.TextBox();
            this.txtGirilenNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.giris.SuspendLayout();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.Controls.Add(this.button1);
            this.giris.Controls.Add(this.txtGirilenSifre);
            this.giris.Controls.Add(this.txtGirilenNo);
            this.giris.Controls.Add(this.label4);
            this.giris.Controls.Add(this.label2);
            this.giris.Location = new System.Drawing.Point(12, 73);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(311, 242);
            this.giris.TabIndex = 0;
            this.giris.TabStop = false;
            this.giris.Text = "Giris";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGirilenSifre
            // 
            this.txtGirilenSifre.Location = new System.Drawing.Point(113, 93);
            this.txtGirilenSifre.Name = "txtGirilenSifre";
            this.txtGirilenSifre.Size = new System.Drawing.Size(166, 20);
            this.txtGirilenSifre.TabIndex = 4;
            // 
            // txtGirilenNo
            // 
            this.txtGirilenNo.Location = new System.Drawing.Point(113, 44);
            this.txtGirilenNo.Name = "txtGirilenNo";
            this.txtGirilenNo.Size = new System.Drawing.Size(166, 20);
            this.txtGirilenNo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Öğrenci Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrenci No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ögrenci Giris";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.giris.ResumeLayout(false);
            this.giris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGirilenSifre;
        private System.Windows.Forms.TextBox txtGirilenNo;
        private System.Windows.Forms.Label label4;
    }
}

