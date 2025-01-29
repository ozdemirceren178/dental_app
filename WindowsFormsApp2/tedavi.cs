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
    public partial class tedavi : Form
    {
        public tedavi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tblTedavi (TedaviAd, TedaviTutar,TedaviAcıklama) values (@p1, @p2,@p3)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", tedaviad.Text);
            komut.Parameters.AddWithValue("@p2", tutartext.Text);
            komut.Parameters.AddWithValue("@p3", txtaçıklama.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarılı Şekilde Eklendi");
            uyeler();
            reset();
        }

        private void Tbtndüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tblTedavi set  (TedaviAd, TedaviTutar, TedaviAcıklama) values (@p1, @p2, @p3)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", tedaviad.Text);
            komut.Parameters.AddWithValue("@p2", tutartext.Text);
            komut.Parameters.AddWithValue("@p3", txtaçıklama.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarılı Şekilde Güncellendi");
            uyeler();
            reset();
        }

        private void Tbtnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From tblTedavi where TedaviAd=@p1" , bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", tedaviad.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarılı Şekilde Silindi");
            uyeler();
        }
        void uyeler()
        {
            Hasta ms = new Hasta();
            string query = " select * from tblTedavi";
            DataSet ds = ms.ShowHasta(query);
            tedavigrid.DataSource = ds.Tables[0];
        }

        private void tedavi_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        void reset()
        {
            tedaviad.Text = "";
            tutartext.Text = " ";
            txtaçıklama.Text = "";
            
        }
        int key = 0;
        private void tedavigrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tedaviad.Text = tedavigrid.SelectedRows[0].Cells[1].Value.ToString();
            tutartext.Text = tedavigrid.SelectedRows[0].Cells[2].Value.ToString();
            txtaçıklama.Text = tedavigrid.SelectedRows[0].Cells[3].Value.ToString();

            if (tedaviad.Text == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(tedavigrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
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

        private void tedaviad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tutartext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
