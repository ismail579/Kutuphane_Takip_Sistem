namespace Kutuphane_Takip_Sistem
{
    partial class OgretmenEkran
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.kolonNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kolonAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kolonSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kolonKitapSayısı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.kolonISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kolonIsim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kolonYazar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kolonSayfa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kolonDurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kolonNo,
            this.kolonAd,
            this.kolonSoyad,
            this.kolonKitapSayısı});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 262);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 176);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // kolonNo
            // 
            this.kolonNo.Text = "No";
            // 
            // kolonAd
            // 
            this.kolonAd.Text = "Ad";
            // 
            // kolonSoyad
            // 
            this.kolonSoyad.Text = "Soyad";
            // 
            // kolonKitapSayısı
            // 
            this.kolonKitapSayısı.Text = "KitapSayısı";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kolonISBN,
            this.kolonIsim,
            this.kolonYazar,
            this.kolonSayfa,
            this.kolonDurum});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 46);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(776, 170);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // kolonISBN
            // 
            this.kolonISBN.Text = "ISBN";
            // 
            // kolonIsim
            // 
            this.kolonIsim.Text = "İsim";
            // 
            // kolonYazar
            // 
            this.kolonYazar.Text = "Yazar";
            // 
            // kolonSayfa
            // 
            this.kolonSayfa.Text = "Sayfa";
            // 
            // kolonDurum
            // 
            this.kolonDurum.Text = "Durum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ogrenci Listesi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kitap Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(533, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Kitap Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(671, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Aldıgı Kitaplar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(112, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 29);
            this.button5.TabIndex = 8;
            this.button5.Text = "Listeyi Yenile";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // OgretmenEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "OgretmenEkran";
            this.Text = "OgretmenEkran";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OgretmenEkran_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader kolonNo;
        private System.Windows.Forms.ColumnHeader kolonAd;
        private System.Windows.Forms.ColumnHeader kolonSoyad;
        private System.Windows.Forms.ColumnHeader kolonKitapSayısı;
        private System.Windows.Forms.ColumnHeader kolonISBN;
        private System.Windows.Forms.ColumnHeader kolonIsim;
        private System.Windows.Forms.ColumnHeader kolonYazar;
        private System.Windows.Forms.ColumnHeader kolonSayfa;
        private System.Windows.Forms.ColumnHeader kolonDurum;
        private System.Windows.Forms.Button button5;
    }
}