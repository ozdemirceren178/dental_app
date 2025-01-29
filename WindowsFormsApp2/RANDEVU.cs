using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class RANDEVU : Form
    {
        public RANDEVU()
        {
            InitializeComponent();
        }
        SqlBaglantisi sgl = new SqlBaglantisi();
        private void fillHasta()
        {
            SqlConnection bgl = sgl.baglanti();
            SqlCommand komut = new SqlCommand(" Select HastaAdSoyad from tblHastalar ", bgl);
            SqlDataReader rd;
            rd = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HastaAdSoyad" , typeof(string));
            dt.Load(rd);
            cmbad.ValueMember = "HastaAdSoyad";
            cmbad.DataSource = dt;
            rd.Close();
            bgl.Close();
        }
        private void FillTedavi()
        {
            SqlConnection bgl = sgl.baglanti();
            SqlCommand komut = new SqlCommand(" Select TedaviAd from tblTedavi ", bgl);
            SqlDataReader rd;
            rd = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TedaviAd", typeof(string));
            dt.Load(rd);
            cmbtedavi.ValueMember = "TedaviAd";
            cmbtedavi.DataSource = dt;
            rd.Close();
            bgl.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void RANDEVU_Load(object sender, EventArgs e)
        {
            fillHasta();
            FillTedavi();
            uyeler();
            Reset();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TblRandevu where RandevuID=@p1", sgl.baglanti());

            komut.Parameters.AddWithValue("@p1", label1.Text);
            komut.ExecuteNonQuery();
            sgl.baglanti().Close();
            MessageBox.Show("Başarılı Şekilde Silindi");
            uyeler();
            Reset();
        }
        void uyeler()
        {
            Hasta ms = new Hasta();
            string query = " select * from TblRandevu";
            DataSet ds = ms.ShowHasta(query);
            randevugrid.DataSource = ds.Tables[0];
        }
        void filter()
        {
            Hasta ms = new Hasta();
            string query = " select * from TblRandevu where HastaADSoyad like '%"+randevutxt.Text+"%'";
            DataSet ds = ms.ShowHasta(query);
            randevugrid.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            cmbad.Text = "";
            cmbtedavi.Text = "";
            msktarih.Text = "";
            msksaat.Text = "";
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" insert into TblRandevu(HastaADSoyad, Tedavi,TarihRandevu,RandevuSaat) values(@p1,@p2,@p3,@p4)", sgl.baglanti());
            komut.Parameters.AddWithValue("@p1",cmbad.Text);
            komut.Parameters.AddWithValue("@p2",cmbtedavi.Text);
            komut.Parameters.AddWithValue("@p3", msktarih.Text);
            komut.Parameters.AddWithValue("@p4", msksaat.Text);
            komut.ExecuteNonQuery();
            sgl.baglanti().Close();
            MessageBox.Show(" Başarılı Şkeilde Kaydedildi");
            uyeler();
            Reset();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand(" UPDATE TblRandevu SET HastaADSoyad= @p1, Tedavi=@p2 ,TarihRandevu=@p3 ,RandevuSaat=@p4  where RandevuID=@p6", sgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbad.Text);
            komut.Parameters.AddWithValue("@p2", cmbtedavi.Text);
            komut.Parameters.AddWithValue("@p3", msktarih.Text);
            komut.Parameters.AddWithValue("@p4", msksaat.Text);
            komut.Parameters.AddWithValue("@p6", label1.Text);
            
            komut.ExecuteNonQuery();
            sgl.baglanti().Close();
            MessageBox.Show(" Başarılı Şekilde Güncellendi");
            uyeler();
            Reset();
        }
        int key = 0;
        private void randevugrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             cmbad.Text = randevugrid.SelectedRows[0].Cells[1].Value.ToString();
             cmbtedavi.Text= randevugrid.SelectedRows[0].Cells[2].Value.ToString();
             msktarih.Text = randevugrid.SelectedRows[0].Cells[4].Value.ToString();
             msksaat.Text = randevugrid.SelectedRows[0].Cells[3].Value.ToString();
            label1.Text= randevugrid.SelectedRows[0].Cells[0].Value.ToString();

            if (cmbad.Text == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(randevugrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 FRM = new Form1();
            FRM.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 FRM = new Form1();
            FRM.Show();
            this.Hide();
        }
    }
}
