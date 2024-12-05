namespace Airports
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
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMostExpensiveDest = new System.Windows.Forms.TextBox();
            this.tbAvgLengthDest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.ItemHeight = 16;
            this.lbAirports.Location = new System.Drawing.Point(27, 28);
            this.lbAirports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(209, 260);
            this.lbAirports.TabIndex = 0;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            this.lbAirports.SelectedValueChanged += new System.EventHandler(this.lbAirports_SelectedValueChanged);
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.ItemHeight = 16;
            this.lbDestinations.Location = new System.Drawing.Point(291, 28);
            this.lbDestinations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(245, 260);
            this.lbDestinations.TabIndex = 1;
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(27, 320);
            this.btnAddAirport.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(211, 28);
            this.btnAddAirport.TabIndex = 2;
            this.btnAddAirport.Text = "Add Airport";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(27, 373);
            this.btnDeleteAirport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(211, 28);
            this.btnDeleteAirport.TabIndex = 3;
            this.btnDeleteAirport.Text = "Delete airport";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(27, 422);
            this.btnAddDestination.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(211, 28);
            this.btnAddDestination.TabIndex = 4;
            this.btnAddDestination.Text = "Add destination";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Airports";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destinations";
            // 
            // tbMostExpensiveDest
            // 
            this.tbMostExpensiveDest.Enabled = false;
            this.tbMostExpensiveDest.Location = new System.Drawing.Point(291, 322);
            this.tbMostExpensiveDest.Margin = new System.Windows.Forms.Padding(4);
            this.tbMostExpensiveDest.Name = "tbMostExpensiveDest";
            this.tbMostExpensiveDest.Size = new System.Drawing.Size(305, 22);
            this.tbMostExpensiveDest.TabIndex = 10;
            // 
            // tbAvgLengthDest
            // 
            this.tbAvgLengthDest.Enabled = false;
            this.tbAvgLengthDest.Location = new System.Drawing.Point(291, 377);
            this.tbAvgLengthDest.Margin = new System.Windows.Forms.Padding(4);
            this.tbAvgLengthDest.Name = "tbAvgLengthDest";
            this.tbAvgLengthDest.Size = new System.Drawing.Size(305, 22);
            this.tbAvgLengthDest.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Most Expensive Destination";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 357);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Average Length of destinations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 485);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAvgLengthDest);
            this.Controls.Add(this.tbMostExpensiveDest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.lbAirports);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMostExpensiveDest;
        private System.Windows.Forms.TextBox tbAvgLengthDest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

