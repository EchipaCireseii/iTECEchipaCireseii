namespace iTEC_Cireseii
{
    partial class AdminPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyUserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.delightsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addDelightMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyDelightMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addDelightGroupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyDelightGroupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserGroupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyUserGroupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setUserGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWelcomeMesageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.registeredUsers = new System.Windows.Forms.Label();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersMenu,
            this.delightsMenu,
            this.groupsMenu,
            this.exportMenu,
            this.messageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersMenu
            // 
            this.usersMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserMenu,
            this.modifyUserMenu});
            this.usersMenu.Name = "usersMenu";
            this.usersMenu.Size = new System.Drawing.Size(47, 20);
            this.usersMenu.Text = "Users";
            // 
            // addUserMenu
            // 
            this.addUserMenu.Name = "addUserMenu";
            this.addUserMenu.Size = new System.Drawing.Size(138, 22);
            this.addUserMenu.Text = "Add User";
            this.addUserMenu.Click += new System.EventHandler(this.addUserMenu_Click);
            // 
            // modifyUserMenu
            // 
            this.modifyUserMenu.Name = "modifyUserMenu";
            this.modifyUserMenu.Size = new System.Drawing.Size(138, 22);
            this.modifyUserMenu.Text = "Modify User";
            this.modifyUserMenu.Click += new System.EventHandler(this.modifyUserMenu_Click);
            // 
            // delightsMenu
            // 
            this.delightsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDelightMenu,
            this.modifyDelightMenu});
            this.delightsMenu.Name = "delightsMenu";
            this.delightsMenu.Size = new System.Drawing.Size(62, 20);
            this.delightsMenu.Text = "Delights";
            // 
            // addDelightMenu
            // 
            this.addDelightMenu.Name = "addDelightMenu";
            this.addDelightMenu.Size = new System.Drawing.Size(153, 22);
            this.addDelightMenu.Text = "Add Delight";
            this.addDelightMenu.Click += new System.EventHandler(this.addDelightMenu_Click);
            // 
            // modifyDelightMenu
            // 
            this.modifyDelightMenu.Name = "modifyDelightMenu";
            this.modifyDelightMenu.Size = new System.Drawing.Size(153, 22);
            this.modifyDelightMenu.Text = "Modify Delight";
            this.modifyDelightMenu.Click += new System.EventHandler(this.modifyDelightMenu_Click);
            // 
            // groupsMenu
            // 
            this.groupsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDelightGroupMenu,
            this.modifyDelightGroupMenu,
            this.addUserGroupMenu,
            this.modifyUserGroupMenu,
            this.setUserGroupsToolStripMenuItem});
            this.groupsMenu.Name = "groupsMenu";
            this.groupsMenu.Size = new System.Drawing.Size(57, 20);
            this.groupsMenu.Text = "Groups";
            // 
            // addDelightGroupMenu
            // 
            this.addDelightGroupMenu.Name = "addDelightGroupMenu";
            this.addDelightGroupMenu.Size = new System.Drawing.Size(194, 22);
            this.addDelightGroupMenu.Text = "Add Delight Groups";
            this.addDelightGroupMenu.Click += new System.EventHandler(this.addDelightGroupMenu_Click);
            // 
            // modifyDelightGroupMenu
            // 
            this.modifyDelightGroupMenu.Name = "modifyDelightGroupMenu";
            this.modifyDelightGroupMenu.Size = new System.Drawing.Size(194, 22);
            this.modifyDelightGroupMenu.Text = "Modify Delight Groups";
            this.modifyDelightGroupMenu.Click += new System.EventHandler(this.modifyDelightGroupMenu_Click);
            // 
            // addUserGroupMenu
            // 
            this.addUserGroupMenu.Name = "addUserGroupMenu";
            this.addUserGroupMenu.Size = new System.Drawing.Size(194, 22);
            this.addUserGroupMenu.Text = "Add User Groups";
            this.addUserGroupMenu.Click += new System.EventHandler(this.addUserGroupMenu_Click);
            // 
            // modifyUserGroupMenu
            // 
            this.modifyUserGroupMenu.Name = "modifyUserGroupMenu";
            this.modifyUserGroupMenu.Size = new System.Drawing.Size(194, 22);
            this.modifyUserGroupMenu.Text = "Modify User Groups";
            this.modifyUserGroupMenu.Click += new System.EventHandler(this.modifyUserGroupMenu_Click);
            // 
            // setUserGroupsToolStripMenuItem
            // 
            this.setUserGroupsToolStripMenuItem.Name = "setUserGroupsToolStripMenuItem";
            this.setUserGroupsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.setUserGroupsToolStripMenuItem.Text = "Set User Groups";
            this.setUserGroupsToolStripMenuItem.Click += new System.EventHandler(this.setUserGroupsToolStripMenuItem_Click);
            // 
            // exportMenu
            // 
            this.exportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelMenu});
            this.exportMenu.Name = "exportMenu";
            this.exportMenu.Size = new System.Drawing.Size(52, 20);
            this.exportMenu.Text = "Export";
            // 
            // exportToExcelMenu
            // 
            this.exportToExcelMenu.Name = "exportToExcelMenu";
            this.exportToExcelMenu.Size = new System.Drawing.Size(150, 22);
            this.exportToExcelMenu.Text = "Export to Excel";
            this.exportToExcelMenu.Click += new System.EventHandler(this.exportToExcelMenu_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWelcomeMesageToolStripMenuItem});
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.messageToolStripMenuItem.Text = "Message";
            // 
            // newWelcomeMesageToolStripMenuItem
            // 
            this.newWelcomeMesageToolStripMenuItem.Name = "newWelcomeMesageToolStripMenuItem";
            this.newWelcomeMesageToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newWelcomeMesageToolStripMenuItem.Text = "New Welcome Mesage";
            this.newWelcomeMesageToolStripMenuItem.Click += new System.EventHandler(this.newWelcomeMesageToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registered Users :";
            // 
            // registeredUsers
            // 
            this.registeredUsers.AutoSize = true;
            this.registeredUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registeredUsers.Location = new System.Drawing.Point(146, 35);
            this.registeredUsers.Name = "registeredUsers";
            this.registeredUsers.Size = new System.Drawing.Size(0, 21);
            this.registeredUsers.TabIndex = 3;
            // 
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(8, 139);
            this.pieChart.Name = "pieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Votes";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(476, 280);
            this.pieChart.TabIndex = 5;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 431);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.registeredUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdminPage";
            this.Text = "Admin Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_FormClosing);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersMenu;
        private System.Windows.Forms.ToolStripMenuItem addUserMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyUserMenu;
        private System.Windows.Forms.ToolStripMenuItem delightsMenu;
        private System.Windows.Forms.ToolStripMenuItem groupsMenu;
        private System.Windows.Forms.ToolStripMenuItem addDelightGroupMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyDelightGroupMenu;
        private System.Windows.Forms.ToolStripMenuItem exportMenu;
        private System.Windows.Forms.ToolStripMenuItem addDelightMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyDelightMenu;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelMenu;
        private System.Windows.Forms.ToolStripMenuItem addUserGroupMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyUserGroupMenu;
        private System.Windows.Forms.ToolStripMenuItem setUserGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWelcomeMesageToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label registeredUsers;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;

    }
}