namespace InventoryFinal.Assets
{
    partial class ViewAsset
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
            this.assetID_txt = new System.Windows.Forms.TextBox();
            this.assetName_txt = new System.Windows.Forms.TextBox();
            this.assetDescription_txt = new System.Windows.Forms.TextBox();
            this.assetID_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assetID_txt
            // 
            this.assetID_txt.Enabled = false;
            this.assetID_txt.Location = new System.Drawing.Point(87, 11);
            this.assetID_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assetID_txt.Name = "assetID_txt";
            this.assetID_txt.Size = new System.Drawing.Size(132, 22);
            this.assetID_txt.TabIndex = 0;
            // 
            // assetName_txt
            // 
            this.assetName_txt.Enabled = false;
            this.assetName_txt.Location = new System.Drawing.Point(363, 11);
            this.assetName_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assetName_txt.Name = "assetName_txt";
            this.assetName_txt.Size = new System.Drawing.Size(132, 22);
            this.assetName_txt.TabIndex = 1;
            // 
            // assetDescription_txt
            // 
            this.assetDescription_txt.Enabled = false;
            this.assetDescription_txt.Location = new System.Drawing.Point(16, 78);
            this.assetDescription_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assetDescription_txt.Multiline = true;
            this.assetDescription_txt.Name = "assetDescription_txt";
            this.assetDescription_txt.Size = new System.Drawing.Size(479, 181);
            this.assetDescription_txt.TabIndex = 2;
            // 
            // assetID_label
            // 
            this.assetID_label.AutoSize = true;
            this.assetID_label.Location = new System.Drawing.Point(16, 15);
            this.assetID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assetID_label.Name = "assetID_label";
            this.assetID_label.Size = new System.Drawing.Size(60, 17);
            this.assetID_label.TabIndex = 3;
            this.assetID_label.Text = "Asset ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asset Name";
            // 
            // Edit_btn
            // 
            this.Edit_btn.Location = new System.Drawing.Point(204, 278);
            this.Edit_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(100, 28);
            this.Edit_btn.TabIndex = 5;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(312, 278);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(100, 28);
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(122, 281);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // ViewAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 324);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assetID_label);
            this.Controls.Add(this.assetDescription_txt);
            this.Controls.Add(this.assetName_txt);
            this.Controls.Add(this.assetID_txt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewAsset";
            this.Text = "ViewAsset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox assetID_txt;
        private System.Windows.Forms.TextBox assetName_txt;
        private System.Windows.Forms.TextBox assetDescription_txt;
        private System.Windows.Forms.Label assetID_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button save_btn;
    }
}