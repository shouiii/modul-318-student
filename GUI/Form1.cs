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
            toStationComboBox.DataSource = Station(toStationComboBox.Text).StationList;
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

        public string GetStationID(string userInput)
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



        //private void fromStationTextBox_TextChanged(object sender, EventArgs e)
        //{

        //    this.fromStationTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    this.fromStationTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

        //    TextBox t = sender as TextBox;

        //    if (t != null)
        //    {
        //        if (t.Text.Length > 0)
        //        {
        //            List<Station> stations = Station(t.Text).StationList;

        //            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        //            collection.AddRange((stations.ToArray()).ToString);
        //        }
        //    }
        //}

        //private List<Station> SuggestStrings(string text)
        //{
        //    List<Station> stations = Station(text).StationList;

        //    return stations;
        //}

        //private void fromStationTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    fromAutoInputList.Visible = true;

        //    fromAutoInputList.DataSource = Station(fromStationTextBox.Text).StationList;
        //    fromAutoInputList.DisplayMember = "name";


        //}
    }
}
