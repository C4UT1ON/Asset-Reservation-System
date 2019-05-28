using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryFinal.Assets
{
    public partial class ViewAsset : Form
    {
        public ViewAsset(BusinessLayer.Asset asset)
        {
            InitializeComponent();

            assetID_txt.Text = asset.Asset_id;
            assetName_txt.Text = asset.Asset_name;
            assetDescription_txt.Text = asset.Asset_description;
        }

         

       

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            assetID_txt.Enabled = true;
            assetName_txt.Enabled = true;
            assetDescription_txt.Enabled = true;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            BusinessLayer.Classes.InventoryUtil.editAsset(new BusinessLayer.Asset() {
                Asset_id = assetID_txt.Text,
                Asset_name = assetName_txt.Text,
                Asset_description = assetDescription_txt.Text                
            });
            this.Dispose();
            

        }
    }
}
