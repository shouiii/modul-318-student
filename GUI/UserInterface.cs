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

        private List<StationBoard> GetStationBoard(string input, string id)
        {
            List<StationBoard> stationBoard = transportApi.GetStationBoard(toStationTextBox.Text, id).Entries;
            return stationBoard;
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

        private void FindConnectionButton(object sender, EventArgs e)
        {
            

            StationBoardView.Visible = false;

            List<Connection> railwayConnection = transportApi.GetConnections(fromStationTextBox.Text, toStationTextBox.Text).ConnectionList;
            foreach (Connection connection in railwayConnection)
            {
                connectionView.Rows.Add(Convert.ToDateTime(connection.From.Departure).ToShortTimeString(), connection.From.Station.Name, connection.To.Arrival, connection.To.Station.Name, connection.Duration);
            }
        }

        private void ShowFromStationBoard(object sender, EventArgs e) // Stationboard for "To ..." station
        {
            StationBoardView.Rows.Clear();
            StationBoardView.Refresh();

            StationBoardView.Visible = true;

            string id = GetStationID(fromStationTextBox.Text);
            List<StationBoard> stationBoard = GetStationBoard(fromStationTextBox.Text, id);
            foreach (StationBoard fromStation in stationBoard)
            {
                StationBoardView.Rows.Add(Convert.ToDateTime(fromStation.Stop.Departure).ToShortTimeString(), fromStation.Name, fromStation.To);
            }
        }

        private void ShowToStationBoard(object sender, EventArgs e) // Stationboard for "From ..." station
        {
            StationBoardView.Rows.Clear();
            StationBoardView.Refresh();

            StationBoardView.Visible = true;

            string id = GetStationID(toStationTextBox.Text);
            List<StationBoard> stationBoard = GetStationBoard(toStationTextBox.Text, id);
            foreach (StationBoard ToStation in stationBoard)
            {
                StationBoardView.Rows.Add(Convert.ToDateTime(ToStation.Stop.Departure).ToShortTimeString(), ToStation.Name, ToStation.To);
            }
        }

        private void FromStationTextBox_TextChanged(object sender, EventArgs e) // Autocomplete for "From ..."
        {
            fromAutoInputList.Visible = true;
            List<Station> stationNames = GetStations(fromStationTextBox.Text).StationList;

            fromAutoInputList.DataSource = stationNames;
            fromAutoInputList.DisplayMember = "name";
        }

        private void FromClickAutoInput(object sender, EventArgs e)
        {
            fromStationTextBox.Text = Convert.ToString(fromAutoInputList.Text);
            fromAutoInputList.Hide();
        }

        private void ToStationTextBox_TextChanged(object sender, EventArgs e) // Autocomplete for "To ..."
        {
            toAutoInputList.Visible = true;
            List<Station> stationNames = GetStations(toStationTextBox.Text).StationList;

            toAutoInputList.DataSource = stationNames;
            toAutoInputList.DisplayMember = "name";
        }

        private void ToClickAutoInput(object sender, EventArgs e)
        {
            toStationTextBox.Text = Convert.ToString(toAutoInputList.Text);
            toAutoInputList.Hide();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
