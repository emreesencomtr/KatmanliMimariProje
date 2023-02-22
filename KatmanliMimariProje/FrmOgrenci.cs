using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;
using DataAccessLayer;

namespace KatmanliMimariProje
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Numara = TxtNumara.Text;
            ent.Bolum = TxtBolum.Text;
            BLOgrenci.OgrenciEkleBL(ent);
          
            MessageBox.Show("Öğrenci Kaydı Eklenmiştir.");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrenciler = BLOgrenci.OgrenciListesiBL();
            dataGridView1.DataSource = ogrenciler;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(TxtID.Text);
            EntityOgrenci en = new EntityOgrenci();
            en.OgrID = deger;
            BLOgrenci.OgrencilSilBL(en.OgrID);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Bolum = TxtBolum.Text;
            ent.Numara = TxtNumara.Text;
            ent.OgrID = int.Parse (TxtID.Text);
            BLOgrenci.OgrenciGunlleBL(ent);
            MessageBox.Show("Öğrenci bilgisi güncellendi!");

        }
    }
}
