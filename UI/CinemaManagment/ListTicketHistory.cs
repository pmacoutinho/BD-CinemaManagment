﻿using CinemaManagment.Entities;
using CinemaManagment.sgbd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagment.Common;

namespace CinemaManagment
{
    public partial class ListTicketHistory : Form
    {
        private SqlConnection cn = SGBDCon.getCN();

        public ListTicketHistory()
        {
            InitializeComponent();
            customizeDesign();
            loadTable();
        }

        private void customizeDesign()
        {
            dataGridViewTicket.EnableHeadersVisualStyles = false;
            dataGridViewTicket.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 14);
        }

        private void loadTable()
        {
            User u = User.getInstance();

           /* var select = "SELECT Operations.Ticket.id AS 'ID', price AS 'Price', Operations.Client.name AS 'Client', " +
                "Management.Employee.name AS 'Seller' " +
                "FROM Operations.Ticket " +
                "JOIN Operations.Client ON Operations.Ticket.client=Operations.Client.id " +
                "JOIN Operations.Reservation ON Operations.Ticket.reservation=Operations.Reservation.id " +
                "JOIN Data.Session ON Operations.Reservation.session_i=Data.Session.id " +
                "JOIN Management.Employee ON Operations.Ticket.sellerId=Management.Employee.id" +
                "WHERE Data.Session.cinema=" + u.e.cinema;
            var dataAdapter = new SqlDataAdapter(select, cn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewTicket.ReadOnly = true;
            dataGridViewTicket.DataSource = ds.Tables[0];*/

            dataGridViewTicket.ReadOnly = true;
            dataGridViewTicket.DataSource = Operations.loadTickets(u.e.cinema);
        }

        private void roundedButtonAdd_Click(object sender, EventArgs e)
        {
            AddTicket adder = new AddTicket();
            adder.Show();
        }
    }
}
