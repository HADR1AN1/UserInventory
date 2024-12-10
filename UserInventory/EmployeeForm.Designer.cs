namespace UserInventory
{
    partial class EmployeeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editInvBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(151, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 116);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // adminName
            // 
            this.adminName.AutoSize = true;
            this.adminName.Location = new System.Drawing.Point(206, 8);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(63, 13);
            this.adminName.TabIndex = 9;
            this.adminName.Text = "Placeholder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome";
            // 
            // editInvBtn
            // 
            this.editInvBtn.Location = new System.Drawing.Point(12, 12);
            this.editInvBtn.Name = "editInvBtn";
            this.editInvBtn.Size = new System.Drawing.Size(114, 23);
            this.editInvBtn.TabIndex = 11;
            this.editInvBtn.Text = "EDIT INVENTORY";
            this.editInvBtn.UseVisualStyleBackColor = true;
            this.editInvBtn.Click += new System.EventHandler(this.editInvBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(12, 117);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(66, 23);
            this.logoutBtn.TabIndex = 12;
            this.logoutBtn.Text = "LOGOUT";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 152);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.editInvBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminName);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeForm";
            this.Text = "Employee Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label adminName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editInvBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}