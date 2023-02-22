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
using DataAccessLayer;
using BusinessLayer;

namespace KatmanliMimariProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();
            ent.DersAd = TxtDersAdi.Text;
            BLDers.DersEkleBL(ent);
            MessageBox.Show("Ders kaydı eklenmiştir.");
            

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityDers> ders = BLDers.DersListesiBL();
            dataGridView1.DataSource = ders;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            byte deger =  byte.Parse(TxtDersID.Text);
            EntityDers d = new EntityDers();
            d.DersID = byte.Parse(deger.ToString());
            BLDers.DersSilBL(d.DersID);
            MessageBox.Show("Ders Silindi.");

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();
            ent.DersAd = TxtDersAdi.Text;
            ent.DersID = byte.Parse(TxtDersID.Text);
            BLDers.DersGuncelleBL(ent);
            MessageBox.Show("Ders Güncellendi.");
        }
    }
}
