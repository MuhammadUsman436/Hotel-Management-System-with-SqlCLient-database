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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
           AllUserControl ac = new AllUserControl();
            //this.Hide();
            ac.Show();
            
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            CustomerRegisteration cr = new CustomerRegisteration();
            cr.Show();

        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            ViewCustomerDetails vcd= new ViewCustomerDetails();
            vcd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerDetails d = new CustomerDetails();
            d.Show();
        }
    }
}
