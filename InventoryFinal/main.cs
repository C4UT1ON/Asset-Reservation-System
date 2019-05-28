using InventoryFinal.Reservations;
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
    public partial class mainWindow : Form
    {
        // constructor of main window form, used to render the controls and windows to be displayed
        public mainWindow()
        {
            InitializeComponent(); // built in method

            //creating and displaying the login form
            Login login = null;
            //null assigment and if statement used to ensure no instance of the class is currently in use
            if (login == null || login.IsDisposed)
            {
                login = new Login();
                login.ControlBox = false;
                login.MdiParent = this;
                //object method call
                login.Show();
                
                
                
                
            }
        }

        //non-static user defined method to create and display Asset form
        private void resourceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //null assigment and if statement used to ensure no instance of the class is currently in use
            CreateAsset asset=null;
            if(asset == null|| asset.IsDisposed)
            {
                //creating and displaying the login form
                asset = new CreateAsset();
                asset.MdiParent = this;
                //object method call
                asset.Show();
                asset.Focus();
            }            
        }


        //non-static user defined method to create and display Reservation form
        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //null assigment and if statement used to ensure no instance of the class is currently in use
            CreateReservation reserve = null;
            if(reserve == null || reserve.IsDisposed)
            {
                //creating and displaying the login form
                reserve = new CreateReservation();
                reserve.MdiParent = this;
                //object method call
                reserve.Show();
            }            
        }

        //non-static user defined method to exit the program
        private void exit_fileMenu_Click(object sender, EventArgs e)
        {
            //object method call
            this.Dispose();
        }

        //non-static user defined method to create and display User form
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //null assigment and if statement used to ensure no instance of the class is currently in use
            CreateUser user = null;
            if (user == null || user.IsDisposed)
            {
                //creating and displaying the login form
                user = new CreateUser();
                user.MdiParent = this;
                //object method call
                user.Show();
            }
        }

        private void assets_viewMenu_Click(object sender, EventArgs e)
        {
            DisplayAssets viewAssets = new DisplayAssets();
            viewAssets.MdiParent = this;
            viewAssets.Show();
        }

        private void reservations_viewMenu_Click(object sender, EventArgs e)
        {
            DisplayReservations viewReservation = new DisplayReservations();
            viewReservation.MdiParent = this;
            viewReservation.Show();


        }
    }
}
