using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryFinal
{
    public partial class CreateUser : Form
    {
        // constructor for form class
        public CreateUser()
        {
            //built in methods
            InitializeComponent();
        }



        //event method for form validation and to save record
        private void button1_Click(object sender, EventArgs e)
        {
            if (firstName_textbox.TextLength < 3 || lastName_textBox.TextLength < 3)
            {
                MessageBox.Show(this, "Invalid entry for name");
            }
            else if (username_textbox.TextLength < 3)
            {
                MessageBox.Show(this, "Username must be at least 3 charachters long");
            }
            else if ((pw_textbox.Text.Trim() != pw2_textbox.Text.Trim()) && pw_textbox.Text.Trim().Length != 0)
            {
                MessageBox.Show(this, "Passwords must match");
            }
            else
            {
                BusinessLayer.User user = new BusinessLayer.User()
                {
                    User_firstname = firstName_textbox.Text,
                    User_lastname = lastName_textBox.Text,
                    User_username = username_textbox.Text,
                    User_password = pw_textbox.Text

                };
                //bject method calling
                BusinessLayer.Classes.InventoryUtil utils = new BusinessLayer.Classes.InventoryUtil();
                utils.createUser(user);
                MessageBox.Show(this, "User created");
                this.Close();
            }
        }

        // to exit the programme
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            //calling the static method
            BusinessLayer.Classes.InventoryUtil.reset(this);
        }
    }    
}

