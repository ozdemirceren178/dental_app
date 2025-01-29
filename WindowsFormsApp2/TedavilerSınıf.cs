using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
     class TedavilerSınıf
    {
        public void HastaEkle(string query)
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
        public void HastaSil(string query)
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
