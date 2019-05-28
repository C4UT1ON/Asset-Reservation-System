namespace InventoryFinal
{
    partial class CreateUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstName_textbox = new System.Windows.Forms.TextBox();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pw_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pw2_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // firstName_textbox
            // 
            this.firstName_textbox.Location = new System.Drawing.Point(158, 34);
            this.firstName_textbox.Name = "firstName_textbox";
            this.firstName_textbox.Size = new System.Drawing.Size(100, 20);
            this.firstName_textbox.TabIndex = 1;
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Location = new System.Drawing.Point(158, 73);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(100, 20);
            this.lastName_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // pw_textbox
            // 
            this.pw_textbox.Location = new System.Drawing.Point(158, 150);
            this.pw_textbox.Name = "pw_textbox";
            this.pw_textbox.PasswordChar = '*';
            this.pw_textbox.Size = new System.Drawing.Size(100, 20);
            this.pw_textbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(158, 111);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(100, 20);
            this.username_textbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // pw2_textbox
            // 
            this.pw2_textbox.Location = new System.Drawing.Point(158, 187);
            this.pw2_textbox.Name = "pw2_textbox";
            this.pw2_textbox.PasswordChar = '*';
            this.pw2_textbox.Size = new System.Drawing.Size(100, 20);
            this.pw2_textbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirm Password";
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(215, 263);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(75, 23);
            this.create_btn.TabIndex = 10;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(53, 263);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 11;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(134, 263);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 12;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 298);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.pw2_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pw_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName_textbox);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName_textbox;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pw_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pw2_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button reset_btn;
    }
}