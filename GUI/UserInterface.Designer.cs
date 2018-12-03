namespace GUI
{
    partial class UserInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromStationComboBox = new System.Windows.Forms.ComboBox();
            this.toStationComboBox = new System.Windows.Forms.ComboBox();
            this.findStartStation = new System.Windows.Forms.Button();
            this.findEndStation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.connectionView = new System.Windows.Forms.DataGridView();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.fromStationTextBox = new System.Windows.Forms.TextBox();
            this.fromAutoInputList = new System.Windows.Forms.ListBox();
            this.stationBoardView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromStationBoard = new System.Windows.Forms.Button();
            this.toStationBoard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.connectionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "From ...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "To ...";
            // 
            // fromStationComboBox
            // 
            this.fromStationComboBox.FormattingEnabled = true;
            this.fromStationComboBox.Location = new System.Drawing.Point(46, 80);
            this.fromStationComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromStationComboBox.Name = "fromStationComboBox";
            this.fromStationComboBox.Size = new System.Drawing.Size(452, 28);
            this.fromStationComboBox.TabIndex = 4;
            // 
            // toStationComboBox
            // 
            this.toStationComboBox.FormattingEnabled = true;
            this.toStationComboBox.Location = new System.Drawing.Point(664, 80);
            this.toStationComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toStationComboBox.Name = "toStationComboBox";
            this.toStationComboBox.Size = new System.Drawing.Size(452, 28);
            this.toStationComboBox.TabIndex = 5;
            // 
            // findStartStation
            // 
            this.findStartStation.Location = new System.Drawing.Point(555, 78);
            this.findStartStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findStartStation.Name = "findStartStation";
            this.findStartStation.Size = new System.Drawing.Size(63, 35);
            this.findStartStation.TabIndex = 6;
            this.findStartStation.Text = "FIND";
            this.findStartStation.UseVisualStyleBackColor = true;
            this.findStartStation.Click += new System.EventHandler(this.showFromStationsButton);
            // 
            // findEndStation
            // 
            this.findEndStation.Location = new System.Drawing.Point(1172, 78);
            this.findEndStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findEndStation.Name = "findEndStation";
            this.findEndStation.Size = new System.Drawing.Size(63, 35);
            this.findEndStation.TabIndex = 7;
            this.findEndStation.Text = "FIND";
            this.findEndStation.UseVisualStyleBackColor = true;
            this.findEndStation.Click += new System.EventHandler(this.showToStationsButton);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1188, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Find connections";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.findConnectionButton);
            // 
            // connectionView
            // 
            this.connectionView.AllowUserToAddRows = false;
            this.connectionView.AllowUserToDeleteRows = false;
            this.connectionView.AllowUserToResizeColumns = false;
            this.connectionView.AllowUserToResizeRows = false;
            this.connectionView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.connectionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.From,
            this.Arrival,
            this.To,
            this.Duration});
            this.connectionView.Location = new System.Drawing.Point(46, 303);
            this.connectionView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionView.Name = "connectionView";
            this.connectionView.ReadOnly = true;
            this.connectionView.RowHeadersVisible = false;
            this.connectionView.RowHeadersWidth = 80;
            this.connectionView.Size = new System.Drawing.Size(1188, 435);
            this.connectionView.TabIndex = 10;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Connections";
            // 
            // fromStationTextBox
            // 
            this.fromStationTextBox.Location = new System.Drawing.Point(46, 211);
            this.fromStationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromStationTextBox.Name = "fromStationTextBox";
            this.fromStationTextBox.Size = new System.Drawing.Size(452, 26);
            this.fromStationTextBox.TabIndex = 12;
            this.fromStationTextBox.TextChanged += new System.EventHandler(this.fromStationTextBox_TextChanged);
            // 
            // fromAutoInputList
            // 
            this.fromAutoInputList.FormattingEnabled = true;
            this.fromAutoInputList.ItemHeight = 20;
            this.fromAutoInputList.Location = new System.Drawing.Point(46, 237);
            this.fromAutoInputList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromAutoInputList.Name = "fromAutoInputList";
            this.fromAutoInputList.Size = new System.Drawing.Size(452, 144);
            this.fromAutoInputList.TabIndex = 13;
            this.fromAutoInputList.Visible = false;
            this.fromAutoInputList.DoubleClick += new System.EventHandler(this.doubleClickAutoInput);
            // 
            // stationBoardView
            // 
            this.stationBoardView.AllowUserToAddRows = false;
            this.stationBoardView.AllowUserToDeleteRows = false;
            this.stationBoardView.AllowUserToResizeColumns = false;
            this.stationBoardView.AllowUserToResizeRows = false;
            this.stationBoardView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stationBoardView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationBoardView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Name});
            this.stationBoardView.Location = new System.Drawing.Point(46, 303);
            this.stationBoardView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stationBoardView.Name = "stationBoardView";
            this.stationBoardView.ReadOnly = true;
            this.stationBoardView.RowHeadersVisible = false;
            this.stationBoardView.RowHeadersWidth = 80;
            this.stationBoardView.Size = new System.Drawing.Size(1188, 435);
            this.stationBoardView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Departure";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // fromStationBoard
            // 
            this.fromStationBoard.Location = new System.Drawing.Point(507, 78);
            this.fromStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromStationBoard.Name = "fromStationBoard";
            this.fromStationBoard.Size = new System.Drawing.Size(44, 35);
            this.fromStationBoard.TabIndex = 15;
            this.fromStationBoard.Text = "B";
            this.fromStationBoard.UseVisualStyleBackColor = true;
            this.fromStationBoard.Click += new System.EventHandler(this.showFromStationBoard);
            // 
            // toStationBoard
            // 
            this.toStationBoard.Location = new System.Drawing.Point(1124, 78);
            this.toStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toStationBoard.Name = "toStationBoard";
            this.toStationBoard.Size = new System.Drawing.Size(44, 35);
            this.toStationBoard.TabIndex = 16;
            this.toStationBoard.Text = "B";
            this.toStationBoard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 805);
            this.Controls.Add(this.fromAutoInputList);
            this.Controls.Add(this.toStationBoard);
            this.Controls.Add(this.fromStationBoard);
            this.Controls.Add(this.stationBoardView);
            this.Controls.Add(this.fromStationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.connectionView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.findEndStation);
            this.Controls.Add(this.findStartStation);
            this.Controls.Add(this.toStationComboBox);
            this.Controls.Add(this.fromStationComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            ((System.ComponentModel.ISupportInitialize)(this.connectionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fromStationComboBox;
        private System.Windows.Forms.ComboBox toStationComboBox;
        private System.Windows.Forms.Button findStartStation;
        private System.Windows.Forms.Button findEndStation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView connectionView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fromStationTextBox;
        private System.Windows.Forms.ListBox fromAutoInputList;
        private System.Windows.Forms.DataGridView stationBoardView;
        private System.Windows.Forms.Button fromStationBoard;
        private System.Windows.Forms.Button toStationBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}

