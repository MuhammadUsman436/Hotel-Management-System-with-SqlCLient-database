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

namespace project2
{


    public partial class AllUserControl : Form
    {
        function fn = new function();
        string query;
        public AllUserControl()
        {
            InitializeComponent();
        }
        private void AllUserControl_Load(object sender, EventArgs e) //diplay data in gridview1
        {
            query = "Select * from room";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Databasenew;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
          
            SqlConnection conn = new SqlConnection(connectionstring);
           conn.Open();
          
                if (txtRoomNumber.Text != "" && txtType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
                {
                    string roomno = txtRoomNumber.Text;
                    string type = txtType.Text;
                    string bed = txtBed.Text;
                    Int64 price = Int64.Parse(txtPrice.Text);
                    query = "INSERT INTO room(roomNo,roomType,Bed,price,booked) VALUES(@roomno, @type, @bed, @price, 'true')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomno", roomno);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@bed", bed);
                        cmd.Parameters.AddWithValue("@price", price);

                        cmd.ExecuteNonQuery();
                    }

                    fn.setData(query, "Room Added");
                    AllUserControl_Load(this, null);
                    ClearAll();
                conn.Close();
                }
        }

        private void ClearAll()
        {
            txtRoomNumber.Clear();
            txtBed.SelectedIndex = -1;
            txtType.SelectedIndex = -1;
            txtPrice.Clear();
        }

     
    }
}

        
    
