
namespace HızlıSatis
{
    partial class fUrunGiris
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tAlisFiyati = new System.Windows.Forms.TextBox();
            this.tSatisFiyati = new System.Windows.Forms.TextBox();
            this.cmbGrup = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chUrunTipi = new System.Windows.Forms.CheckBox();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lStandart11 = new HızlıSatis.lStandart();
            this.lKullanici = new HızlıSatis.lStandart();
            this.tUrunSayisi = new HızlıSatis.tNumeric();
            this.lStandart10 = new HızlıSatis.lStandart();
            this.tUrunAra = new HızlıSatis.tStandart();
            this.lStandart9 = new HızlıSatis.lStandart();
            this.bRaporAl = new HızlıSatis.bStandart();
            this.bKaydet = new HızlıSatis.bStandart();
            this.bİptal = new HızlıSatis.bStandart();
            this.bBarkodOlustur = new HızlıSatis.bStandart();
            this.bUrunGrubuEkle = new HızlıSatis.bStandart();
            this.tKdvOrani = new HızlıSatis.tNumeric();
            this.tMiktar = new HızlıSatis.tNumeric();
            this.lStandart8 = new HızlıSatis.lStandart();
            this.lStandart7 = new HızlıSatis.lStandart();
            this.lStandart6 = new HızlıSatis.lStandart();
            this.lStandart5 = new HızlıSatis.lStandart();
            this.tAciklama = new HızlıSatis.tStandart();
            this.tUrunAdi = new HızlıSatis.tStandart();
            this.tBarkod = new HızlıSatis.tStandart();
            this.lStandart4 = new HızlıSatis.lStandart();
            this.lStandart3 = new HızlıSatis.lStandart();
            this.lStandart2 = new HızlıSatis.lStandart();
            this.lStandart1 = new HızlıSatis.lStandart();
            this.gridUrunler = new HızlıSatis.gridOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chUrunTipi);
            this.splitContainer1.Panel1.Controls.Add(this.tAlisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.tSatisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart11);
            this.splitContainer1.Panel1.Controls.Add(this.lKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunSayisi);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart10);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart9);
            this.splitContainer1.Panel1.Controls.Add(this.bRaporAl);
            this.splitContainer1.Panel1.Controls.Add(this.bKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.bİptal);
            this.splitContainer1.Panel1.Controls.Add(this.bBarkodOlustur);
            this.splitContainer1.Panel1.Controls.Add(this.bUrunGrubuEkle);
            this.splitContainer1.Panel1.Controls.Add(this.tKdvOrani);
            this.splitContainer1.Panel1.Controls.Add(this.tMiktar);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart8);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart7);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart6);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart5);
            this.splitContainer1.Panel1.Controls.Add(this.tAciklama);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAdi);
            this.splitContainer1.Panel1.Controls.Add(this.tBarkod);
            this.splitContainer1.Panel1.Controls.Add(this.cmbGrup);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart4);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart3);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart2);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(1116, 713);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 0;
            // 
            // tAlisFiyati
            // 
            this.tAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tAlisFiyati.Location = new System.Drawing.Point(572, 69);
            this.tAlisFiyati.Name = "tAlisFiyati";
            this.tAlisFiyati.Size = new System.Drawing.Size(115, 30);
            this.tAlisFiyati.TabIndex = 4;
            this.tAlisFiyati.Text = "0";
            this.tAlisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tAlisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSatisFiyati_KeyPress);
            // 
            // tSatisFiyati
            // 
            this.tSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tSatisFiyati.Location = new System.Drawing.Point(572, 105);
            this.tSatisFiyati.Name = "tSatisFiyati";
            this.tSatisFiyati.Size = new System.Drawing.Size(115, 30);
            this.tSatisFiyati.TabIndex = 5;
            this.tSatisFiyati.Text = "0";
            this.tSatisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSatisFiyati_KeyPress);
            // 
            // cmbGrup
            // 
            this.cmbGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGrup.FormattingEnabled = true;
            this.cmbGrup.Location = new System.Drawing.Point(131, 166);
            this.cmbGrup.Name = "cmbGrup";
            this.cmbGrup.Size = new System.Drawing.Size(292, 33);
            this.cmbGrup.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // chUrunTipi
            // 
            this.chUrunTipi.Appearance = System.Windows.Forms.Appearance.Button;
            this.chUrunTipi.AutoSize = true;
            this.chUrunTipi.BackColor = System.Drawing.Color.OliveDrab;
            this.chUrunTipi.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chUrunTipi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chUrunTipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chUrunTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chUrunTipi.ForeColor = System.Drawing.Color.White;
            this.chUrunTipi.Location = new System.Drawing.Point(149, 13);
            this.chUrunTipi.Margin = new System.Windows.Forms.Padding(4);
            this.chUrunTipi.Name = "chUrunTipi";
            this.chUrunTipi.Size = new System.Drawing.Size(213, 34);
            this.chUrunTipi.TabIndex = 28;
            this.chUrunTipi.Text = "Barkodlu Ürün İşlemi";
            this.chUrunTipi.UseVisualStyleBackColor = false;
            this.chUrunTipi.CheckedChanged += new System.EventHandler(this.chUrunTipi_CheckedChanged);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // lStandart11
            // 
            this.lStandart11.AutoSize = true;
            this.lStandart11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart11.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart11.Location = new System.Drawing.Point(513, 24);
            this.lStandart11.Name = "lStandart11";
            this.lStandart11.Size = new System.Drawing.Size(91, 25);
            this.lStandart11.TabIndex = 27;
            this.lStandart11.Text = "Kullanıcı:";
            // 
            // lKullanici
            // 
            this.lKullanici.AutoSize = true;
            this.lKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKullanici.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKullanici.Location = new System.Drawing.Point(610, 24);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(92, 25);
            this.lKullanici.TabIndex = 26;
            this.lKullanici.Text = "Kulanıcı1";
            // 
            // tUrunSayisi
            // 
            this.tUrunSayisi.BackColor = System.Drawing.Color.White;
            this.tUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunSayisi.Location = new System.Drawing.Point(858, 259);
            this.tUrunSayisi.Name = "tUrunSayisi";
            this.tUrunSayisi.ReadOnly = true;
            this.tUrunSayisi.Size = new System.Drawing.Size(115, 30);
            this.tUrunSayisi.TabIndex = 9;
            this.tUrunSayisi.TabStop = false;
            this.tUrunSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart10
            // 
            this.lStandart10.AutoSize = true;
            this.lStandart10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart10.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart10.Location = new System.Drawing.Point(739, 262);
            this.lStandart10.Name = "lStandart10";
            this.lStandart10.Size = new System.Drawing.Size(112, 25);
            this.lStandart10.TabIndex = 24;
            this.lStandart10.Text = "Ürün Sayısı";
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(572, 259);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(146, 30);
            this.tUrunAra.TabIndex = 12;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // lStandart9
            // 
            this.lStandart9.AutoSize = true;
            this.lStandart9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart9.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart9.Location = new System.Drawing.Point(459, 262);
            this.lStandart9.Name = "lStandart9";
            this.lStandart9.Size = new System.Drawing.Size(90, 25);
            this.lStandart9.TabIndex = 22;
            this.lStandart9.Text = "Ürün Ara";
            // 
            // bRaporAl
            // 
            this.bRaporAl.BackColor = System.Drawing.Color.OrangeRed;
            this.bRaporAl.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.bRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRaporAl.ForeColor = System.Drawing.Color.White;
            this.bRaporAl.Image = global::HızlıSatis.Properties.Resources.share__2_;
            this.bRaporAl.Location = new System.Drawing.Point(730, 10);
            this.bRaporAl.Margin = new System.Windows.Forms.Padding(1);
            this.bRaporAl.Name = "bRaporAl";
            this.bRaporAl.Size = new System.Drawing.Size(155, 74);
            this.bRaporAl.TabIndex = 14;
            this.bRaporAl.Text = "Rapor Al";
            this.bRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bRaporAl.UseVisualStyleBackColor = false;
            // 
            // bKaydet
            // 
            this.bKaydet.BackColor = System.Drawing.Color.LawnGreen;
            this.bKaydet.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.bKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKaydet.ForeColor = System.Drawing.Color.White;
            this.bKaydet.Image = global::HızlıSatis.Properties.Resources.save24;
            this.bKaydet.Location = new System.Drawing.Point(730, 177);
            this.bKaydet.Margin = new System.Windows.Forms.Padding(1);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(155, 74);
            this.bKaydet.TabIndex = 8;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bKaydet.UseVisualStyleBackColor = false;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // bİptal
            // 
            this.bİptal.BackColor = System.Drawing.Color.DimGray;
            this.bİptal.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bİptal.ForeColor = System.Drawing.Color.White;
            this.bİptal.Image = global::HızlıSatis.Properties.Resources.cancel24;
            this.bİptal.Location = new System.Drawing.Point(730, 94);
            this.bİptal.Margin = new System.Windows.Forms.Padding(1);
            this.bİptal.Name = "bİptal";
            this.bİptal.Size = new System.Drawing.Size(155, 74);
            this.bİptal.TabIndex = 9;
            this.bİptal.Text = "İptal";
            this.bİptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bİptal.UseVisualStyleBackColor = false;
            this.bİptal.Click += new System.EventHandler(this.bİptal_Click);
            // 
            // bBarkodOlustur
            // 
            this.bBarkodOlustur.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.bBarkodOlustur.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.bBarkodOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBarkodOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBarkodOlustur.ForeColor = System.Drawing.Color.White;
            this.bBarkodOlustur.Image = global::HızlıSatis.Properties.Resources.barcode4832;
            this.bBarkodOlustur.Location = new System.Drawing.Point(287, 203);
            this.bBarkodOlustur.Margin = new System.Windows.Forms.Padding(1);
            this.bBarkodOlustur.Name = "bBarkodOlustur";
            this.bBarkodOlustur.Size = new System.Drawing.Size(136, 90);
            this.bBarkodOlustur.TabIndex = 11;
            this.bBarkodOlustur.Text = "Barkod Oluştur";
            this.bBarkodOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bBarkodOlustur.UseVisualStyleBackColor = false;
            this.bBarkodOlustur.Click += new System.EventHandler(this.bBarkodOlustur_Click);
            // 
            // bUrunGrubuEkle
            // 
            this.bUrunGrubuEkle.BackColor = System.Drawing.Color.Maroon;
            this.bUrunGrubuEkle.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bUrunGrubuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUrunGrubuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bUrunGrubuEkle.ForeColor = System.Drawing.Color.White;
            this.bUrunGrubuEkle.Image = global::HızlıSatis.Properties.Resources.Ekle20;
            this.bUrunGrubuEkle.Location = new System.Drawing.Point(131, 203);
            this.bUrunGrubuEkle.Margin = new System.Windows.Forms.Padding(1);
            this.bUrunGrubuEkle.Name = "bUrunGrubuEkle";
            this.bUrunGrubuEkle.Size = new System.Drawing.Size(132, 90);
            this.bUrunGrubuEkle.TabIndex = 10;
            this.bUrunGrubuEkle.Text = "Ürün Grubu Ekle";
            this.bUrunGrubuEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bUrunGrubuEkle.UseVisualStyleBackColor = false;
            this.bUrunGrubuEkle.Click += new System.EventHandler(this.bUrunGrubuEkle_Click);
            // 
            // tKdvOrani
            // 
            this.tKdvOrani.BackColor = System.Drawing.Color.White;
            this.tKdvOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKdvOrani.Location = new System.Drawing.Point(572, 177);
            this.tKdvOrani.Name = "tKdvOrani";
            this.tKdvOrani.Size = new System.Drawing.Size(115, 30);
            this.tKdvOrani.TabIndex = 7;
            this.tKdvOrani.Text = "8";
            this.tKdvOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tMiktar
            // 
            this.tMiktar.BackColor = System.Drawing.Color.White;
            this.tMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tMiktar.Location = new System.Drawing.Point(572, 141);
            this.tMiktar.Name = "tMiktar";
            this.tMiktar.Size = new System.Drawing.Size(115, 30);
            this.tMiktar.TabIndex = 6;
            this.tMiktar.Text = "0";
            this.tMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart8
            // 
            this.lStandart8.AutoSize = true;
            this.lStandart8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart8.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart8.Location = new System.Drawing.Point(459, 180);
            this.lStandart8.Name = "lStandart8";
            this.lStandart8.Size = new System.Drawing.Size(107, 25);
            this.lStandart8.TabIndex = 12;
            this.lStandart8.Text = "KDV Oranı";
            // 
            // lStandart7
            // 
            this.lStandart7.AutoSize = true;
            this.lStandart7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart7.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart7.Location = new System.Drawing.Point(459, 144);
            this.lStandart7.Name = "lStandart7";
            this.lStandart7.Size = new System.Drawing.Size(65, 25);
            this.lStandart7.TabIndex = 11;
            this.lStandart7.Text = "Miktar";
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(459, 108);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(107, 25);
            this.lStandart6.TabIndex = 10;
            this.lStandart6.Text = "Satış Fiyatı";
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart5.Location = new System.Drawing.Point(459, 69);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(95, 25);
            this.lStandart5.TabIndex = 9;
            this.lStandart5.Text = "Alış Fiyatı";
            // 
            // tAciklama
            // 
            this.tAciklama.BackColor = System.Drawing.Color.White;
            this.tAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAciklama.Location = new System.Drawing.Point(131, 130);
            this.tAciklama.Name = "tAciklama";
            this.tAciklama.Size = new System.Drawing.Size(292, 30);
            this.tAciklama.TabIndex = 2;
            // 
            // tUrunAdi
            // 
            this.tUrunAdi.BackColor = System.Drawing.Color.White;
            this.tUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAdi.Location = new System.Drawing.Point(131, 94);
            this.tUrunAdi.Name = "tUrunAdi";
            this.tUrunAdi.Size = new System.Drawing.Size(292, 30);
            this.tUrunAdi.TabIndex = 1;
            // 
            // tBarkod
            // 
            this.tBarkod.BackColor = System.Drawing.Color.White;
            this.tBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBarkod.Location = new System.Drawing.Point(131, 58);
            this.tBarkod.Name = "tBarkod";
            this.tBarkod.Size = new System.Drawing.Size(292, 30);
            this.tBarkod.TabIndex = 0;
            this.tBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBarkod_KeyDown);
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(12, 169);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(113, 25);
            this.lStandart4.TabIndex = 4;
            this.lStandart4.Text = "Ürün Grubu";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(12, 133);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(92, 25);
            this.lStandart3.TabIndex = 3;
            this.lStandart3.Text = "Açıklama";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart2.Location = new System.Drawing.Point(12, 97);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(88, 25);
            this.lStandart2.TabIndex = 2;
            this.lStandart2.Text = "Ürün Adı";
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(12, 58);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(74, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Barkod";
            // 
            // gridUrunler
            // 
            this.gridUrunler.AllowUserToAddRows = false;
            this.gridUrunler.AllowUserToDeleteRows = false;
            this.gridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUrunler.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.EnableHeadersVisualStyles = false;
            this.gridUrunler.Location = new System.Drawing.Point(0, 0);
            this.gridUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.ReadOnly = true;
            this.gridUrunler.RowHeadersVisible = false;
            this.gridUrunler.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUrunler.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.gridUrunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUrunler.RowTemplate.Height = 32;
            this.gridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunler.Size = new System.Drawing.Size(1116, 407);
            this.gridUrunler.TabIndex = 0;
            this.gridUrunler.TabStop = false;
            // 
            // fUrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 713);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fUrunGiris";
            this.Text = "Ürün Giriş Formu";
            this.Load += new System.EventHandler(this.fUrunGiris_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private tNumeric tUrunSayisi;
        private lStandart lStandart10;
        private tStandart tUrunAra;
        private lStandart lStandart9;
        private bStandart bRaporAl;
        private bStandart bKaydet;
        private bStandart bİptal;
        private bStandart bBarkodOlustur;
        private bStandart bUrunGrubuEkle;
        private tNumeric tKdvOrani;
        private tNumeric tMiktar;
        private lStandart lStandart8;
        private lStandart lStandart7;
        private lStandart lStandart6;
        private lStandart lStandart5;
        private tStandart tAciklama;
        private tStandart tUrunAdi;
        private lStandart lStandart4;
        private lStandart lStandart3;
        private lStandart lStandart2;
        private lStandart lStandart1;
        private gridOzel gridUrunler;
        internal tStandart tBarkod;
        private lStandart lStandart11;
        internal lStandart lKullanici;
        public System.Windows.Forms.ComboBox cmbGrup;
        private System.Windows.Forms.TextBox tSatisFiyati;
        private System.Windows.Forms.TextBox tAlisFiyati;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.CheckBox chUrunTipi;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
    }
}