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
    public partial class fFiyatGuncelle : Form
    {
        public fFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void tbarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new BarkodDbEntities())
                {
                    if (db.Urun.Any(x => x.Barkod == tbarkod.Text))
                    {
                        var getir = db.Urun.Where(x => x.Barkod == tbarkod.Text).SingleOrDefault();
                        lBarkod.Text = getir.Barkod;
                        lUrunAdi.Text = getir.UrunAd;
                        double mevcutfiyat = Convert.ToDouble(getir.SatisFiyat);
                        lMevcutFiyat.Text = mevcutfiyat.ToString("C2");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ürün Bulunamadı");
            }
        }

        private void bGelirEkle_Click(object sender, EventArgs e)
        {
            if (tYeniFiyat.Text != "" && lBarkod.Text != "")
            {
                using (var db = new BarkodDbEntities())
                {
                    var guncellenecek = db.Urun.Where(x => x.Barkod == lBarkod.Text).SingleOrDefault();
                    guncellenecek.SatisFiyat = Islemler.DoubleYap(tYeniFiyat.Text);
                    int kdvorani =Convert.ToInt16( guncellenecek.KdvOrani);
                    guncellenecek.KdvTutari = Math.Round(Islemler.DoubleYap(tYeniFiyat.Text) * kdvorani / 100, 2);
                    db.SaveChanges();
                    MessageBox.Show("Fiyat Güncellenmiştir.");
                    lBarkod.Text = "";
                    lMevcutFiyat.Text = "";
                    tbarkod.Text = "";
                    tYeniFiyat.Clear();
                    lUrunAdi.Text = "";
                    tbarkod.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ürün Barkodu Griniz");
            }
        }
    }
}
