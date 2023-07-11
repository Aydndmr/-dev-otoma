using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AydemirOto.DL
{
    public static class datalayer
    {
          static MySqlConnection conn = new MySqlConnection(
               new MySqlConnectionStringBuilder()
               {
                   Server = "127.0.0.1",
                   Database = "Ödevv",
                   UserID = "root",
                   Password = "Aydndmr27.",
               }.ConnectionString
             );
        public static int  Musteriekle(Musteri m )
        {
            try
            {
                if(conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("aydemir_musteriler", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.Id);
                komut.Parameters.AddWithValue("@ad",m.ad );
                komut.Parameters.AddWithValue("@soy", m.soyad);
                komut.Parameters.AddWithValue("@tel", m.telefon);
                komut.Parameters.AddWithValue("@adr", m.adres);
                komut.Parameters.AddWithValue("@mail", m.mail);
               
                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch(Exception)
            { 
            }
            finally 
            {
                if(conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }

            return -1; 
        }
    }
}
