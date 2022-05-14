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
    public partial class fUrunGrubuEkle : Form
    {
        public fUrunGrubuEkle()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        private void fUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        private void bStandart1_Click(object sender, EventArgs e)
        {
            if (turungrupad.Text != "")
            {
                UrunGrup ug = new UrunGrup();
                ug.UrunGrupAd = turungrupad.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                GrupDoldur();
                turungrupad.Clear();
                MessageBox.Show("Ürün Grubu Eklenmiştir.");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                if (f != null)
                {
                    f.GrupDoldur();
                }
            }
            else
            {
                MessageBox.Show("Grup Bilgisi Ekleyiniz.");
            }
        }

        private void GrupDoldur()
        {
            listUrunGrup.DisplayMember = "UrunGrupAd";
            listUrunGrup.ValueMember = "Id";
            listUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            int grupid = Convert.ToInt32(listUrunGrup.SelectedValue.ToString());
            string grupad = listUrunGrup.Text;
            DialogResult onay = MessageBox.Show(grupad + " grubunu silmek istiyor musunuz?", "Silme  İşlemi", MessageBoxButtons.YesNo);
            if (onay==DialogResult.Yes)
            {
                var grup = db.UrunGrup.FirstOrDefault(X => X.Id == grupid);
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                GrupDoldur();
                turungrupad.Focus();
                MessageBox.Show(grupad +" Ürün grubu silindi");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrungiris"];
                f.GrupDoldur();

            }
        }
    }
}
