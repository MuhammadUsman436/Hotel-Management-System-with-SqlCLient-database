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
    public partial class ViewCustomerDetails : Form
    {
        function fn = new function();
        string query;
        public ViewCustomerDetails()
        {
            InitializeComponent();
        }

        private void ViewCustomerDetails_Load(object sender, EventArgs e)
        {  
             string   query=" Select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender, customer.dob,customer.cnic,customer.address,customer.checkin,room.bed,room.price from customer inner join room on customer.roomid =room.roomid where checkout='NO'";
          DataSet ds=  fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        
        
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
         string   query = "Select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender, customer.dob,customer.cnic,customer.address,customer.checkin,room.bed,room.price from customer inner join room on customer.roomid =room.roomid where  cname like '" +txtName.Text+  " % ' and Chekout='NO'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text =dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        { 
            if(txtCName.Text !="")
            {
                if (MessageBox.Show("Are YOU sure ","Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
                    {
                      string  cdate=txtCheckOutDate.Text;
                string  query="update customer set chekout='YES',checkout'"+cdate +"' where cid=" +id+" update room set booked='NO' Where roomNo='"+txtRoom.Text+"'";
                    fn.setData(query,"Check out succefully ");
                    clearAll();
                 //   CustomerCheckOut_Load(this, null);


                }

            }
            else
            {
                MessageBox.Show("No Customer Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);            }

        }
        public void clearAll()
        {
            txtCName.Clear();
            txtRoom.Clear();
            txtName.Clear();
            txtCheckOutDate.ResetText();
        }
    }
   
   
}
