﻿using System;
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
    public partial class fDetayGoster : Form
    {
        public fDetayGoster()
        {
            InitializeComponent();
        }
        public int islemno { get; set; }

        private void fDetayGoster_Load(object sender, EventArgs e)
        {
            lIslemNo.Text = islemno.ToString();
            using (var db = new BarkodDbEntities())
            {
                gridListe.DataSource = db.Satis.Select(s => new { s.IslemNo, s.Tarih, s.UrunAd,s.AlisFiyat,s.SatisFiyat, s.Miktar, s.Toplam }).Where(x => x.IslemNo == islemno).ToList();
                Islemler.GridDuzenle(gridListe);
            }
        }
    }
}
