using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PassBox.v2
{
    internal class SqlBaglantisi
    {
        public SqlConnection Baglanti()
        {
            // YENİ BAĞLANTI CÜMLESİ 
            SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=PasswordManagement;Integrated Security=True;Encrypt=False");

            baglan.Open();
            return baglan;
        }
    }
}


