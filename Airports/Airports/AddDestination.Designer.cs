namespace Airports
{
    partial class AddDestination
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
            this.tbDestinationName = new System.Windows.Forms.TextBox();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDestinationName
            // 
            this.tbDestinationName.Location = new System.Drawing.Point(13, 52);
            this.tbDestinationName.Margin = new System.Windows.Forms.Padding(4);
            this.tbDestinationName.Name = "tbDestinationName";
            this.tbDestinationName.Size = new System.Drawing.Size(291, 22);
            this.tbDestinationName.TabIndex = 1;
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(16, 101);
            this.nudLength.Margin = new System.Windows.Forms.Padding(4);
            this.nudLength.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.nudLength.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(160, 22);
            this.nudLength.TabIndex = 2;
            this.nudLength.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(16, 148);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nudPrice.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.nudPrice.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(160, 22);
            this.nudPrice.TabIndex = 3;
            this.nudPrice.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPrice.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(16, 198);
            this.btnAddDestination.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(119, 28);
            this.btnAddDestination.TabIndex = 4;
            this.btnAddDestination.Text = "Add destination";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 198);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price";
            // 
            // AddDestination
            // 
            this.AcceptButton = this.btnAddDestination;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.tbDestinationName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDestination";
            this.Text = "New destinatioon";
            this.Load += new System.EventHandler(this.AddDestination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDestinationName;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}