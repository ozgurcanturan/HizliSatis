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
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (bKaydet.Text == "Kaydet")
            {
                if (tAdSoyad.Text != "" && mtTelefon.Text != "" && tKullaniciAdi.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        try
                        {
                            using (var db = new BarkodDbEntities())
                            {
                                if (!db.Kullanici.Any(x => x.KullaniciAd == tKullaniciAdi.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.AdSoyad = tAdSoyad.Text;
                                    k.Telefon = mtTelefon.Text;
                                    k.EPosta = tEPosta.Text;
                                    k.KullaniciAd = tKullaniciAdi.Text.Trim();
                                    k.Sifre = tSifre.Text;
                                    k.Satis = chSatisEkrani.Checked;
                                    k.Rapor = chRapor.Checked;
                                    k.Stok = chStok.Checked;
                                    k.UrunGiris = chUrunGiris.Checked;
                                    k.Ayarlar = chAyarlar.Checked;
                                    k.FiyatGuncelle = chFiyatGuncelle.Checked;
                                    k.Yedekleme = chYedekleme.Checked;
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    gridListeKullanici.DataSource = db.Kullanici.Select(x => new { x.AdSoyad, x.KullaniciAd, x.Telefon, x.EPosta }).ToList();
                                    Temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Bu kullanıcı zaten kayıtlı");
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Hata Oluştu" + ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz" + "\nAd Soyad \nTelefon \nKullanıcı Adı \nŞifre ve \nŞifre Tekrar");
                }
            }
            else if (bKaydet.Text == "Düzenle/Kaydet")
            {

                if (tAdSoyad.Text != "" && mtTelefon.Text != "" && tKullaniciAdi.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        int id = Convert.ToInt32(lKullaniciId.Text);
                        using (var db = new BarkodDbEntities())
                        {
                            var guncelle = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                            guncelle.AdSoyad = tAdSoyad.Text;
                            guncelle.Telefon = mtTelefon.Text;
                            guncelle.EPosta = tEPosta.Text;
                            guncelle.KullaniciAd = tKullaniciAdi.Text.Trim();
                            guncelle.Sifre = tSifre.Text;
                            guncelle.Satis = chSatisEkrani.Checked;
                            guncelle.Rapor = chRapor.Checked;
                            guncelle.Stok = chStok.Checked;
                            guncelle.UrunGiris = chUrunGiris.Checked;
                            guncelle.Ayarlar = chAyarlar.Checked;
                            guncelle.FiyatGuncelle = chFiyatGuncelle.Checked;
                            guncelle.Yedekleme = chYedekleme.Checked;
                            db.Kullanici.Add(guncelle);
                            db.SaveChanges();
                            gridListeKullanici.DataSource = db.Kullanici.Select(x => new { x.AdSoyad, x.KullaniciAd, x.Telefon, x.EPosta }).ToList();
                            Temizle();
                            MessageBox.Show("Kullanıcı Bilgileri Güncellenmiştir");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifre Uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz" + "\nAd Soyad \nTelefon \nKullanıcı Adı \nŞifre ve \nŞifre Tekrar");
                }
            }
        }

        private void Temizle()
        {
            tAdSoyad.Clear();
            mtTelefon.Clear();
            tEPosta.Clear();
            tKullaniciAdi.Clear();
            tSifre.Clear();
            tSifreTekrar.Clear();
            chSatisEkrani.Checked = false;
            chRapor.Checked = false;
            chStok.Checked = false;
            chUrunGiris.Checked = false;
            chAyarlar.Checked = false;
            chFiyatGuncelle.Checked = false;
            chYedekleme.Checked = false;
            Liste();
            tAdSoyad.Focus();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListeKullanici.Rows.Count > 0)
            {
                int id = Convert.ToInt32(gridListeKullanici.CurrentRow.Cells["Id"].Value.ToString());
                lKullaniciId.Text = id.ToString();
                using (var db = new BarkodDbEntities())
                {
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                    tAdSoyad.Text = getir.AdSoyad;
                    mtTelefon.Text = getir.Telefon;
                    tEPosta.Text = getir.EPosta;
                    tKullaniciAdi.Text = getir.KullaniciAd;
                    tSifre.Text = getir.Sifre;
                    tSifreTekrar.Text = getir.Sifre;
                    chSatisEkrani.Checked = (bool)getir.Satis;
                    chRapor.Checked = (bool)getir.Rapor;
                    chStok.Checked = (bool)getir.Stok;
                    chUrunGiris.Checked = (bool)getir.UrunGiris;
                    chAyarlar.Checked = (bool)getir.Ayarlar;
                    chFiyatGuncelle.Checked = (bool)getir.FiyatGuncelle;
                    chYedekleme.Checked = (bool)getir.Yedekleme;
                    bKaydet.Text = "Düzenle/Kaydet";
                }
            }
        }

        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Liste();
        }

        private void Liste()
        {
            using (var db = new BarkodDbEntities())
            {
                gridListeKullanici.DataSource = db.Kullanici.Select(x => new { x.AdSoyad, x.KullaniciAd, x.Telefon, x.EPosta }).ToList();
            }
        }

    }
}
