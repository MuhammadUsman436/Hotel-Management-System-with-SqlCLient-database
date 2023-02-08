using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{

    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Databasenew;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return con;
        }
        public DataSet getData(string qurey) //gET DATA FROM Database
        {
            SqlConnection con = getConnection();
            // SqlCommand cmd = new SqlCommand();
            // cmd.Connection = con;
            // cmd.CommandText = qurey;
            SqlDataAdapter da = new SqlDataAdapter(qurey, con);
            DataSet ds = new DataSet();




            da.Fill(ds);



            return ds;
        }
        public void setData(string query, string message) //INSERTION DELETION AND UBDATION
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("'" + message + "'", "Succss", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public SqlDataReader getForCombo(string query)
        {
           SqlConnection con  = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open(); 
            cmd= new SqlCommand(query ,con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

    }
}
