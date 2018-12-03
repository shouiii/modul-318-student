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
    public partial class UserInterface : Form
    {
        Transport transportApi = new Transport();

        /// <summary>Initialize 
        /// This method locates a URI to the XAML for the Window/UserControl that is loading, 
        /// and passes it to the System.Windows.Application.LoadComponent() static method. 
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
  
        private Stations GetStations(string input) // get Station by userInput string
        {
            Stations station = transportApi.GetStations(input);
            return station;
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

        private void showFromStationsButton(object sender, EventArgs e)
        {
            fromStationComboBox.DroppedDown = true;
            fromStationComboBox.DataSource = GetStations(fromStationComboBox.Text).StationList;
            fromStationComboBox.DisplayMember = "name";
        }

        private void showToStationsButton(object sender, EventArgs e)
        {
            toStationComboBox.DroppedDown = true;
            toStationComboBox.DataSource = GetStations(toStationComboBox.Text).StationList;
            toStationComboBox.DisplayMember = "name";
        }

        private void findConnectionButton(object sender, EventArgs e)
        {
            stationBoardView.Visible = false;

            List<Connection> railwayConnection = transportApi.GetConnections(fromStationComboBox.Text, toStationComboBox.Text).ConnectionList;
            foreach (Connection connection in railwayConnection)
            {
                connectionView.Rows.Add(connection.From.Departure, connection.From.Station.Name, connection.To.Arrival, connection.To.Station.Name, connection.Duration);
            }
        }

        private void showFromStationBoard(object sender, EventArgs e)
        {
            stationBoardView.Visible = true;

            string id = GetStationID(fromStationComboBox.Text);
            List<StationBoard> stationBoard = transportApi.GetStationBoard(fromStationComboBox.Text, id).Entries;
            foreach (StationBoard fromStation in stationBoard)
            {
                stationBoardView.Rows.Add(fromStation.Stop.Departure, fromStation.Name);
            }
        }

        private void fromStationTextBox_TextChanged(object sender, EventArgs e)
        {
            fromAutoInputList.Visible = true;
            List<Station> toStation = GetStations(fromStationTextBox.Text).StationList;

            fromAutoInputList.DataSource = toStation;
            fromAutoInputList.DisplayMember = "name";
        }

        private void doubleClickAutoInput(object sender, EventArgs e)
        {
            fromStationTextBox.Text = Convert.ToString(fromAutoInputList.Text);
            fromAutoInputList.Hide();
        }
    }
}
