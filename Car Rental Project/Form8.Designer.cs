namespace Car_Rental_Project
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAdminPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNormalCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLuxuryCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkHistoryByBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkHistoryByCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberCancelReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminPanelToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.carToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 29);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminPanelToolStripMenuItem
            // 
            this.adminPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAdminToolStripMenuItem,
            this.updateAdminPasswordToolStripMenuItem});
            this.adminPanelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            this.adminPanelToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.adminPanelToolStripMenuItem.Text = "Admin ";
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.addAdminToolStripMenuItem.Text = "Add Admin";
            this.addAdminToolStripMenuItem.Click += new System.EventHandler(this.addAdminToolStripMenuItem_Click);
            // 
            // updateAdminPasswordToolStripMenuItem
            // 
            this.updateAdminPasswordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.updateAdminPasswordToolStripMenuItem.Name = "updateAdminPasswordToolStripMenuItem";
            this.updateAdminPasswordToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.updateAdminPasswordToolStripMenuItem.Text = "Update Admin Password";
            this.updateAdminPasswordToolStripMenuItem.Click += new System.EventHandler(this.updateAdminPasswordToolStripMenuItem_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNormalCarToolStripMenuItem,
            this.addLuxuryCarToolStripMenuItem,
            this.deleteCarToolStripMenuItem});
            this.carToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.carToolStripMenuItem.Text = "Car ";
            // 
            // addNormalCarToolStripMenuItem
            // 
            this.addNormalCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addNormalCarToolStripMenuItem.Name = "addNormalCarToolStripMenuItem";
            this.addNormalCarToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.addNormalCarToolStripMenuItem.Text = "Add Normal Car";
            this.addNormalCarToolStripMenuItem.Click += new System.EventHandler(this.addNormalCarToolStripMenuItem_Click);
            // 
            // addLuxuryCarToolStripMenuItem
            // 
            this.addLuxuryCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addLuxuryCarToolStripMenuItem.Name = "addLuxuryCarToolStripMenuItem";
            this.addLuxuryCarToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.addLuxuryCarToolStripMenuItem.Text = "Add Luxury Car";
            this.addLuxuryCarToolStripMenuItem.Click += new System.EventHandler(this.addLuxuryCarToolStripMenuItem_Click);
            // 
            // deleteCarToolStripMenuItem
            // 
            this.deleteCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteCarToolStripMenuItem.Name = "deleteCarToolStripMenuItem";
            this.deleteCarToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.deleteCarToolStripMenuItem.Text = "Delete Car";
            this.deleteCarToolStripMenuItem.Click += new System.EventHandler(this.deleteCarToolStripMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelReservationToolStripMenuItem,
            this.memberCancelReservationToolStripMenuItem});
            this.reservationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(125, 25);
            this.reservationToolStripMenuItem.Text = "Reservation";
            // 
            // cancelReservationToolStripMenuItem
            // 
            this.cancelReservationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cancelReservationToolStripMenuItem.Name = "cancelReservationToolStripMenuItem";
            this.cancelReservationToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.cancelReservationToolStripMenuItem.Text = "Cancel Reservation";
            this.cancelReservationToolStripMenuItem.Click += new System.EventHandler(this.cancelReservationToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkHistoryByBillToolStripMenuItem,
            this.checkHistoryByCarToolStripMenuItem});
            this.historyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // checkHistoryByBillToolStripMenuItem
            // 
            this.checkHistoryByBillToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkHistoryByBillToolStripMenuItem.Name = "checkHistoryByBillToolStripMenuItem";
            this.checkHistoryByBillToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.checkHistoryByBillToolStripMenuItem.Text = "Check History By Bill";
            this.checkHistoryByBillToolStripMenuItem.Click += new System.EventHandler(this.checkHistoryByBillToolStripMenuItem_Click);
            // 
            // checkHistoryByCarToolStripMenuItem
            // 
            this.checkHistoryByCarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkHistoryByCarToolStripMenuItem.Name = "checkHistoryByCarToolStripMenuItem";
            this.checkHistoryByCarToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.checkHistoryByCarToolStripMenuItem.Text = "Check History By Car";
            this.checkHistoryByCarToolStripMenuItem.Click += new System.EventHandler(this.checkHistoryByCarToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // memberCancelReservationToolStripMenuItem
            // 
            this.memberCancelReservationToolStripMenuItem.Name = "memberCancelReservationToolStripMenuItem";
            this.memberCancelReservationToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.memberCancelReservationToolStripMenuItem.Text = "Member Cancel Reservation";
            this.memberCancelReservationToolStripMenuItem.Click += new System.EventHandler(this.memberCancelReservationToolStripMenuItem_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 302);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form8";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAdminPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNormalCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLuxuryCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkHistoryByBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkHistoryByCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberCancelReservationToolStripMenuItem;
    }
}