using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HızlıSatis
{
    static class Raporlar
    {
        public static string Baslik { get; set; }
        public static string TarihBaslagic { get; set; }
        public static string TarihBitis { get; set; }
        public static string SatisNakit { get; set; }
        public static string SatisKart { get; set; }
        public static string IadeNakit { get; set; }
        public static string IadeKart { get; set; }
        public static string GelirNakit { get; set; }
        public static string GelirKart { get; set; }
        public static string GiderNakit { get; set; }
        public static string GiderKart { get; set; }
        public static string KdvToplam { get; set; }
        public static string KartKomisyon { get; set; }

        public static void RaporSayfasiRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;

            List<IslemOzet> list = new List<IslemOzet>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new IslemOzet
                {
                    IslemNo = Convert.ToInt32(dgv.Rows[i].Cells["IslemNo"].Value.ToString()),
                    İade = Convert.ToBoolean(dgv.Rows[i].Cells["İade"].Value),
                    OdemeSekli = dgv.Rows[i].Cells["OdemeSekli"].Value.ToString(),
                    Nakit = Islemler.DoubleYap(dgv.Rows[i].Cells["Nakit"].Value.ToString()),
                    Kart = Islemler.DoubleYap(dgv.Rows[i].Cells["Kart"].Value.ToString()),
                    Gelir = Convert.ToBoolean(dgv.Rows[i].Cells["Gelir"].Value.ToString()),
                    Gider = Convert.ToBoolean(dgv.Rows[i].Cells["Gider"].Value.ToString()),
                    AlisFiyatToplam = Islemler.DoubleYap(dgv.Rows[i].Cells["AlisFiyatToplam"].Value.ToString()),
                    Aciklama = dgv.Rows[i].Cells["Açiklama"].Value.ToString(),
                    Tarih = Convert.ToDateTime(dgv.Rows[i].Cells["Tarih"].Value.ToString()),
                    Kullanici = dgv.Rows[i].Cells["Kullanici"].Value.ToString()

                });

            }
            


            Cursor.Current = Cursors.Default;

        }
    }
}
