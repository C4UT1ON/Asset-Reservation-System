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
    public partial class CreateReservation : Form
    {
        //constructor
        public CreateReservation()
        {
            //built in method
            InitializeComponent();
        }

        // method to validate form and save record
        private void reserve_button_Click(object sender, EventArgs e)
        {
            BusinessLayer.Reservation reservation = new BusinessLayer.Reservation();
            reservation.Reservation_start = startDate_picker.Value.Date+startTime_picker.Value.TimeOfDay;
            reservation.Reservation_end = endDate_picker.Value.Date + endTime_picker.Value.TimeOfDay;
            reservation.Asset_AssetId = assetName_comboBox.SelectedItem.ToString();

            if (BusinessLayer.Classes.InventoryUtil.newReservation(reservation))
            {
                this.Dispose();
            }
            //MessageBox.Show(reservation.Reservation_start.ToString());

        }

        //populate combo box with list of assets from database
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            BusinessLayer.Classes.InventoryUtil.getAssets(assetName_comboBox);
        }

        //to close form
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
