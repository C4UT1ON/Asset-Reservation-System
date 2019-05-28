namespace InventoryFinal
{
    partial class CreateAsset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.assetId_label = new System.Windows.Forms.Label();
            this.assetId_textBox = new System.Windows.Forms.TextBox();
            this.assetDescription_textBox = new System.Windows.Forms.TextBox();
            this.assetDescription_Label = new System.Windows.Forms.Label();
            this.createAsset_button = new System.Windows.Forms.Button();
            this.assetName_label = new System.Windows.Forms.Label();
            this.assetName_textBox = new System.Windows.Forms.TextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assetId_label
            // 
            this.assetId_label.AutoSize = true;
            this.assetId_label.Location = new System.Drawing.Point(12, 9);
            this.assetId_label.Name = "assetId_label";
            this.assetId_label.Size = new System.Drawing.Size(47, 13);
            this.assetId_label.TabIndex = 0;
            this.assetId_label.Text = "Asset ID";
            // 
            // assetId_textBox
            // 
            this.assetId_textBox.Location = new System.Drawing.Point(65, 6);
            this.assetId_textBox.Name = "assetId_textBox";
            this.assetId_textBox.Size = new System.Drawing.Size(100, 20);
            this.assetId_textBox.TabIndex = 1;
            // 
            // assetDescription_textBox
            // 
            this.assetDescription_textBox.Location = new System.Drawing.Point(15, 83);
            this.assetDescription_textBox.Multiline = true;
            this.assetDescription_textBox.Name = "assetDescription_textBox";
            this.assetDescription_textBox.Size = new System.Drawing.Size(395, 171);
            this.assetDescription_textBox.TabIndex = 2;
            // 
            // assetDescription_Label
            // 
            this.assetDescription_Label.AutoSize = true;
            this.assetDescription_Label.Location = new System.Drawing.Point(17, 64);
            this.assetDescription_Label.Name = "assetDescription_Label";
            this.assetDescription_Label.Size = new System.Drawing.Size(60, 13);
            this.assetDescription_Label.TabIndex = 3;
            this.assetDescription_Label.Text = "Description";
            // 
            // createAsset_button
            // 
            this.createAsset_button.Location = new System.Drawing.Point(257, 269);
            this.createAsset_button.Name = "createAsset_button";
            this.createAsset_button.Size = new System.Drawing.Size(75, 23);
            this.createAsset_button.TabIndex = 4;
            this.createAsset_button.Text = "Create";
            this.createAsset_button.UseVisualStyleBackColor = true;
            this.createAsset_button.Click += new System.EventHandler(this.createAsset_button_Click);
            // 
            // assetName_label
            // 
            this.assetName_label.AutoSize = true;
            this.assetName_label.Location = new System.Drawing.Point(237, 6);
            this.assetName_label.Name = "assetName_label";
            this.assetName_label.Size = new System.Drawing.Size(64, 13);
            this.assetName_label.TabIndex = 5;
            this.assetName_label.Text = "Asset Name";
            // 
            // assetName_textBox
            // 
            this.assetName_textBox.Location = new System.Drawing.Point(308, 6);
            this.assetName_textBox.Name = "assetName_textBox";
            this.assetName_textBox.Size = new System.Drawing.Size(100, 20);
            this.assetName_textBox.TabIndex = 6;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(166, 269);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // AssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 304);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.assetName_textBox);
            this.Controls.Add(this.assetName_label);
            this.Controls.Add(this.createAsset_button);
            this.Controls.Add(this.assetDescription_Label);
            this.Controls.Add(this.assetDescription_textBox);
            this.Controls.Add(this.assetId_textBox);
            this.Controls.Add(this.assetId_label);
            this.Name = "AssetForm";
            this.Text = "AssetForm";
            this.Load += new System.EventHandler(this.AssetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label assetId_label;
        private System.Windows.Forms.TextBox assetId_textBox;
        private System.Windows.Forms.TextBox assetDescription_textBox;
        private System.Windows.Forms.Label assetDescription_Label;
        private System.Windows.Forms.Button createAsset_button;
        private System.Windows.Forms.Label assetName_label;
        private System.Windows.Forms.TextBox assetName_textBox;
        private System.Windows.Forms.Button exit_btn;
    }
}