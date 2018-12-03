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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectionButton = new System.Windows.Forms.Button();
            this.connectionView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.fromStationTextBox = new System.Windows.Forms.TextBox();
            this.fromAutoInputList = new System.Windows.Forms.ListBox();
            this.StationBoardView = new System.Windows.Forms.DataGridView();
            this.fromStationBoard = new System.Windows.Forms.Button();
            this.toStationBoard = new System.Windows.Forms.Button();
            this.toStationTextBox = new System.Windows.Forms.TextBox();
            this.toAutoInputList = new System.Windows.Forms.ListBox();
            this.DepartureConnections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureStationBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.connectionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StationBoardView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
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
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(652, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "To ...";
            // 
            // connectionButton
            // 
            this.connectionButton.BackColor = System.Drawing.Color.White;
            this.connectionButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.connectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.connectionButton.Location = new System.Drawing.Point(40, 112);
            this.connectionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(1224, 63);
            this.connectionButton.TabIndex = 9;
            this.connectionButton.Text = "FIND CONNECTIONS";
            this.connectionButton.UseVisualStyleBackColor = false;
            this.connectionButton.Click += new System.EventHandler(this.FindConnectionButton);
            // 
            // connectionView
            // 
            this.connectionView.AllowUserToAddRows = false;
            this.connectionView.AllowUserToDeleteRows = false;
            this.connectionView.AllowUserToResizeColumns = false;
            this.connectionView.AllowUserToResizeRows = false;
            this.connectionView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.connectionView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.connectionView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureConnections,
            this.From,
            this.Arrival,
            this.To,
            this.Duration});
            this.connectionView.GridColor = System.Drawing.SystemColors.Control;
            this.connectionView.Location = new System.Drawing.Point(40, 277);
            this.connectionView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionView.Name = "connectionView";
            this.connectionView.ReadOnly = true;
            this.connectionView.RowHeadersVisible = false;
            this.connectionView.RowHeadersWidth = 80;
            this.connectionView.Size = new System.Drawing.Size(1224, 435);
            this.connectionView.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Connections";
            // 
            // fromStationTextBox
            // 
            this.fromStationTextBox.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromStationTextBox.Location = new System.Drawing.Point(40, 56);
            this.fromStationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromStationTextBox.Name = "fromStationTextBox";
            this.fromStationTextBox.Size = new System.Drawing.Size(452, 42);
            this.fromStationTextBox.TabIndex = 12;
            this.fromStationTextBox.TextChanged += new System.EventHandler(this.FromStationTextBox_TextChanged);
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
            // StationBoardView
            // 
            this.StationBoardView.AllowUserToAddRows = false;
            this.StationBoardView.AllowUserToDeleteRows = false;
            this.StationBoardView.AllowUserToResizeColumns = false;
            this.StationBoardView.AllowUserToResizeRows = false;
            this.StationBoardView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StationBoardView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.StationBoardView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StationBoardView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StationBoardView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StationBoardView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureStationBoard,
            this.Name,
            this.Destination});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StationBoardView.DefaultCellStyle = dataGridViewCellStyle4;
            this.StationBoardView.GridColor = System.Drawing.SystemColors.Control;
            this.StationBoardView.Location = new System.Drawing.Point(40, 277);
            this.StationBoardView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StationBoardView.Name = "StationBoardView";
            this.StationBoardView.ReadOnly = true;
            this.StationBoardView.RowHeadersVisible = false;
            this.StationBoardView.RowHeadersWidth = 80;
            this.StationBoardView.Size = new System.Drawing.Size(1224, 435);
            this.StationBoardView.TabIndex = 14;
            this.StationBoardView.Visible = false;
            // 
            // fromStationBoard
            // 
            this.fromStationBoard.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fromStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fromStationBoard.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromStationBoard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fromStationBoard.Location = new System.Drawing.Point(500, 55);
            this.fromStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromStationBoard.Name = "fromStationBoard";
            this.fromStationBoard.Size = new System.Drawing.Size(150, 43);
            this.fromStationBoard.TabIndex = 15;
            this.fromStationBoard.Text = "STATIONBOARD";
            this.fromStationBoard.UseVisualStyleBackColor = false;
            this.fromStationBoard.Click += new System.EventHandler(this.ShowFromStationBoard);
            // 
            // toStationBoard
            // 
            this.toStationBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.toStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toStationBoard.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toStationBoard.ForeColor = System.Drawing.SystemColors.Control;
            this.toStationBoard.Location = new System.Drawing.Point(1118, 55);
            this.toStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toStationBoard.Name = "toStationBoard";
            this.toStationBoard.Size = new System.Drawing.Size(146, 43);
            this.toStationBoard.TabIndex = 16;
            this.toStationBoard.Text = "STATIONBOARD";
            this.toStationBoard.UseVisualStyleBackColor = false;
            this.toStationBoard.Click += new System.EventHandler(this.ShowToStationBoard);
            // 
            // toStationTextBox
            // 
            this.toStationTextBox.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toStationTextBox.Location = new System.Drawing.Point(658, 56);
            this.toStationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toStationTextBox.Name = "toStationTextBox";
            this.toStationTextBox.Size = new System.Drawing.Size(452, 42);
            this.toStationTextBox.TabIndex = 17;
            this.toStationTextBox.TextChanged += new System.EventHandler(this.ToStationTextBox_TextChanged);
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
            // DepartureStationBoard
            // 
            this.DepartureStationBoard.HeaderText = "Departure";
            this.DepartureStationBoard.Name = "DepartureStationBoard";
            this.DepartureStationBoard.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1316, 751);
            this.Controls.Add(this.toAutoInputList);
            this.Controls.Add(this.toStationTextBox);
            this.Controls.Add(this.fromAutoInputList);
            this.Controls.Add(this.toStationBoard);
            this.Controls.Add(this.fromStationBoard);
            this.Controls.Add(this.StationBoardView);
            this.Controls.Add(this.fromStationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.connectionView);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.connectionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StationBoardView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.DataGridView connectionView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fromStationTextBox;
        private System.Windows.Forms.ListBox fromAutoInputList;
        private System.Windows.Forms.DataGridView StationBoardView;
        private System.Windows.Forms.Button fromStationBoard;
        private System.Windows.Forms.Button toStationBoard;
        private System.Windows.Forms.TextBox toStationTextBox;
        private System.Windows.Forms.ListBox toAutoInputList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureConnections;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureStationBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
    }
}

