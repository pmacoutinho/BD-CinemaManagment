﻿
namespace CinemaManagment
{
    partial class MainMenuManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuManager));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTickets = new System.Windows.Forms.Button();
            this.panelSessionsSubMenu = new System.Windows.Forms.Panel();
            this.buttonSessionInstances = new System.Windows.Forms.Button();
            this.buttonSessionList = new System.Windows.Forms.Button();
            this.buttonSessions = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonMovies = new System.Windows.Forms.Button();
            this.panelEmployeesSubmenu = new System.Windows.Forms.Panel();
            this.buttonManagers = new System.Windows.Forms.Button();
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonCleaningRecords = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelSessionsSubMenu.SuspendLayout();
            this.panelEmployeesSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.buttonLogOut);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.buttonTickets);
            this.panelSideMenu.Controls.Add(this.panelSessionsSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonSessions);
            this.panelSideMenu.Controls.Add(this.buttonRooms);
            this.panelSideMenu.Controls.Add(this.buttonMovies);
            this.panelSideMenu.Controls.Add(this.panelEmployeesSubmenu);
            this.panelSideMenu.Controls.Add(this.buttonEmployees);
            this.panelSideMenu.Controls.Add(this.buttonCleaningRecords);
            this.panelSideMenu.Controls.Add(this.buttonClients);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 553);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogOut.Location = new System.Drawing.Point(0, 632);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(229, 45);
            this.buttonLogOut.TabIndex = 21;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(0, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTickets
            // 
            this.buttonTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTickets.FlatAppearance.BorderSize = 0;
            this.buttonTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTickets.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTickets.Location = new System.Drawing.Point(0, 542);
            this.buttonTickets.Name = "buttonTickets";
            this.buttonTickets.Size = new System.Drawing.Size(229, 45);
            this.buttonTickets.TabIndex = 19;
            this.buttonTickets.Text = "Manage Tickets";
            this.buttonTickets.UseVisualStyleBackColor = true;
            this.buttonTickets.Click += new System.EventHandler(this.buttonTickets_Click);
            // 
            // panelSessionsSubMenu
            // 
            this.panelSessionsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSessionsSubMenu.Controls.Add(this.buttonSessionInstances);
            this.panelSessionsSubMenu.Controls.Add(this.buttonSessionList);
            this.panelSessionsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSessionsSubMenu.Location = new System.Drawing.Point(0, 456);
            this.panelSessionsSubMenu.Name = "panelSessionsSubMenu";
            this.panelSessionsSubMenu.Size = new System.Drawing.Size(229, 86);
            this.panelSessionsSubMenu.TabIndex = 18;
            // 
            // buttonSessionInstances
            // 
            this.buttonSessionInstances.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSessionInstances.FlatAppearance.BorderSize = 0;
            this.buttonSessionInstances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSessionInstances.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSessionInstances.Location = new System.Drawing.Point(0, 40);
            this.buttonSessionInstances.Name = "buttonSessionInstances";
            this.buttonSessionInstances.Size = new System.Drawing.Size(229, 40);
            this.buttonSessionInstances.TabIndex = 1;
            this.buttonSessionInstances.Text = "Session Instances";
            this.buttonSessionInstances.UseVisualStyleBackColor = true;
            this.buttonSessionInstances.Click += new System.EventHandler(this.buttonSessionInstances_Click);
            // 
            // buttonSessionList
            // 
            this.buttonSessionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSessionList.FlatAppearance.BorderSize = 0;
            this.buttonSessionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSessionList.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSessionList.Location = new System.Drawing.Point(0, 0);
            this.buttonSessionList.Name = "buttonSessionList";
            this.buttonSessionList.Size = new System.Drawing.Size(229, 40);
            this.buttonSessionList.TabIndex = 0;
            this.buttonSessionList.Text = "Session List";
            this.buttonSessionList.UseVisualStyleBackColor = true;
            this.buttonSessionList.Click += new System.EventHandler(this.buttonSessionList_Click);
            // 
            // buttonSessions
            // 
            this.buttonSessions.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSessions.FlatAppearance.BorderSize = 0;
            this.buttonSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSessions.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSessions.Location = new System.Drawing.Point(0, 411);
            this.buttonSessions.Name = "buttonSessions";
            this.buttonSessions.Size = new System.Drawing.Size(229, 45);
            this.buttonSessions.TabIndex = 17;
            this.buttonSessions.Text = "Manage Sessions";
            this.buttonSessions.UseVisualStyleBackColor = true;
            this.buttonSessions.Click += new System.EventHandler(this.buttonSessions_Click);
            // 
            // buttonRooms
            // 
            this.buttonRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRooms.FlatAppearance.BorderSize = 0;
            this.buttonRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRooms.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRooms.Location = new System.Drawing.Point(0, 366);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(229, 45);
            this.buttonRooms.TabIndex = 16;
            this.buttonRooms.Text = "Manage Rooms";
            this.buttonRooms.UseVisualStyleBackColor = true;
            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
            // 
            // buttonMovies
            // 
            this.buttonMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMovies.FlatAppearance.BorderSize = 0;
            this.buttonMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovies.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMovies.Location = new System.Drawing.Point(0, 321);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Size = new System.Drawing.Size(229, 45);
            this.buttonMovies.TabIndex = 15;
            this.buttonMovies.Text = "Manage Movies Library";
            this.buttonMovies.UseVisualStyleBackColor = true;
            this.buttonMovies.Click += new System.EventHandler(this.buttonMovies_Click);
            // 
            // panelEmployeesSubmenu
            // 
            this.panelEmployeesSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelEmployeesSubmenu.Controls.Add(this.buttonManagers);
            this.panelEmployeesSubmenu.Controls.Add(this.buttonWorkers);
            this.panelEmployeesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployeesSubmenu.Location = new System.Drawing.Point(0, 235);
            this.panelEmployeesSubmenu.Name = "panelEmployeesSubmenu";
            this.panelEmployeesSubmenu.Size = new System.Drawing.Size(229, 86);
            this.panelEmployeesSubmenu.TabIndex = 14;
            // 
            // buttonManagers
            // 
            this.buttonManagers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManagers.FlatAppearance.BorderSize = 0;
            this.buttonManagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManagers.ForeColor = System.Drawing.Color.LightGray;
            this.buttonManagers.Location = new System.Drawing.Point(0, 40);
            this.buttonManagers.Name = "buttonManagers";
            this.buttonManagers.Size = new System.Drawing.Size(229, 40);
            this.buttonManagers.TabIndex = 1;
            this.buttonManagers.Text = "Manager List";
            this.buttonManagers.UseVisualStyleBackColor = true;
            this.buttonManagers.Click += new System.EventHandler(this.buttonManagers_Click);
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWorkers.FlatAppearance.BorderSize = 0;
            this.buttonWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkers.ForeColor = System.Drawing.Color.LightGray;
            this.buttonWorkers.Location = new System.Drawing.Point(0, 0);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(229, 40);
            this.buttonWorkers.TabIndex = 0;
            this.buttonWorkers.Text = "Worker List";
            this.buttonWorkers.UseVisualStyleBackColor = true;
            this.buttonWorkers.Click += new System.EventHandler(this.buttonWorkers_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployees.FlatAppearance.BorderSize = 0;
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmployees.Location = new System.Drawing.Point(0, 190);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(229, 45);
            this.buttonEmployees.TabIndex = 13;
            this.buttonEmployees.Text = "Manage Employees";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // buttonCleaningRecords
            // 
            this.buttonCleaningRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCleaningRecords.FlatAppearance.BorderSize = 0;
            this.buttonCleaningRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleaningRecords.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCleaningRecords.Location = new System.Drawing.Point(0, 145);
            this.buttonCleaningRecords.Name = "buttonCleaningRecords";
            this.buttonCleaningRecords.Size = new System.Drawing.Size(229, 45);
            this.buttonCleaningRecords.TabIndex = 9;
            this.buttonCleaningRecords.Text = "Manage Cleaning Records";
            this.buttonCleaningRecords.UseVisualStyleBackColor = true;
            this.buttonCleaningRecords.Click += new System.EventHandler(this.buttonCleaningRecords_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClients.FlatAppearance.BorderSize = 0;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClients.Location = new System.Drawing.Point(0, 100);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(229, 45);
            this.buttonClients.TabIndex = 8;
            this.buttonClients.Text = "Manage Clients";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(682, 553);
            this.panelChildForm.TabIndex = 1;
            // 
            // MainMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainMenuManager";
            this.Text = "Cinema Manager";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSessionsSubMenu.ResumeLayout(false);
            this.panelEmployeesSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Button buttonMovies;
        private System.Windows.Forms.Panel panelEmployeesSubmenu;
        private System.Windows.Forms.Button buttonManagers;
        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonCleaningRecords;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonSessions;
        private System.Windows.Forms.Button buttonTickets;
        private System.Windows.Forms.Panel panelSessionsSubMenu;
        private System.Windows.Forms.Button buttonSessionInstances;
        private System.Windows.Forms.Button buttonSessionList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLogOut;
    }
}

