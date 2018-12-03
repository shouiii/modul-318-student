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
            List<StationBoard> stationBoard = transportApi.GetStationBoard(tbToStation.Text, id, time).Entries;
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
            string time = dtSetTime.Value.ToString("HH:mm");

            dgvStationBoard.Visible = false;

            List<Connection> railwayConnection = transportApi.GetConnections(tbFromStation.Text, tbToStation.Text, time).ConnectionList;
            foreach (Connection connection in railwayConnection)
            {
                dfvConnection.Rows.Add(Convert.ToDateTime(connection.From.Departure).ToShortTimeString(), connection.From.Station.Name, connection.To.Arrival, connection.To.Station.Name, connection.Duration);
            }
        }

        private void ShowFromStationBoard(object sender, EventArgs e) // Stationboard for "To ..." station
        {
            string time = dtSetTime.Value.ToString("HH:mm");

            dgvStationBoard.Rows.Clear();
            dgvStationBoard.Refresh();

            dgvStationBoard.Visible = true;

            string id = GetStationID(tbFromStation.Text);
            List<StationBoard> stationBoard = GetStationBoard(tbFromStation.Text, id, time);
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

            string id = GetStationID(tbToStation.Text);
            List<StationBoard> stationBoard = GetStationBoard(tbToStation.Text, id, time);
            foreach (StationBoard ToStation in stationBoard)
            {
                dgvStationBoard.Rows.Add(Convert.ToDateTime(ToStation.Stop.Departure).ToShortTimeString(), ToStation.Number, ToStation.To);
            }
        }

        private void FromStationTextBox_TextChanged(object sender, EventArgs e) // Autocomplete for "From ..."
        {
            fromAutoInputList.Visible = true;
            List<Station> stationNames = GetStations(tbFromStation.Text).StationList;

            fromAutoInputList.DataSource = stationNames;
            fromAutoInputList.DisplayMember = "name";
        }

        private void FromClickAutoInput(object sender, EventArgs e)
        {
            tbFromStation.Text = Convert.ToString(fromAutoInputList.Text);
            fromAutoInputList.Hide();
        }

        private void ToStationTextBox_TextChanged(object sender, EventArgs e) // Autocomplete for "To ..."
        {
            toAutoInputList.Visible = true;
            List<Station> stationNames = GetStations(tbToStation.Text).StationList;

            toAutoInputList.DataSource = stationNames;
            toAutoInputList.DisplayMember = "name";
        }

        private void ToClickAutoInput(object sender, EventArgs e)
        {
            tbToStation.Text = Convert.ToString(toAutoInputList.Text);
            toAutoInputList.Hide();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
