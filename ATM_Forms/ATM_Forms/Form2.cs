using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM_Forms.Entities;

namespace ATM_Forms
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public List<Logins> LoginsList = new List<Logins>();

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btn_SubmitRegister_Click(object sender, EventArgs e)
        {

            string nameTxtBoxR = txt_NameRegister.Text;
            string IDTxtBoxR = txt_IDRegister.Text;
            string PasswordTxtBoxR = txt_PasswordRegister.Text;
            string AddressTxtBoxR = txt_AddressRegister.Text;

            if (string.IsNullOrEmpty(nameTxtBoxR) || string.IsNullOrEmpty(IDTxtBoxR)
                || string.IsNullOrEmpty(PasswordTxtBoxR) || string.IsNullOrEmpty(AddressTxtBoxR))
            {
                MessageBox.Show("There's empty blanks!");
            }
            else
            {
                var random = new Random();
                int randAccount= random.Next(1000, 9999);

                LoginsList.Add(new Logins(nameTxtBoxR, IDTxtBoxR, PasswordTxtBoxR, AddressTxtBoxR, randAccount.ToString()));

                form1.Show();
                this.Hide();

                string message = string.Join(Environment.NewLine, LoginsList); //Exibe a lista em uma MessageBox.
                MessageBox.Show(message, "List Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_CleanRegister_Click(object sender, EventArgs e)
        {
            txt_NameRegister.Text = "";
            txt_IDRegister.Text = "";
            txt_PasswordRegister.Text = "";
            txt_AddressRegister.Text = "";
        }

        private void btn_BackRegister_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
}
