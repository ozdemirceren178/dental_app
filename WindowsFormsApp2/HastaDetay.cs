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
    public partial class HastaDetay : Form
    {
        public HastaDetay()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
           
                SqlCommand komut = new SqlCommand("insert into tblHastalar (HastaAdSoyad, HastaTelefon, Cinsiyet, HastaDogumTarihi) values (@p1, @p2, @p3, @p4)", bgl.baglanti());
               
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", msktel.Text);
                komut.Parameters.AddWithValue("@p3", txtcinsiyet.Text);
                komut.Parameters.AddWithValue("@p4", mskdg.Text);
                
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarılı Şekilde Eklendi");
            uyeler();
            reset();

        }
        void uyeler()
        {
            Hasta ms = new Hasta();
            string query = " select * from tblHastalar";
            DataSet ds = ms.ShowHasta(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void filter()
        {
            Hasta ms = new Hasta();
            string query = " select * from tblHastalar where HastaAdSoyad like '%"+ txtarama.Text+"%'";
            DataSet ds = ms.ShowHasta(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void reset()
        {
            txtAd.Text = "";
            msktel.Text = "";
            mskdg.Text = "";
            txtcinsiyet.Text = "";
        }
        private void HastaDetay_Load(object sender, EventArgs e)
        {
            uyeler();

        }
        //Seçtiğin kişiyi listede isminin gözükmesi
        int key = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            msktel.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            mskdg.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtcinsiyet.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            if(txtAd.Text == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Delete From tblHastalar where HastaAdSoyad= @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarılı Şekilde Silindi");
            uyeler();
        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tblHastalar set HastaAdSoyad=@p1,HastaTelefon=@p2 ,HastaDogumTarihi=@p3,Cinsiyet=@p4 ", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", msktel.Text);
            komut.Parameters.AddWithValue("@p4", txtcinsiyet.Text);
            komut.Parameters.AddWithValue("@p3", mskdg.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarılı Şekilde Güncellendi");
            uyeler();
            reset();
        }

        private void label8_Click(object sender, EventArgs e)
        {

            Form1 FRM = new Form1();
            FRM.Show();
            this.Hide();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 FRM = new Form1();
            FRM.Show();
            this.Hide();
        }
    }
}
