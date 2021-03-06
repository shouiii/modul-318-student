﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace GUI
{
    public partial class ConnectionProgram : Form
    {
        Transport transportApi = new Transport();

        /// <summary>Initialize 
        /// This method locates a URI to the XAML for the Window/UserControl that is loading, 
        /// and passes it to the System.Windows.Application.LoadComponent() static method. 
        /// </summary>
        public ConnectionProgram()
        {
            InitializeComponent();
        }

        private Stations GetStations(string input) // get Station by userInput string
        {
            Stations station = transportApi.GetStations(input);
            return station;
        }

        private List<StationBoard> GetStationBoard(string input, string id, string time)
        {
            StationBoardRoot root = transportApi.GetStationBoard(txtToStation.Text, id, time);

            if (root != null)
            {
                return root.Entries;
            }
            return null;
        }

        private string GetStationID(string userInput)
        {
            string id;
            List<Station> listOfStations = transportApi.GetStations(userInput).StationList;
            foreach (Station station in listOfStations)
            {
                id = station.Id;
                return id;
            }
            return null;
        }

        private void CheckConnectionButton() // Enables or disable Connection Button depending on the state of the textfield
        {
            if(txtFromStation.Text != String.Empty && txtToStation.Text != String.Empty)
            {
                btnConnection.Visible = true;
            }
            else
            {
                btnConnection.Visible = false;
            }
        }

        private void FindConnectionButton(object sender, EventArgs e)
        {
            string time = dtSetTime.Value.ToString("HH:mm");

            dgvStationBoard.Visible = false;

            dgvConnection.Rows.Clear();
            dgvConnection.Refresh();

            List<Connection> railwayConnection = transportApi.GetConnections(txtFromStation.Text, txtToStation.Text, time).ConnectionList;
            foreach (Connection connection in railwayConnection)
            {
                string duration = connection.Duration.Substring(6, 2);

                dgvConnection.Rows.Add(Convert.ToDateTime(connection.From.Departure).ToShortTimeString(), connection.From.Platform, connection.From.Station.Name, connection.To.Arrival, connection.To.Station.Name, duration + " Min");
            }
        }

        private void ShowFromStationBoard(object sender, EventArgs e) // Stationboard for "To ..." station
        {
            string time = dtSetTime.Value.ToString("HH:mm");

            dgvStationBoard.Rows.Clear();
            dgvStationBoard.Refresh();

            dgvStationBoard.Visible = true;

            string id = GetStationID(txtFromStation.Text);
            List<StationBoard> stationBoard = GetStationBoard(txtFromStation.Text, id, time);
            foreach (StationBoard fromStation in stationBoard)
            {
                dgvStationBoard.Rows.Add(Convert.ToDateTime(fromStation.Stop.Departure).ToShortTimeString(), fromStation.Number, fromStation.To);
            }
        }

        private void ShowToStationBoard(object sender, EventArgs e) // Stationboard for "From ..." station
        {
            string time = dtSetTime.Value.ToString("HH:mm");

            dgvStationBoard.Rows.Clear();
            dgvStationBoard.Refresh();

            dgvStationBoard.Visible = true;

            string id = GetStationID(txtToStation.Text);
            List<StationBoard> stationBoard = GetStationBoard(txtToStation.Text, id, time);
            foreach (StationBoard ToStation in stationBoard)
            {
                dgvStationBoard.Rows.Add(Convert.ToDateTime(ToStation.Stop.Departure).ToShortTimeString(), ToStation.Number, ToStation.To);
            }
        }

        private void FromStationTextBox_TextChanged(object sender, EventArgs e) // Autocomplete for "From ..."
        {
            lbFromAutoInputList.Visible  = true;
            List<Station> stationNames = GetStations(txtFromStation.Text).StationList;

            lbFromAutoInputList.DataSource    = stationNames;
            lbFromAutoInputList.DisplayMember = "name";

            btnFromStationBoard.Visible = true;
            CheckConnectionButton();
        }

        private void FromClickAutoInput(object sender, EventArgs e)
        {
            txtFromStation.Text = Convert.ToString(lbFromAutoInputList.Text);
            lbFromAutoInputList.Hide();
        }

        private void ToStationTextBox_TextChanged(object sender, EventArgs e) // Autocomplete for "To ..."
        {
            lbToAutoInputList.Visible    = true;
            List<Station> stationNames = GetStations(txtToStation.Text).StationList;

            lbToAutoInputList.DataSource    = stationNames;
            lbToAutoInputList.DisplayMember = "name";

            btnToStationBoard.Visible = true;
            CheckConnectionButton();
        }

        private void ToClickAutoInput(object sender, EventArgs e)
        {
            txtToStation.Text = Convert.ToString(lbToAutoInputList.Text);
            lbToAutoInputList.Hide();
        }

        private void ClickStartToEnd(object sender, EventArgs e) // Swap startstation to endstation and backwards
        {
            string from = txtFromStation.Text;
            string to   = txtToStation.Text;
            txtFromStation.Text = to;
            txtToStation.Text   = from;
        }

        private void btnResetTextBox(object sender, EventArgs e)
        {
            txtFromStation.Text = null;
            txtToStation.Text = null;
            lbFromAutoInputList.Hide();
            lbToAutoInputList.Hide();
        }
    }
}
