using ATM_Forms.Entities;

namespace ATM_Forms
{
    public partial class Form1 : Form
    {
        Form2 form2;

        public Form1()
        {
            form2 = new Form2(this);
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var list = form2.LoginsList;

            var register = list.Where(x => x.Account == txt_Account.Text).FirstOrDefault();

            bool CheckAccount = false;
            bool CheckPassword = false;

            if (register == null)
            {
                CheckAccount = false;
                MessageBox.Show("The account is not found!");
                return;
            }
            else if (register.Password != txt_Password.Text)
            {
                CheckPassword = false;
                MessageBox.Show("The password is wrong");
                return;
            }
            else
            {
                CheckAccount = true;
                CheckPassword = true;
            }
            if (CheckAccount == true && CheckPassword == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }

        }
    }
}