using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalDers
    {
        //Crud Metotları
        //ekle, silme , güncelleme ve silme
        public static int DersEkle(EntityDers p)
        {
            SqlCommand komut1 = new SqlCommand("insert into TblDersler (DersAd) values (@p1)", Baglanti.bgl);
            if(komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            komut1.Parameters.AddWithValue("@p1", p.DersAd);
            return komut1.ExecuteNonQuery();
   
        }

        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> dersler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("select * from TblDersler", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }

            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DersID = byte.Parse (dr["DersID"].ToString());
                ent.DersAd = dr["DersAd"].ToString();
                dersler.Add(ent);

            }

            dr.Close();
            return dersler;
        }

         public static int DersSil (byte p)
        {
            SqlCommand komut3 = new SqlCommand(" delete from TblDersler where DersID=@p1", Baglanti.bgl);
            if(komut3.Connection.State!= ConnectionState.Open)
            {
                komut3.Connection.Open();

            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery();
        }

        public static int DersGuncelle (EntityDers p)
        {
            SqlCommand komut4 = new SqlCommand(" update TblDersler set DersAd=@p1 where DersID=@P2", Baglanti.bgl);
            if( komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }

            komut4.Parameters.AddWithValue("@p1", p.DersAd);
            komut4.Parameters.AddWithValue("@p2", p.DersID);
            return komut4.ExecuteNonQuery();
        }


    }
}
