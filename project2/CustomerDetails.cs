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
    public partial class CustomerDetails : Form
    {
        function fn = new function();
        string query;
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void txtsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtsearchby.SelectedIndex == 0)
            {
                query = " Select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender, customer.dob,customer.cnic,customer.address,customer.checkin,room.bed,room.price from customer inner join room on customer.roomid =room.roomid";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
    }
}
