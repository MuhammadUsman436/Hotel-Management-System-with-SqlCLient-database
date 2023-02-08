using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project2
{
    public partial class CustomerRegisteration : Form
    {
        function fn = new function();
        string query;
        public CustomerRegisteration()
        {
            InitializeComponent();
        }


private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
          string query = "Select roomNo From room where bed=@bed and roomType=@roomType and booked='No'";
            string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Databasenew;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@bed", txtBed.Text);
                cmd.Parameters.AddWithValue("@roomType", txtRoom.Text);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtRoomNo.Items.Add(reader["roomNo"]);
                    }
                }
            }
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
        }

        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "Select Price,roomid from room where roomNo=@roomNo";
            string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Databasenew;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionstring);
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@roomNo", txtRoomNo.Text);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtPrice.Text = reader["Price"].ToString();
                        rid = int.Parse(reader["roomid"].ToString());

                    }
                }
            }
        }



        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != " " && txtContact.Text != "" && txtNationality.Text != " " && txtGender.Text != "" && txtDob.Text != " " && txtPrice.Text != "" && txtCnic.Text != " " && txtAddress.Text != "" && txtCheckIn.Text != "")
            {
                string name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                string national = txtNationality.Text;
                string gender = txtGender.Text;
                string dob = txtDob.Text;
                string cnic = txtDob.Text;
                string address = txtAddress.Text;
                string checkin = txtCheckIn.Text;
               
                string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Databasenew;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                query = "Insert INTO customer(cname,mobile,nationality,gender,dob,cnic,address,checkin,roomid) Values(@name,@mobile,@national,@gender,@dob,@cnic,@address,@checkin,@rid)     UPDATE room set booked='Yes' where roomNo=(@roomNo)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@national", national); 
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@cnic", cnic);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@checkin", checkin);
                    cmd.Parameters.AddWithValue("@rid", rid);
                    cmd.Parameters.AddWithValue("@roomNo", txtRoomNo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room No " + txtRoomNo.Text + "Allocatio succeful.");
                    connection.Close();
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("All fileld are mandatory", "information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ClearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtCnic.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }

        private void CustomerRegisteration_Load(object sender, EventArgs e)
        {

        }
    }
}






   
           
        
        
       

        

    