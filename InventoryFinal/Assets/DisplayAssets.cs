using InventoryFinal.Assets;
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
    public partial class DisplayAssets : Form
    {
        public DisplayAssets()
        {
            InitializeComponent();
        }

        private void AssetList_Load(object sender, EventArgs e)
        {
            asset_dataGridView.DataSource = BusinessLayer.Classes.InventoryUtil.getAssetDataSource();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = asset_dataGridView.Rows[asset_dataGridView.SelectedRows[0].Index];
            DataGridViewCell cell = row.Cells[0];
            string selectedAsset = cell.Value.ToString();
            
            ViewAsset view = new ViewAsset(BusinessLayer.Classes.InventoryUtil.GetAsset(selectedAsset));
            view.ShowDialog();


        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = asset_dataGridView.Rows[asset_dataGridView.SelectedRows[0].Index];
            DataGridViewCell cell = row.Cells[0];
            string selectedAsset = cell.Value.ToString();

            BusinessLayer.Classes.InventoryUtil.DeleteAsset(selectedAsset);

            asset_dataGridView.DataSource = BusinessLayer.Classes.InventoryUtil.getAssetDataSource();
            asset_dataGridView.Refresh();
        }

    }
}
