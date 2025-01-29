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
    public partial class Reçete : Form
    {
        public Reçete()
        {
            InitializeComponent();
        }
        SqlBaglantisi sgl = new SqlBaglantisi();
        private void FillHasta()
        {
            SqlConnection bgl = sgl.baglanti();
            SqlCommand komut = new SqlCommand(" Select HastaAdSoyad from tblHastalar ", bgl);
            SqlDataReader rd;
            rd = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HastaAdSoyad", typeof(string));
            dt.Load(rd);
            cmbad.ValueMember = "HastaAdSoyad";
            cmbad.DataSource = dt;
            rd.Close();
            bgl.Close();
        }
        private void FillTedavi()
        {
            SqlConnection bgl = sgl.baglanti();
            SqlCommand komut = new SqlCommand(" select * From TblRandevu where HastaADSoyad= @p1", bgl);
            komut.Parameters.AddWithValue("@p1", cmbad.SelectedValue.ToString());
            komut.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dr1 = new SqlDataAdapter(komut);
            dr1.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                txttedavi.Text = dr["Tedavi"].ToString();
            }
           
            bgl.Close();
        }
        private void FillTutar()
        {
            SqlConnection bgl = sgl.baglanti();
            SqlCommand komut = new SqlCommand(" select * From TblTedavi where TedaviAd= @p1", bgl);
            komut.Parameters.AddWithValue("@p1", txttedavi.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter dr1 = new SqlDataAdapter(komut);
            dr1.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txttutar.Text = dr["TedaviTutar"].ToString();
            }

            bgl.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void Reçete_Load(object sender, EventArgs e)
        {
            FillHasta();
            uyeler();
            reset();
            
        }

        private void cmbad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillTedavi();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 FRM = new Form1();
            FRM.Show();
            this.Hide();
        }

        private void txttutar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txttedavi_TextChanged(object sender, EventArgs e)
        {
            FillTutar();
        }
        void uyeler()
        {
            Hasta ms = new Hasta();
            string query = " select * from TblRecete";
            DataSet ds = ms.ShowHasta(query);
            reçetegrid.DataSource = ds.Tables[0];
        }
        void filter()
        {
            Hasta ms = new Hasta();
            string query = " select * from TblRecete where HastaAdSoyad like '%"+txtreçete.Text+"%'";
            DataSet ds = ms.ShowHasta(query);
            reçetegrid.DataSource = ds.Tables[0];
        }
        void reset()
        {
            cmbad.Text = "";
            txttedavi.Text = " ";
            txttutar.Text = "";
            txtilac.Text = "";
            txtmiktar.Text = "";

        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnkayde_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblRecete (HastaADSoyad, TedaviAd,TedaviTutar, İlacAdı , İlacMiktar) values (@p1, @p2,@p3, @p4,@p5)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", cmbad.Text);
            komut.Parameters.AddWithValue("@p2", txttedavi.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(txttutar.Text));
            komut.Parameters.AddWithValue("@p4", txtilac.Text); 
            komut.Parameters.AddWithValue("@p5", txtmiktar.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarılı Şekilde Eklendi");
            uyeler();
            reset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int key = 0;
        private void reçetegrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            cmbad.Text = reçetegrid.SelectedRows[0].Cells[1].Value.ToString();
            txttedavi.Text = reçetegrid.SelectedRows[0].Cells[2].Value.ToString();
            txtilac.Text = reçetegrid.SelectedRows[0].Cells[3].Value.ToString();
            txttutar.Text = reçetegrid.SelectedRows[0].Cells[4].Value.ToString();
            txtmiktar.Text = reçetegrid.SelectedRows[0].Cells[5].Value.ToString();
            label7.Text= reçetegrid.SelectedRows[0].Cells[0].Value.ToString();


            if (txttedavi.Text == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(reçetegrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TblRecete where ReceteID=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", label7.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarılı Şekilde Silindi");
            uyeler();
            reset();
        }

        private void txtreçete_TextChanged(object sender, EventArgs e)
        {
           
        }
        Bitmap bitmap;
        private void btnyazdır_Click(object sender, EventArgs e)
        {
            int height = reçetegrid.Height;
            reçetegrid.Height = reçetegrid.RowCount * reçetegrid.RowTemplate.Height * 2;
            bitmap = new Bitmap(reçetegrid.Width, reçetegrid.Height);
            reçetegrid.DrawToBitmap(bitmap, new Rectangle(0,10, reçetegrid.Width, reçetegrid.Height));
            reçetegrid.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,0,0);
                
        }

        private void cmbad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtmiktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 FRM = new Form1();
            FRM.Show();
            this.Hide();
        }
    }
}
