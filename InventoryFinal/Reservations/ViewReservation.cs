using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryFinal.Reservations
{
    public partial class ViewReservation : Form
    {
        public ViewReservation(BusinessLayer.Reservation reservation)
        {
            InitializeComponent();

            id_txt.Text = reservation.Reservation_id.ToString();
            dateTimePicker1.Value = reservation.Reservation_start.Date;
            dateTimePicker3.Value = reservation.Reservation_start;

            dateTimePicker2.Value = reservation.Reservation_end;
            dateTimePicker3.Value = reservation.Reservation_end;



        }

        private void save_btn_click(object sender, EventArgs e)
        {
            BusinessLayer.Classes.InventoryUtil.editReservation(new BusinessLayer.Reservation()
            {
                Reservation_id = Convert.ToInt32(id_txt.Text),
                Reservation_start = dateTimePicker1.Value.Date+dateTimePicker3.Value.TimeOfDay,
                Reservation_end = dateTimePicker2.Value.Date+dateTimePicker4.Value.TimeOfDay
            });
            this.Dispose();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            id_txt.Enabled = true;
            save_btn.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;
            dateTimePicker4.Enabled = true;
        }
    }
}
