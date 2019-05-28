namespace InventoryFinal
{
    partial class DisplayAssets
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
            this.asset_dataGridView = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.asset_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // asset_dataGridView
            // 
            this.asset_dataGridView.AllowUserToAddRows = false;
            this.asset_dataGridView.AllowUserToDeleteRows = false;
            this.asset_dataGridView.AllowUserToResizeRows = false;
            this.asset_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asset_dataGridView.Location = new System.Drawing.Point(16, 15);
            this.asset_dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.asset_dataGridView.MultiSelect = false;
            this.asset_dataGridView.Name = "asset_dataGridView";
            this.asset_dataGridView.ReadOnly = true;
            this.asset_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.asset_dataGridView.Size = new System.Drawing.Size(485, 325);
            this.asset_dataGridView.TabIndex = 0;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(87, 375);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(100, 28);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(195, 375);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(100, 28);
            this.edit_btn.TabIndex = 2;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(303, 375);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(100, 28);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AssetList_Load);
            // 
            // DisplayAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.asset_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisplayAssets";
            this.Text = "AssetList";
            this.Load += new System.EventHandler(this.AssetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asset_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView asset_dataGridView;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button button1;
    }
}