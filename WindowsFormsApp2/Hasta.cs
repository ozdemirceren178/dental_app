using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2
{
     class Hasta
    {
        public void HastaEkle (string query)
        {
            SqlBaglantisi connection = new SqlBaglantisi();
            SqlConnection bgl = connection.baglanti();
            SqlCommand komut = new SqlCommand();
            komut.Connection = bgl;
            bgl.Open();
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            bgl.Close();
        }
        public DataSet ShowHasta(string query)
        {
            SqlBaglantisi connection = new SqlBaglantisi();
            SqlConnection bgl = connection.baglanti();
            SqlCommand komut = new SqlCommand(query, bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut); // SqlCommand doğrudan SqlDataAdapter'a atanıyor.
            DataSet ds = new DataSet();
            da.Fill(ds); // DataSet dolduruluyor.
            return ds;
        }
        public void  HastaSil(string query)
        {
            SqlBaglantisi connection = new SqlBaglantisi();
            SqlConnection bgl = connection.baglanti();
            SqlCommand komut = new SqlCommand();
            komut.Connection = bgl;
            bgl.Open();
            komut.CommandText = query;
            komut.ExecuteNonQuery();
            bgl.Close();
        }

    }
}
