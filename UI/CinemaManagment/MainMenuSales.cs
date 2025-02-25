﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagment
{
    public partial class MainMenuSales : Form
    {
        #region startUp
        public MainMenuSales()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSessionsSubMenu.Visible = false;
        }
        #endregion startUp

        #region hide/show subMenu
        private void hideSubMenu()
        {
            if (panelSessionsSubMenu.Visible == true)
                panelSessionsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion hide/show subMenu

        #region clientsMenu
        private void buttonClients_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ListClient());
        }
        #endregion clientsMenu

        #region moviesMenu
        private void buttonMovies_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ListFilm());
        }
        #endregion moviesMenu

        #region roomsMenu
        private void buttonRooms_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ListRoom());
        }
        #endregion roomsMenu

        #region sessionsMenu
        private void buttonSessions_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSessionsSubMenu);
        }

        private void buttonSessionList_Click(object sender, EventArgs e)
        {
            openChildForm(new ListSession());
        }

        private void buttonSessionInstances_Click(object sender, EventArgs e)
        {
            openChildForm(new ListSessionInstance());
        }
        #endregion sessionsMenu

        #region ticketsMenu
        private void buttonTickets_Click(object sender, EventArgs e)
        {
            openChildForm(new ListTicketHistory());
        }
        #endregion ticketsMenu

        #region logout
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        #endregion logout

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
