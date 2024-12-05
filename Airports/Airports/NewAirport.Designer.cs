namespace Airports
{
    partial class NewAirport
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
            this.components = new System.ComponentModel.Container();
            this.tbCityName = new System.Windows.Forms.TextBox();
            this.tbAirportName = new System.Windows.Forms.TextBox();
            this.tbShort = new System.Windows.Forms.TextBox();
            this.btnSaveAirport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCityName
            // 
            this.tbCityName.Location = new System.Drawing.Point(16, 41);
            this.tbCityName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCityName.Name = "tbCityName";
            this.tbCityName.Size = new System.Drawing.Size(329, 22);
            this.tbCityName.TabIndex = 0;
            this.tbCityName.Validating += new System.ComponentModel.CancelEventHandler(this.tbCityName_Validating);
            // 
            // tbAirportName
            // 
            this.tbAirportName.Location = new System.Drawing.Point(16, 105);
            this.tbAirportName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAirportName.Name = "tbAirportName";
            this.tbAirportName.Size = new System.Drawing.Size(329, 22);
            this.tbAirportName.TabIndex = 1;
            this.tbAirportName.Validating += new System.ComponentModel.CancelEventHandler(this.tbAirportName_Validating);
            // 
            // tbShort
            // 
            this.tbShort.Location = new System.Drawing.Point(16, 162);
            this.tbShort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbShort.Name = "tbShort";
            this.tbShort.Size = new System.Drawing.Size(117, 22);
            this.tbShort.TabIndex = 2;
            this.tbShort.Validating += new System.ComponentModel.CancelEventHandler(this.tbShort_Validating);
            // 
            // btnSaveAirport
            // 
            this.btnSaveAirport.Location = new System.Drawing.Point(16, 217);
            this.btnSaveAirport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveAirport.Name = "btnSaveAirport";
            this.btnSaveAirport.Size = new System.Drawing.Size(119, 28);
            this.btnSaveAirport.TabIndex = 3;
            this.btnSaveAirport.Text = "Save";
            this.btnSaveAirport.UseVisualStyleBackColor = true;
            this.btnSaveAirport.Click += new System.EventHandler(this.btnSaveAirport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(159, 217);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Abbrevation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "City";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewAirport
            // 
            this.AcceptButton = this.btnSaveAirport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveAirport);
            this.Controls.Add(this.tbShort);
            this.Controls.Add(this.tbAirportName);
            this.Controls.Add(this.tbCityName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewAirport";
            this.Text = "Add airport";
            this.Load += new System.EventHandler(this.NewAirport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCityName;
        private System.Windows.Forms.TextBox tbAirportName;
        private System.Windows.Forms.TextBox tbShort;
        private System.Windows.Forms.Button btnSaveAirport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}