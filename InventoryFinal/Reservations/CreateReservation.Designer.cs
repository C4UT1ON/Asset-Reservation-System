namespace InventoryFinal
{
    partial class CreateReservation
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
            this.assetName_label = new System.Windows.Forms.Label();
            this.assetName_comboBox = new System.Windows.Forms.ComboBox();
            this.reserve_button = new System.Windows.Forms.Button();
            this.startDate_picker = new System.Windows.Forms.DateTimePicker();
            this.startTime_picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.endDate_picker = new System.Windows.Forms.DateTimePicker();
            this.endTime_picker = new System.Windows.Forms.DateTimePicker();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assetName_label
            // 
            this.assetName_label.AutoSize = true;
            this.assetName_label.Location = new System.Drawing.Point(13, 13);
            this.assetName_label.Name = "assetName_label";
            this.assetName_label.Size = new System.Drawing.Size(33, 13);
            this.assetName_label.TabIndex = 0;
            this.assetName_label.Text = "Asset";
            // 
            // assetName_comboBox
            // 
            this.assetName_comboBox.FormattingEnabled = true;
            this.assetName_comboBox.Location = new System.Drawing.Point(53, 13);
            this.assetName_comboBox.Name = "assetName_comboBox";
            this.assetName_comboBox.Size = new System.Drawing.Size(121, 21);
            this.assetName_comboBox.TabIndex = 1;
            // 
            // reserve_button
            // 
            this.reserve_button.Location = new System.Drawing.Point(244, 292);
            this.reserve_button.Name = "reserve_button";
            this.reserve_button.Size = new System.Drawing.Size(75, 23);
            this.reserve_button.TabIndex = 6;
            this.reserve_button.Text = "Reserve";
            this.reserve_button.UseVisualStyleBackColor = true;
            this.reserve_button.Click += new System.EventHandler(this.reserve_button_Click);
            // 
            // startDate_picker
            // 
            this.startDate_picker.Location = new System.Drawing.Point(37, 96);
            this.startDate_picker.Name = "startDate_picker";
            this.startDate_picker.Size = new System.Drawing.Size(200, 20);
            this.startDate_picker.TabIndex = 9;
            // 
            // startTime_picker
            // 
            this.startTime_picker.CustomFormat = "HH:mm:ss";
            this.startTime_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime_picker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startTime_picker.Location = new System.Drawing.Point(243, 96);
            this.startTime_picker.Name = "startTime_picker";
            this.startTime_picker.ShowUpDown = true;
            this.startTime_picker.Size = new System.Drawing.Size(115, 20);
            this.startTime_picker.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "To";
            // 
            // endDate_picker
            // 
            this.endDate_picker.Location = new System.Drawing.Point(37, 190);
            this.endDate_picker.Name = "endDate_picker";
            this.endDate_picker.Size = new System.Drawing.Size(200, 20);
            this.endDate_picker.TabIndex = 15;
            // 
            // endTime_picker
            // 
            this.endTime_picker.CustomFormat = "HH:mm:ss";
            this.endTime_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTime_picker.Location = new System.Drawing.Point(244, 190);
            this.endTime_picker.Name = "endTime_picker";
            this.endTime_picker.ShowUpDown = true;
            this.endTime_picker.Size = new System.Drawing.Size(114, 20);
            this.endTime_picker.TabIndex = 16;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(150, 292);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 17;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 327);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.endTime_picker);
            this.Controls.Add(this.endDate_picker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startTime_picker);
            this.Controls.Add(this.startDate_picker);
            this.Controls.Add(this.reserve_button);
            this.Controls.Add(this.assetName_comboBox);
            this.Controls.Add(this.assetName_label);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label assetName_label;
        private System.Windows.Forms.ComboBox assetName_comboBox;
        private System.Windows.Forms.Button reserve_button;
        private System.Windows.Forms.DateTimePicker startDate_picker;
        private System.Windows.Forms.DateTimePicker startTime_picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDate_picker;
        private System.Windows.Forms.DateTimePicker endTime_picker;
        private System.Windows.Forms.Button exit_btn;
    }
}





