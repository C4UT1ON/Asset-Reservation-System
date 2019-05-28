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
    public partial class CreateAsset : Form
    {
        //constructor
        public CreateAsset()
        {
            //built in method
            InitializeComponent();
        }

        //validate form and create record
        private void createAsset_button_Click(object sender, EventArgs e)
        {

            if(assetName_textBox.Text.Trim().Equals("") || assetId_textBox.Text.Trim().Equals("") || assetDescription_textBox.Text.Trim().Equals(""))
            {
                MessageBox.Show(this, "Please fill in all required details");
            }
            else
            {
                //creating object
                BusinessLayer.Asset asset = new BusinessLayer.Asset()
                {
                    Asset_id = assetId_textBox.Text,
                    Asset_name = assetName_textBox.Text,
                    Asset_description = assetDescription_textBox.Text,
                    asset_status = "Available",
                    asset_type = "normal"
                };

                //check if record was saved properly
                BusinessLayer.Classes.InventoryUtil Utils = new BusinessLayer.Classes.InventoryUtil();
                if (Utils.newAsset(asset))
                {
                    this.Close();
                }
            }
        }

        //close form
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AssetForm_Load(object sender, EventArgs e)
        {

        }
    }
}
