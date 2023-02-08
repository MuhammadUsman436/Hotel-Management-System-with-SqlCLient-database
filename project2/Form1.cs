namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="usman" && txtPassword.Text == "0308") {
            lableError.Visible = false;
                Dashboard db= new Dashboard();
               // this.Hide();
                db.Show();
            }
            else
            {
                lableError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}