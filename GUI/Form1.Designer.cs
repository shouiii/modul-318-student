namespace GUI
{
    partial class Form1
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
            this.connectionsListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Von ...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nach ...";
            // 
            // fromStationComboBox
            // 
            this.fromStationComboBox.FormattingEnabled = true;
            this.fromStationComboBox.Location = new System.Drawing.Point(31, 52);
            this.fromStationComboBox.Name = "fromStationComboBox";
            this.fromStationComboBox.Size = new System.Drawing.Size(303, 21);
            this.fromStationComboBox.TabIndex = 4;
            // 
            // toStationComboBox
            // 
            this.toStationComboBox.FormattingEnabled = true;
            this.toStationComboBox.Location = new System.Drawing.Point(443, 52);
            this.toStationComboBox.Name = "toStationComboBox";
            this.toStationComboBox.Size = new System.Drawing.Size(303, 21);
            this.toStationComboBox.TabIndex = 5;
            // 
            // findStartStation
            // 
            this.findStartStation.Location = new System.Drawing.Point(340, 52);
            this.findStartStation.Name = "findStartStation";
            this.findStartStation.Size = new System.Drawing.Size(42, 23);
            this.findStartStation.TabIndex = 6;
            this.findStartStation.Text = "FIND";
            this.findStartStation.UseVisualStyleBackColor = true;
            this.findStartStation.Click += new System.EventHandler(this.showFromStationsButton);
            // 
            // findEndStation
            // 
            this.findEndStation.Location = new System.Drawing.Point(752, 52);
            this.findEndStation.Name = "findEndStation";
            this.findEndStation.Size = new System.Drawing.Size(42, 23);
            this.findEndStation.TabIndex = 7;
            this.findEndStation.Text = "FIND";
            this.findEndStation.UseVisualStyleBackColor = true;
            this.findEndStation.Click += new System.EventHandler(this.showToStationsButton);
            // 
            // connectionsListBox
            // 
            this.connectionsListBox.FormattingEnabled = true;
            this.connectionsListBox.Location = new System.Drawing.Point(31, 157);
            this.connectionsListBox.Name = "connectionsListBox";
            this.connectionsListBox.Size = new System.Drawing.Size(351, 290);
            this.connectionsListBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(763, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Verbindungen suchen";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.findConnectionsButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connectionsListBox);
            this.Controls.Add(this.findEndStation);
            this.Controls.Add(this.findStartStation);
            this.Controls.Add(this.toStationComboBox);
            this.Controls.Add(this.fromStationComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ListBox connectionsListBox;
        private System.Windows.Forms.Button button1;
    }
}

