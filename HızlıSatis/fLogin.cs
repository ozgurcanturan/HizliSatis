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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void bGiris_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            if (tKullaniciAdi.Text != "" && tSifre.Text != "")
            {
                try
                {
                    using (var db = new BarkodDbEntities())
                    {
                        if (db.Kullanici.Any())
                        {
                            var bak = db.Kullanici.Where(x => x.KullaniciAd == tKullaniciAdi.Text && x.Sifre == tSifre.Text).FirstOrDefault();
                            if (bak != null)
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                fBaslangic f = new fBaslangic();
                                f.bSatisİslemi.Enabled = (bool)bak.Satis;
                                f.bGenelRapor.Enabled = (bool)bak.Rapor;
                                f.bStok.Enabled = (bool)bak.Stok;
                                f.bUrunGiris.Enabled = (bool)bak.UrunGiris;
                                f.bAyarlar.Enabled = (bool)bak.Ayarlar;
                                f.bFiyatGüncelle.Enabled = (bool)bak.FiyatGuncelle;
                                f.bYedekleme.Enabled = (bool)bak.Yedekleme;
                                f.lKullanici.Text = bak.AdSoyad;
                                var isyeri = db.Sabit.FirstOrDefault();
                                f.lIsyeri.Text = isyeri.Unvan;
                                f.Show();
                                this.Hide();
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Giriş");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Adı Şifre Tablosunda Hata x 003");
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString() + "Test");
                }
            }
        }

        private void bGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GirisYap();
            }
        }
    }
}
