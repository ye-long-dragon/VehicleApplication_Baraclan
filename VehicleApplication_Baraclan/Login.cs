using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace VehicleApplication_Baraclan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SalesPerson Vince = new SalesPerson("Vince Lawrence Baraclan","Sales","vlBaraclan", "101");

            if(true == Vince.validateLogin(txtUsername.Text.Trim(),txtUsername.Text))
            {

                string name = Vince.getFullName();
                string message = "Welcome " + name + " of Sales ";
                MessageBox.Show(message);
                Form1 newForm = new Form1();
                newForm.ShowDialog();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Please input a valid account", "Invalid Input");
            }

        }
    }
}
