using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;


namespace InventoryFinal
{
    public partial class Login : Form
    {
        // constructor of the form, used to render the controls to be displayed
        public Login()
        {
            InitializeComponent();
        }

        //non-static user defined method validate user input
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //creation of object to be verified
            BusinessLayer.Classes.LoginAttempt attempt = new BusinessLayer.Classes.LoginAttempt(usernameTextbox.Text, passwordTextbox.Text);

            //boolean method used to validate input
            BusinessLayer.Classes. InventoryUtil utils = new BusinessLayer.Classes.InventoryUtil();
            if (utils.loginAttempt(attempt))
            {
                
                this.Close();
            }
            else // error message if validation returns flase
            {
                MessageBox.Show(this,"invalid credentials");
            }

        }

        //enables the menu bar once login validation has been completed succesfully
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {            
            this.MdiParent.Controls.Find("menuBar", true).First().Enabled = true;          
        }
    }
}
