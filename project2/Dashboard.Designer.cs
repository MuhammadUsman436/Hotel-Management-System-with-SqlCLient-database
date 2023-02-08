namespace project2
{
    partial class Dashboard
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
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnCustomerDetail = new System.Windows.Forms.Button();
            this.btnCustomerRegistration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(30, 169);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(147, 106);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.Location = new System.Drawing.Point(418, 168);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(147, 107);
            this.btnCustomerDetail.TabIndex = 2;
            this.btnCustomerDetail.Text = "Customer Checkout";
            this.btnCustomerDetail.UseVisualStyleBackColor = true;
            this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.Location = new System.Drawing.Point(226, 168);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.Size = new System.Drawing.Size(147, 107);
            this.btnCustomerRegistration.TabIndex = 4;
            this.btnCustomerRegistration.Text = "Customer Registration";
            this.btnCustomerRegistration.UseVisualStyleBackColor = true;
            this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 106);
            this.button1.TabIndex = 5;
            this.button1.Text = "Customer Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCustomerRegistration);
            this.Controls.Add(this.btnCustomerDetail);
            this.Controls.Add(this.btnAddRoom);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddRoom;
        private Button btnCustomerDetail;
        private Button btnCustomerRegistration;
        private Button button1;
        private Label label1;
    }
}