using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HızlıSatis
{
    public partial class fUrunGiris : Form
    {
        public fUrunGiris()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim();
                if (db.Urun.Any(a => a.Barkod == barkod))
                {
                    var urun = db.Urun.Where(a => a.Barkod == barkod).SingleOrDefault();
                    tUrunAdi.Text = urun.UrunAd;
                    tAciklama.Text = urun.Aciklama;
                    cmbGrup.Text = urun.UrunGrup;
                    tAlisFiyati.Text = urun.AlisFiyat.ToString();
                    tSatisFiyati.Text = urun.SatisFiyat.ToString();
                    tMiktar.Text = urun.Miktar.ToString();
                    tKdvOrani.Text = urun.KdvOrani.ToString();
                    if (urun.Birim == "Kg")
                    {
                        chUrunTipi.Checked = true;
                    }
                    else
                    {
                        chUrunTipi.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Ürün Kayıtlı Değil");
                }
            }
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (tBarkod.Text != "" && tUrunAdi.Text != "" && cmbGrup.Text != "" && tAlisFiyati.Text != "" && tSatisFiyati.Text != "" && tKdvOrani.Text != "" && tMiktar.Text != "")
            {
                if (db.Urun.Any(a => a.Barkod == tBarkod.Text))
                {
                    var guncelle = db.Urun.Where(a => a.Barkod == tBarkod.Text).SingleOrDefault();
                    guncelle.UrunAd = tUrunAdi.Text;
                    guncelle.Aciklama = tAciklama.Text;
                    guncelle.UrunGrup = cmbGrup.Text;
                    guncelle.AlisFiyat = Islemler.DoubleYap(tAlisFiyati.Text); //Buraları Islemler.DoubleYap bunlar değiştirdin olmazsa Convet.Double yap
                    guncelle.SatisFiyat = Islemler.DoubleYap(tSatisFiyati.Text);
                    guncelle.KdvOrani = Convert.ToInt16(tKdvOrani.Text);
                    guncelle.KdvTutari = Math.Round(Islemler.DoubleYap(tSatisFiyati.Text) * Convert.ToInt16(tKdvOrani.Text) / 100, 2);
                    guncelle.Miktar += Convert.ToDouble(tMiktar.Text);
                    if (chUrunTipi.Checked)
                    {
                        guncelle.Birim = "Kg";
                    }
                    else
                    {
                        guncelle.Birim = "Adet";
                    }
                    guncelle.Tarih = DateTime.Now;
                    guncelle.Kullanıcı = lKullanici.Text;
                    db.SaveChanges();
                    gridUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                    MessageBox.Show("Ürün Güncellenmiştir.");
                }
                else
                {
                    Urun urun = new Urun();
                    urun.Barkod = tBarkod.Text;
                    urun.UrunAd = tUrunAdi.Text;
                    urun.Aciklama = tAciklama.Text;
                    urun.UrunGrup = cmbGrup.Text;
                    urun.AlisFiyat = Islemler.DoubleYap(tAlisFiyati.Text);
                    urun.SatisFiyat = Islemler.DoubleYap(tSatisFiyati.Text);
                    urun.KdvOrani = Convert.ToInt16(tKdvOrani.Text);
                    urun.KdvTutari = Math.Round(Islemler.DoubleYap(tSatisFiyati.Text) * Convert.ToInt16(tKdvOrani.Text) / 100, 2);
                    urun.Miktar = Convert.ToDouble(tMiktar.Text);
                    if (chUrunTipi.Checked)
                    {
                        urun.Birim = "Kg";
                    }
                    else
                    {
                        urun.Birim = "Adet";
                    }
                    urun.Tarih = DateTime.Now;
                    urun.Kullanıcı = lKullanici.Text;
                    db.Urun.Add(urun);
                    db.SaveChanges();
                    if (tBarkod.Text.Length == 8)
                    {
                        var ozelbarkod = db.Barkod.First();
                        ozelbarkod.Barkod_No += 1;
                        db.SaveChanges();
                    }


                    gridUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                    Islemler.GridDuzenle(gridUrunler);
                }
                string kgveyadt = chUrunTipi.Text;
                if (chUrunTipi.Checked)
                {
                    kgveyadt = "Kg";
                }
                else
                {
                    kgveyadt = "Adet";
                }
                Islemler.StokHareket(tBarkod.Text, tUrunAdi.Text, kgveyadt, Convert.ToDouble(tMiktar.Text), cmbGrup.Text, lKullanici.Text);
                UrunSay();
                Temizle();
            }
            else
            {
                MessageBox.Show("Bilgi Girişlerini Kontrol Ediniz.");
                tBarkod.Focus();
            }
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length >= 2)
            {
                string urunad = tUrunAra.Text;
                gridUrunler.DataSource = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
                Islemler.GridDuzenle(gridUrunler);
            }
        }

        private void bİptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            tBarkod.Clear();
            tUrunAdi.Clear();
            tAciklama.Clear();
            tAlisFiyati.Text = "0";
            tSatisFiyati.Text = "0";
            tMiktar.Text = "0";
            tKdvOrani.Text = "8";
            tUrunAra.Clear();
            tBarkod.Focus();
            chUrunTipi.Checked = false;
        }

        private void UrunSay()
        {
            tUrunSayisi.Text = db.Urun.Count().ToString();
        }

        private void fUrunGiris_Load(object sender, EventArgs e)
        {
            UrunSay();
            gridUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
            Islemler.GridDuzenle(gridUrunler);
            GrupDoldur();

        }

        private void bUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            fUrunGrubuEkle f = new fUrunGrubuEkle();
            f.ShowDialog();
        }

        public void GrupDoldur()
        {
            cmbGrup.ValueMember = "Id";
            cmbGrup.DisplayMember = "UrunGrupAd";
            cmbGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bBarkodOlustur_Click(object sender, EventArgs e)
        {
            var barkodno = db.Barkod.First();
            int karakter = barkodno.Barkod_No.ToString().Length;
            string sifirlar = string.Empty;
            for (int i = 0; i < 8 - karakter; i++)
            {
                sifirlar = sifirlar + "0";
            }
            string olusanbarkod = sifirlar + barkodno.Barkod_No.ToString();
            tBarkod.Text = olusanbarkod;
            tUrunAdi.Focus();
        }

        private void tSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != 44 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridUrunler.Rows.Count > 0)
            {
                int urunid = Convert.ToInt32(gridUrunler.CurrentRow.Cells["UrunId"].Value.ToString());
                string urunad = gridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                string barkod = gridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                DialogResult onay = MessageBox.Show(urunad + " ürününü silmek istiyor musunuz?", "Ürün Silme", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    var urun = db.Urun.Find(urunid);
                    db.Urun.Remove(urun);
                    db.SaveChanges();
                    var hizliurun = db.HizliUrun.Where(x => x.Barkod == barkod).SingleOrDefault();
                    hizliurun.Barkod = "-";
                    hizliurun.UrunAd = "-";
                    hizliurun.Fiyat = 0;
                    db.SaveChanges();
                    gridUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
                    MessageBox.Show("Ürün Silindi!");
                    Islemler.GridDuzenle(gridUrunler);
                    UrunSay();
                    tBarkod.Focus();
                }
            }

        }

        private void chUrunTipi_CheckedChanged(object sender, EventArgs e)
        {
            if (chUrunTipi.Checked)
            {
                chUrunTipi.Text = "Gramajlı Ürün İşlemi";
                bBarkodOlustur.Enabled = false;
            }
            else
            {
                chUrunTipi.Text = "Barkodlu Ürün İşlemi";
                bBarkodOlustur.Enabled = true;
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridUrunler.Rows.Count > 0)
            {
                tBarkod.Text = gridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                tUrunAdi.Text = gridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                tAciklama.Text = gridUrunler.CurrentRow.Cells["Aciklama"].Value.ToString();
                cmbGrup.Text = gridUrunler.CurrentRow.Cells["UrunGrup"].Value.ToString();
                tAlisFiyati.Text = gridUrunler.CurrentRow.Cells["AlisFiyat"].Value.ToString();
                tSatisFiyati.Text = gridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString();
                tKdvOrani.Text = gridUrunler.CurrentRow.Cells["KdvOrani"].Value.ToString();
                tMiktar.Text = gridUrunler.CurrentRow.Cells["Miktar"].Value.ToString();
                string birim = gridUrunler.CurrentRow.Cells["Birim"].Value.ToString();
                if (birim == "Kg")
                {
                    chUrunTipi.Checked = true;
                }
                else
                {
                    chUrunTipi.Checked = false;
                }

            }
        }
    }
}
