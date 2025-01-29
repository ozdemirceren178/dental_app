using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=ceren\\SQLEXPRESS;Initial Catalog=Dentis;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
