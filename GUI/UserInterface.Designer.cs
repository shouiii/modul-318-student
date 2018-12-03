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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectionButton = new System.Windows.Forms.Button();
            this.connectionView = new System.Windows.Forms.DataGridView();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.fromStationTextBox = new System.Windows.Forms.TextBox();
            this.fromAutoInputList = new System.Windows.Forms.ListBox();
            this.StationBoardView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromStationBoard = new System.Windows.Forms.Button();
            this.toStationBoard = new System.Windows.Forms.Button();
            this.toStationTextBox = new System.Windows.Forms.TextBox();
            this.toAutoInputList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.connectionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StationBoardView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "From ...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "To ...";
            // 
            // connectionButton
            // 
            this.connectionButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.connectionButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.connectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.connectionButton.Location = new System.Drawing.Point(46, 138);
            this.connectionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(1205, 63);
            this.connectionButton.TabIndex = 9;
            this.connectionButton.Text = "Find connections";
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
            this.connectionView.Size = new System.Drawing.Size(1205, 435);
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
            this.label4.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Connections";
            // 
            // fromStationTextBox
            // 
            this.fromStationTextBox.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromStationTextBox.Location = new System.Drawing.Point(46, 82);
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
            this.fromAutoInputList.Location = new System.Drawing.Point(46, 124);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StationBoardView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StationBoardView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StationBoardView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Name,
            this.Destination});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StationBoardView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StationBoardView.Location = new System.Drawing.Point(46, 303);
            this.StationBoardView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StationBoardView.Name = "StationBoardView";
            this.StationBoardView.ReadOnly = true;
            this.StationBoardView.RowHeadersVisible = false;
            this.StationBoardView.RowHeadersWidth = 80;
            this.StationBoardView.Size = new System.Drawing.Size(1205, 435);
            this.StationBoardView.TabIndex = 14;
            this.StationBoardView.Visible = false;
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
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // fromStationBoard
            // 
            this.fromStationBoard.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fromStationBoard.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromStationBoard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fromStationBoard.Location = new System.Drawing.Point(506, 81);
            this.fromStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromStationBoard.Name = "fromStationBoard";
            this.fromStationBoard.Size = new System.Drawing.Size(127, 42);
            this.fromStationBoard.TabIndex = 15;
            this.fromStationBoard.Text = "Stationboard";
            this.fromStationBoard.UseVisualStyleBackColor = false;
            this.fromStationBoard.Click += new System.EventHandler(this.ShowFromStationBoard);
            // 
            // toStationBoard
            // 
            this.toStationBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.toStationBoard.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toStationBoard.ForeColor = System.Drawing.SystemColors.Control;
            this.toStationBoard.Location = new System.Drawing.Point(1124, 81);
            this.toStationBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toStationBoard.Name = "toStationBoard";
            this.toStationBoard.Size = new System.Drawing.Size(127, 42);
            this.toStationBoard.TabIndex = 16;
            this.toStationBoard.Text = "Stationboard";
            this.toStationBoard.UseVisualStyleBackColor = false;
            this.toStationBoard.Click += new System.EventHandler(this.ShowToStationBoard);
            // 
            // toStationTextBox
            // 
            this.toStationTextBox.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toStationTextBox.Location = new System.Drawing.Point(664, 82);
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
            this.toAutoInputList.Location = new System.Drawing.Point(664, 121);
            this.toAutoInputList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toAutoInputList.Name = "toAutoInputList";
            this.toAutoInputList.Size = new System.Drawing.Size(452, 124);
            this.toAutoInputList.TabIndex = 18;
            this.toAutoInputList.Visible = false;
            this.toAutoInputList.Click += new System.EventHandler(this.ToClickAutoInput);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 805);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fromStationTextBox;
        private System.Windows.Forms.ListBox fromAutoInputList;
        private System.Windows.Forms.DataGridView StationBoardView;
        private System.Windows.Forms.Button fromStationBoard;
        private System.Windows.Forms.Button toStationBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.TextBox toStationTextBox;
        private System.Windows.Forms.ListBox toAutoInputList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
    }
}

