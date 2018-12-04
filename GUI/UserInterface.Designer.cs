namespace GUI
{
    partial class ConnectionProgram
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionProgram));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.dgvConnection = new System.Windows.Forms.DataGridView();
            this.DepartureConnections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFromStation = new System.Windows.Forms.TextBox();
            this.lbFromAutoInputList = new System.Windows.Forms.ListBox();
            this.dgvStationBoard = new System.Windows.Forms.DataGridView();
            this.DepartureStationBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStationBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFromStationBoard = new System.Windows.Forms.Button();
            this.btnToStationBoard = new System.Windows.Forms.Button();
            this.txtToStation = new System.Windows.Forms.TextBox();
            this.lbToAutoInputList = new System.Windows.Forms.ListBox();
            this.dtSetTime = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.slogan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.companyName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationBoard)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(32, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "FROM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(726, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "TO";
            // 
            // btnConnection
            // 
            this.btnConnection.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConnection.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConnection.Location = new System.Drawing.Point(38, 278);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(1300, 63);
            this.btnConnection.TabIndex = 5;
            this.btnConnection.Text = "FIND CONNECTIONS";
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Visible = false;
            this.btnConnection.Click += new System.EventHandler(this.FindConnectionButton);
            // 
            // dgvConnection
            // 
            this.dgvConnection.AllowUserToAddRows = false;
            this.dgvConnection.AllowUserToDeleteRows = false;
            this.dgvConnection.AllowUserToResizeColumns = false;
            this.dgvConnection.AllowUserToResizeRows = false;
            this.dgvConnection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConnection.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConnection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConnection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureConnections,
            this.Platform,
            this.From,
            this.Arrival,
            this.To,
            this.Duration});
            this.dgvConnection.GridColor = System.Drawing.SystemColors.Control;
            this.dgvConnection.Location = new System.Drawing.Point(38, 396);
            this.dgvConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConnection.Name = "dgvConnection";
            this.dgvConnection.ReadOnly = true;
            this.dgvConnection.RowHeadersVisible = false;
            this.dgvConnection.RowHeadersWidth = 80;
            this.dgvConnection.Size = new System.Drawing.Size(1300, 400);
            this.dgvConnection.TabIndex = 10;
            // 
            // DepartureConnections
            // 
            this.DepartureConnections.HeaderText = "Departure";
            this.DepartureConnections.Name = "DepartureConnections";
            this.DepartureConnections.ReadOnly = true;
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            this.Platform.ReadOnly = true;
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
            this.label4.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(32, 356);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "CONNECTIONS...";
            // 
            // txtFromStation
            // 
            this.txtFromStation.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFromStation.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromStation.Location = new System.Drawing.Point(38, 175);
            this.txtFromStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFromStation.Name = "txtFromStation";
            this.txtFromStation.Size = new System.Drawing.Size(452, 42);
            this.txtFromStation.TabIndex = 1;
            this.txtFromStation.TextChanged += new System.EventHandler(this.FromStationTextBox_TextChanged);
            // 
            // lbFromAutoInputList
            // 
            this.lbFromAutoInputList.BackColor = System.Drawing.Color.Gainsboro;
            this.lbFromAutoInputList.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFromAutoInputList.FormattingEnabled = true;
            this.lbFromAutoInputList.ItemHeight = 24;
            this.lbFromAutoInputList.Location = new System.Drawing.Point(38, 217);
            this.lbFromAutoInputList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbFromAutoInputList.Name = "lbFromAutoInputList";
            this.lbFromAutoInputList.Size = new System.Drawing.Size(452, 124);
            this.lbFromAutoInputList.TabIndex = 13;
            this.lbFromAutoInputList.Visible = false;
            this.lbFromAutoInputList.Click += new System.EventHandler(this.FromClickAutoInput);
            // 
            // dgvStationBoard
            // 
            this.dgvStationBoard.AllowUserToAddRows = false;
            this.dgvStationBoard.AllowUserToDeleteRows = false;
            this.dgvStationBoard.AllowUserToResizeColumns = false;
            this.dgvStationBoard.AllowUserToResizeRows = false;
            this.dgvStationBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStationBoard.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvStationBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStationBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureStationBoard,
            this.NameStationBoard,
            this.Destination});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStationBoard.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStationBoard.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStationBoard.Location = new System.Drawing.Point(38, 396);
            this.dgvStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStationBoard.Name = "dgvStationBoard";
            this.dgvStationBoard.ReadOnly = true;
            this.dgvStationBoard.RowHeadersVisible = false;
            this.dgvStationBoard.RowHeadersWidth = 80;
            this.dgvStationBoard.Size = new System.Drawing.Size(1300, 400);
            this.dgvStationBoard.TabIndex = 14;
            this.dgvStationBoard.Visible = false;
            // 
            // DepartureStationBoard
            // 
            this.DepartureStationBoard.HeaderText = "Departure";
            this.DepartureStationBoard.Name = "DepartureStationBoard";
            this.DepartureStationBoard.ReadOnly = true;
            // 
            // NameStationBoard
            // 
            this.NameStationBoard.HeaderText = "Name";
            this.NameStationBoard.Name = "NameStationBoard";
            this.NameStationBoard.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // btnFromStationBoard
            // 
            this.btnFromStationBoard.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFromStationBoard.FlatAppearance.BorderSize = 0;
            this.btnFromStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromStationBoard.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFromStationBoard.ForeColor = System.Drawing.Color.White;
            this.btnFromStationBoard.Location = new System.Drawing.Point(498, 174);
            this.btnFromStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFromStationBoard.Name = "btnFromStationBoard";
            this.btnFromStationBoard.Size = new System.Drawing.Size(150, 43);
            this.btnFromStationBoard.TabIndex = 2;
            this.btnFromStationBoard.Text = "STATIONBOARD";
            this.btnFromStationBoard.UseVisualStyleBackColor = false;
            this.btnFromStationBoard.Visible = false;
            this.btnFromStationBoard.Click += new System.EventHandler(this.ShowFromStationBoard);
            // 
            // btnToStationBoard
            // 
            this.btnToStationBoard.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnToStationBoard.FlatAppearance.BorderSize = 0;
            this.btnToStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToStationBoard.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToStationBoard.ForeColor = System.Drawing.Color.White;
            this.btnToStationBoard.Location = new System.Drawing.Point(1192, 174);
            this.btnToStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToStationBoard.Name = "btnToStationBoard";
            this.btnToStationBoard.Size = new System.Drawing.Size(146, 43);
            this.btnToStationBoard.TabIndex = 4;
            this.btnToStationBoard.Text = "STATIONBOARD";
            this.btnToStationBoard.UseVisualStyleBackColor = false;
            this.btnToStationBoard.Visible = false;
            this.btnToStationBoard.Click += new System.EventHandler(this.ShowToStationBoard);
            // 
            // txtToStation
            // 
            this.txtToStation.BackColor = System.Drawing.Color.Gainsboro;
            this.txtToStation.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToStation.Location = new System.Drawing.Point(732, 175);
            this.txtToStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToStation.Name = "txtToStation";
            this.txtToStation.Size = new System.Drawing.Size(452, 42);
            this.txtToStation.TabIndex = 3;
            this.txtToStation.TextChanged += new System.EventHandler(this.ToStationTextBox_TextChanged);
            // 
            // lbToAutoInputList
            // 
            this.lbToAutoInputList.BackColor = System.Drawing.Color.Gainsboro;
            this.lbToAutoInputList.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToAutoInputList.FormattingEnabled = true;
            this.lbToAutoInputList.ItemHeight = 24;
            this.lbToAutoInputList.Location = new System.Drawing.Point(732, 217);
            this.lbToAutoInputList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbToAutoInputList.Name = "lbToAutoInputList";
            this.lbToAutoInputList.Size = new System.Drawing.Size(452, 124);
            this.lbToAutoInputList.TabIndex = 18;
            this.lbToAutoInputList.Visible = false;
            this.lbToAutoInputList.Click += new System.EventHandler(this.ToClickAutoInput);
            // 
            // dtSetTime
            // 
            this.dtSetTime.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtSetTime.CustomFormat = "HH:mm";
            this.dtSetTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSetTime.Location = new System.Drawing.Point(38, 225);
            this.dtSetTime.Name = "dtSetTime";
            this.dtSetTime.Size = new System.Drawing.Size(452, 26);
            this.dtSetTime.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.slogan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.companyName);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 110);
            this.panel1.TabIndex = 20;
            // 
            // slogan
            // 
            this.slogan.AutoSize = true;
            this.slogan.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slogan.ForeColor = System.Drawing.SystemColors.Control;
            this.slogan.Location = new System.Drawing.Point(1040, 48);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(300, 29);
            this.slogan.TabIndex = 22;
            this.slogan.Text = "YOUR  WAY  IS  OUR  TRAIN!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Font = new System.Drawing.Font("Corbel", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.ForeColor = System.Drawing.SystemColors.Control;
            this.companyName.Location = new System.Drawing.Point(130, 33);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(261, 49);
            this.companyName.TabIndex = 21;
            this.companyName.Text = "NMB ALS SBB";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(655, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 68);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ClickStartToEnd);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(38, 278);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1300, 63);
            this.button2.TabIndex = 22;
            this.button2.Text = "FIND CONNECTIONS";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button3.Location = new System.Drawing.Point(1192, 227);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 43);
            this.button3.TabIndex = 23;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnResetTextBox);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button4.Location = new System.Drawing.Point(498, 174);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 43);
            this.button4.TabIndex = 24;
            this.button4.Text = "STATIONBOARD";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button5.Location = new System.Drawing.Point(1192, 174);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 43);
            this.button5.TabIndex = 25;
            this.button5.Text = "STATIONBOARD";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // ConnectionProgram
            // 
            this.AcceptButton = this.btnConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 840);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbFromAutoInputList);
            this.Controls.Add(this.dtSetTime);
            this.Controls.Add(this.lbToAutoInputList);
            this.Controls.Add(this.txtToStation);
            this.Controls.Add(this.btnToStationBoard);
            this.Controls.Add(this.btnFromStationBoard);
            this.Controls.Add(this.dgvStationBoard);
            this.Controls.Add(this.txtFromStation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvConnection);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConnectionProgram";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationBoard)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.DataGridView dgvConnection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFromStation;
        private System.Windows.Forms.ListBox lbFromAutoInputList;
        private System.Windows.Forms.DataGridView dgvStationBoard;
        private System.Windows.Forms.Button btnFromStationBoard;
        private System.Windows.Forms.Button btnToStationBoard;
        private System.Windows.Forms.TextBox txtToStation;
        private System.Windows.Forms.ListBox lbToAutoInputList;
        private System.Windows.Forms.DateTimePicker dtSetTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureStationBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStationBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureConnections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label slogan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

