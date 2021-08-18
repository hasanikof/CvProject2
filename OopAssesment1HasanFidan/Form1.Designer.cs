namespace OopAssesment1HasanFidan
{
    partial class Pizzacım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pizzacım));
            this.lbl_Ebatlar = new System.Windows.Forms.Label();
            this.lbl_Pizzalar = new System.Windows.Forms.Label();
            this.combobox_Ebatlar = new System.Windows.Forms.ComboBox();
            this.listbox_Pizzalar = new System.Windows.Forms.ListBox();
            this.rdb_InceKenar = new System.Windows.Forms.RadioButton();
            this.rdb_KalinKenar = new System.Windows.Forms.RadioButton();
            this.lbl_Malzemeler = new System.Windows.Forms.Label();
            this.listbox_Siparisler = new System.Windows.Forms.ListBox();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_SepeteEkle = new System.Windows.Forms.Button();
            this.txbx_adet = new System.Windows.Forms.TextBox();
            this.txbx_tutar = new System.Windows.Forms.TextBox();
            this.lbl_ToplamTutar = new System.Windows.Forms.Label();
            this.txbx_ToplamTutar = new System.Windows.Forms.TextBox();
            this.btn_SiparisOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Ebatlar
            // 
            this.lbl_Ebatlar.AutoSize = true;
            this.lbl_Ebatlar.Location = new System.Drawing.Point(21, 22);
            this.lbl_Ebatlar.Name = "lbl_Ebatlar";
            this.lbl_Ebatlar.Size = new System.Drawing.Size(61, 17);
            this.lbl_Ebatlar.TabIndex = 0;
            this.lbl_Ebatlar.Text = "Ebatlar :";
            // 
            // lbl_Pizzalar
            // 
            this.lbl_Pizzalar.AutoSize = true;
            this.lbl_Pizzalar.Location = new System.Drawing.Point(21, 66);
            this.lbl_Pizzalar.Name = "lbl_Pizzalar";
            this.lbl_Pizzalar.Size = new System.Drawing.Size(66, 17);
            this.lbl_Pizzalar.TabIndex = 1;
            this.lbl_Pizzalar.Text = "Pizzalar :";
            // 
            // combobox_Ebatlar
            // 
            this.combobox_Ebatlar.FormattingEnabled = true;
            this.combobox_Ebatlar.Location = new System.Drawing.Point(88, 15);
            this.combobox_Ebatlar.Name = "combobox_Ebatlar";
            this.combobox_Ebatlar.Size = new System.Drawing.Size(210, 24);
            this.combobox_Ebatlar.TabIndex = 2;
            // 
            // listbox_Pizzalar
            // 
            this.listbox_Pizzalar.FormattingEnabled = true;
            this.listbox_Pizzalar.ItemHeight = 16;
            this.listbox_Pizzalar.Location = new System.Drawing.Point(88, 66);
            this.listbox_Pizzalar.Name = "listbox_Pizzalar";
            this.listbox_Pizzalar.Size = new System.Drawing.Size(210, 116);
            this.listbox_Pizzalar.TabIndex = 3;
            // 
            // rdb_InceKenar
            // 
            this.rdb_InceKenar.AutoSize = true;
            this.rdb_InceKenar.Checked = true;
            this.rdb_InceKenar.Location = new System.Drawing.Point(88, 198);
            this.rdb_InceKenar.Name = "rdb_InceKenar";
            this.rdb_InceKenar.Size = new System.Drawing.Size(97, 21);
            this.rdb_InceKenar.TabIndex = 4;
            this.rdb_InceKenar.TabStop = true;
            this.rdb_InceKenar.Text = "İnce Kenar";
            this.rdb_InceKenar.UseVisualStyleBackColor = true;
            // 
            // rdb_KalinKenar
            // 
            this.rdb_KalinKenar.AutoSize = true;
            this.rdb_KalinKenar.Location = new System.Drawing.Point(196, 198);
            this.rdb_KalinKenar.Name = "rdb_KalinKenar";
            this.rdb_KalinKenar.Size = new System.Drawing.Size(102, 21);
            this.rdb_KalinKenar.TabIndex = 5;
            this.rdb_KalinKenar.Text = "Kalın Kenar";
            this.rdb_KalinKenar.UseVisualStyleBackColor = true;
            // 
            // lbl_Malzemeler
            // 
            this.lbl_Malzemeler.AutoSize = true;
            this.lbl_Malzemeler.Location = new System.Drawing.Point(21, 238);
            this.lbl_Malzemeler.Name = "lbl_Malzemeler";
            this.lbl_Malzemeler.Size = new System.Drawing.Size(88, 17);
            this.lbl_Malzemeler.TabIndex = 6;
            this.lbl_Malzemeler.Text = "Malzemeler :";
            // 
            // listbox_Siparisler
            // 
            this.listbox_Siparisler.FormattingEnabled = true;
            this.listbox_Siparisler.ItemHeight = 16;
            this.listbox_Siparisler.Location = new System.Drawing.Point(321, 21);
            this.listbox_Siparisler.Name = "listbox_Siparisler";
            this.listbox_Siparisler.Size = new System.Drawing.Size(378, 372);
            this.listbox_Siparisler.TabIndex = 7;
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Location = new System.Drawing.Point(287, 444);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(50, 17);
            this.lbl_tutar.TabIndex = 8;
            this.lbl_tutar.Text = "Tutar :";
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Location = new System.Drawing.Point(4, 444);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(45, 17);
            this.lbl_adet.TabIndex = 9;
            this.lbl_adet.Text = "Adet :";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(154, 436);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(127, 33);
            this.btn_hesapla.TabIndex = 10;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_SepeteEkle
            // 
            this.btn_SepeteEkle.Enabled = false;
            this.btn_SepeteEkle.Location = new System.Drawing.Point(442, 436);
            this.btn_SepeteEkle.Name = "btn_SepeteEkle";
            this.btn_SepeteEkle.Size = new System.Drawing.Size(136, 33);
            this.btn_SepeteEkle.TabIndex = 11;
            this.btn_SepeteEkle.Text = "Sepete Ekle";
            this.btn_SepeteEkle.UseVisualStyleBackColor = true;
            this.btn_SepeteEkle.Click += new System.EventHandler(this.btn_SepeteEkle_Click);
            // 
            // txbx_adet
            // 
            this.txbx_adet.Location = new System.Drawing.Point(46, 441);
            this.txbx_adet.Name = "txbx_adet";
            this.txbx_adet.Size = new System.Drawing.Size(93, 22);
            this.txbx_adet.TabIndex = 12;
            this.txbx_adet.Text = "1";
            // 
            // txbx_tutar
            // 
            this.txbx_tutar.Enabled = false;
            this.txbx_tutar.Location = new System.Drawing.Point(333, 441);
            this.txbx_tutar.Name = "txbx_tutar";
            this.txbx_tutar.Size = new System.Drawing.Size(103, 22);
            this.txbx_tutar.TabIndex = 13;
            // 
            // lbl_ToplamTutar
            // 
            this.lbl_ToplamTutar.AutoSize = true;
            this.lbl_ToplamTutar.Location = new System.Drawing.Point(422, 396);
            this.lbl_ToplamTutar.Name = "lbl_ToplamTutar";
            this.lbl_ToplamTutar.Size = new System.Drawing.Size(101, 17);
            this.lbl_ToplamTutar.TabIndex = 14;
            this.lbl_ToplamTutar.Text = "Toplam Tutar :";
            // 
            // txbx_ToplamTutar
            // 
            this.txbx_ToplamTutar.Enabled = false;
            this.txbx_ToplamTutar.Location = new System.Drawing.Point(529, 396);
            this.txbx_ToplamTutar.Name = "txbx_ToplamTutar";
            this.txbx_ToplamTutar.Size = new System.Drawing.Size(170, 22);
            this.txbx_ToplamTutar.TabIndex = 15;
            // 
            // btn_SiparisOnayla
            // 
            this.btn_SiparisOnayla.Enabled = false;
            this.btn_SiparisOnayla.Location = new System.Drawing.Point(600, 431);
            this.btn_SiparisOnayla.Name = "btn_SiparisOnayla";
            this.btn_SiparisOnayla.Size = new System.Drawing.Size(139, 46);
            this.btn_SiparisOnayla.TabIndex = 16;
            this.btn_SiparisOnayla.Text = "Sipariş Onayla";
            this.btn_SiparisOnayla.UseVisualStyleBackColor = true;
            this.btn_SiparisOnayla.Click += new System.EventHandler(this.btn_SiparisOnayla_Click);
            // 
            // Pizzacım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 496);
            this.Controls.Add(this.btn_SiparisOnayla);
            this.Controls.Add(this.txbx_ToplamTutar);
            this.Controls.Add(this.lbl_ToplamTutar);
            this.Controls.Add(this.txbx_tutar);
            this.Controls.Add(this.txbx_adet);
            this.Controls.Add(this.btn_SepeteEkle);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.lbl_adet);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.listbox_Siparisler);
            this.Controls.Add(this.lbl_Malzemeler);
            this.Controls.Add(this.rdb_KalinKenar);
            this.Controls.Add(this.rdb_InceKenar);
            this.Controls.Add(this.listbox_Pizzalar);
            this.Controls.Add(this.combobox_Ebatlar);
            this.Controls.Add(this.lbl_Pizzalar);
            this.Controls.Add(this.lbl_Ebatlar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pizzacım";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ebatlar;
        private System.Windows.Forms.Label lbl_Pizzalar;
        private System.Windows.Forms.ComboBox combobox_Ebatlar;
        private System.Windows.Forms.ListBox listbox_Pizzalar;
        private System.Windows.Forms.RadioButton rdb_InceKenar;
        private System.Windows.Forms.RadioButton rdb_KalinKenar;
        private System.Windows.Forms.Label lbl_Malzemeler;
        private System.Windows.Forms.ListBox listbox_Siparisler;
        private System.Windows.Forms.Label lbl_tutar;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_SepeteEkle;
        private System.Windows.Forms.TextBox txbx_adet;
        private System.Windows.Forms.TextBox txbx_tutar;
        private System.Windows.Forms.Label lbl_ToplamTutar;
        private System.Windows.Forms.TextBox txbx_ToplamTutar;
        private System.Windows.Forms.Button btn_SiparisOnayla;
    }
}

