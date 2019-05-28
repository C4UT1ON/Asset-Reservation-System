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
    public partial class DisplayReservations : Form
    {
        public DisplayReservations()
        {
            InitializeComponent();
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            reservation_list.DataSource = BusinessLayer.Classes.InventoryUtil.getReservationDataSource();
            reservation_list.Refresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedReservation = Convert.ToInt32(reservation_list.Rows[reservation_list.SelectedRows[0].Index].Cells[0].Value);
            BusinessLayer.Classes.InventoryUtil.DeleteReservation(selectedReservation);

            reservation_list.DataSource = BusinessLayer.Classes.InventoryUtil.getReservationDataSource();
            reservation_list.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedReservation = Convert.ToInt32(reservation_list.Rows[reservation_list.SelectedRows[0].Index].Cells[0].Value);
            ViewReservation view = new ViewReservation(BusinessLayer.Classes.InventoryUtil.GetReservation(Convert.ToInt32(reservation_list.Rows[reservation_list.SelectedRows[0].Index].Cells[0].Value)));
            view.ShowDialog();
        }
    }
}
