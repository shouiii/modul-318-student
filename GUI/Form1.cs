using System;
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
    public partial class Form1 : Form
    {
        Transport transportApi = new Transport();

        public Form1()
        {
            InitializeComponent();
        }

        //public void DepartureStations()
        //{
        //    string fromStation = fromStationComboBox.Text;
        //    string toStation = toStationComboBox.Text;
        //}

        public Stations Station(string input) // get Station by userInput string
        {
            Stations station = transportApi.GetStations(input);
            return station;
        }

        private void showFromStationsButton(object sender, EventArgs e)
        {
            fromStationComboBox.DroppedDown = true;
            fromStationComboBox.DataSource = Station(fromStationComboBox.Text).StationList;
            fromStationComboBox.DisplayMember = "name";
        }

        private void showToStationsButton(object sender, EventArgs e)
        {
            toStationComboBox.DroppedDown = true;
            toStationComboBox.DataSource = Station(fromStationComboBox.Text).StationList;
            toStationComboBox.DisplayMember = "name";
        }

        //private void findConnectionsButton(object sender, EventArgs e)
        //{
        //    Connection railwayConnection = transportApi.GetConnections(fromStationComboBox.)
        //    connectionsListBox.DataSource = transportApi.GetConnections(fromStationComboBox.Text, toStationComboBox.Text).ConnectionList;
        //    connectionsListBox.DisplayMember = 
        //}
    }
}
