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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.dfvConnection = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFromStation = new System.Windows.Forms.TextBox();
            this.fromAutoInputList = new System.Windows.Forms.ListBox();
            this.dgvStationBoard = new System.Windows.Forms.DataGridView();
            this.btnFromStationBoard = new System.Windows.Forms.Button();
            this.btnToStationBoard = new System.Windows.Forms.Button();
            this.tbToStation = new System.Windows.Forms.TextBox();
            this.toAutoInputList = new System.Windows.Forms.ListBox();
            this.DepartureConnections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtSetTime = new System.Windows.Forms.DateTimePicker();
            this.DepartureStationBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStationBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dfvConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "From ...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "To ...";
            // 
            // btnConnection
            // 
            this.btnConnection.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConnection.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConnection.Location = new System.Drawing.Point(40, 159);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(1224, 63);
            this.btnConnection.TabIndex = 9;
            this.btnConnection.Text = "FIND CONNECTIONS";
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Click += new System.EventHandler(this.FindConnectionButton);
            // 
            // dfvConnection
            // 
            this.dfvConnection.AllowUserToAddRows = false;
            this.dfvConnection.AllowUserToDeleteRows = false;
            this.dfvConnection.AllowUserToResizeColumns = false;
            this.dfvConnection.AllowUserToResizeRows = false;
            this.dfvConnection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dfvConnection.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dfvConnection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dfvConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dfvConnection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureConnections,
            this.From,
            this.Arrival,
            this.To,
            this.Duration});
            this.dfvConnection.GridColor = System.Drawing.SystemColors.Control;
            this.dfvConnection.Location = new System.Drawing.Point(40, 277);
            this.dfvConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dfvConnection.Name = "dfvConnection";
            this.dfvConnection.ReadOnly = true;
            this.dfvConnection.RowHeadersVisible = false;
            this.dfvConnection.RowHeadersWidth = 80;
            this.dfvConnection.Size = new System.Drawing.Size(1224, 435);
            this.dfvConnection.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Connections";
            // 
            // tbFromStation
            // 
            this.tbFromStation.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFromStation.Location = new System.Drawing.Point(40, 56);
            this.tbFromStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFromStation.Name = "tbFromStation";
            this.tbFromStation.Size = new System.Drawing.Size(452, 42);
            this.tbFromStation.TabIndex = 12;
            this.tbFromStation.TextChanged += new System.EventHandler(this.FromStationTextBox_TextChanged);
            // 
            // fromAutoInputList
            // 
            this.fromAutoInputList.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromAutoInputList.FormattingEnabled = true;
            this.fromAutoInputList.ItemHeight = 24;
            this.fromAutoInputList.Location = new System.Drawing.Point(40, 98);
            this.fromAutoInputList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromAutoInputList.Name = "fromAutoInputList";
            this.fromAutoInputList.Size = new System.Drawing.Size(452, 124);
            this.fromAutoInputList.TabIndex = 13;
            this.fromAutoInputList.Visible = false;
            this.fromAutoInputList.Click += new System.EventHandler(this.FromClickAutoInput);
            // 
            // dgvStationBoard
            // 
            this.dgvStationBoard.AllowUserToAddRows = false;
            this.dgvStationBoard.AllowUserToDeleteRows = false;
            this.dgvStationBoard.AllowUserToResizeColumns = false;
            this.dgvStationBoard.AllowUserToResizeRows = false;
            this.dgvStationBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStationBoard.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvStationBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStationBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureStationBoard,
            this.NameStationBoard,
            this.Destination});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStationBoard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStationBoard.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStationBoard.Location = new System.Drawing.Point(40, 277);
            this.dgvStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStationBoard.Name = "dgvStationBoard";
            this.dgvStationBoard.ReadOnly = true;
            this.dgvStationBoard.RowHeadersVisible = false;
            this.dgvStationBoard.RowHeadersWidth = 80;
            this.dgvStationBoard.Size = new System.Drawing.Size(1224, 435);
            this.dgvStationBoard.TabIndex = 14;
            this.dgvStationBoard.Visible = false;
            // 
            // btnFromStationBoard
            // 
            this.btnFromStationBoard.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnFromStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromStationBoard.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFromStationBoard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFromStationBoard.Location = new System.Drawing.Point(500, 55);
            this.btnFromStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFromStationBoard.Name = "btnFromStationBoard";
            this.btnFromStationBoard.Size = new System.Drawing.Size(150, 43);
            this.btnFromStationBoard.TabIndex = 15;
            this.btnFromStationBoard.Text = "STATIONBOARD";
            this.btnFromStationBoard.UseVisualStyleBackColor = false;
            this.btnFromStationBoard.Click += new System.EventHandler(this.ShowFromStationBoard);
            // 
            // btnToStationBoard
            // 
            this.btnToStationBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnToStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToStationBoard.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToStationBoard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnToStationBoard.Location = new System.Drawing.Point(1118, 55);
            this.btnToStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToStationBoard.Name = "btnToStationBoard";
            this.btnToStationBoard.Size = new System.Drawing.Size(146, 43);
            this.btnToStationBoard.TabIndex = 16;
            this.btnToStationBoard.Text = "STATIONBOARD";
            this.btnToStationBoard.UseVisualStyleBackColor = false;
            this.btnToStationBoard.Click += new System.EventHandler(this.ShowToStationBoard);
            // 
            // tbToStation
            // 
            this.tbToStation.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToStation.Location = new System.Drawing.Point(658, 56);
            this.tbToStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbToStation.Name = "tbToStation";
            this.tbToStation.Size = new System.Drawing.Size(452, 42);
            this.tbToStation.TabIndex = 17;
            this.tbToStation.TextChanged += new System.EventHandler(this.ToStationTextBox_TextChanged);
            // 
            // toAutoInputList
            // 
            this.toAutoInputList.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAutoInputList.FormattingEnabled = true;
            this.toAutoInputList.ItemHeight = 24;
            this.toAutoInputList.Location = new System.Drawing.Point(658, 98);
            this.toAutoInputList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toAutoInputList.Name = "toAutoInputList";
            this.toAutoInputList.Size = new System.Drawing.Size(452, 124);
            this.toAutoInputList.TabIndex = 18;
            this.toAutoInputList.Visible = false;
            this.toAutoInputList.Click += new System.EventHandler(this.ToClickAutoInput);
            // 
            // DepartureConnections
            // 
            this.DepartureConnections.HeaderText = "Departure";
            this.DepartureConnections.Name = "DepartureConnections";
            this.DepartureConnections.ReadOnly = true;
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
            // dtSetTime
            // 
            this.dtSetTime.CustomFormat = "HH:mm";
            this.dtSetTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSetTime.Location = new System.Drawing.Point(40, 106);
            this.dtSetTime.Name = "dtSetTime";
            this.dtSetTime.Size = new System.Drawing.Size(452, 26);
            this.dtSetTime.TabIndex = 19;
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
            // ConnectionProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1316, 751);
            this.Controls.Add(this.fromAutoInputList);
            this.Controls.Add(this.dtSetTime);
            this.Controls.Add(this.toAutoInputList);
            this.Controls.Add(this.tbToStation);
            this.Controls.Add(this.btnToStationBoard);
            this.Controls.Add(this.btnFromStationBoard);
            this.Controls.Add(this.dgvStationBoard);
            this.Controls.Add(this.tbFromStation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dfvConnection);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ConnectionProgram";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dfvConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.DataGridView dfvConnection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFromStation;
        private System.Windows.Forms.ListBox fromAutoInputList;
        private System.Windows.Forms.DataGridView dgvStationBoard;
        private System.Windows.Forms.Button btnFromStationBoard;
        private System.Windows.Forms.Button btnToStationBoard;
        private System.Windows.Forms.TextBox tbToStation;
        private System.Windows.Forms.ListBox toAutoInputList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureConnections;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DateTimePicker dtSetTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureStationBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStationBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
    }
}

