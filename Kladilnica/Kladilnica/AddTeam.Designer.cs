namespace Kladilnica
{
    partial class AddTeam
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
            this.tbAddTeamName = new System.Windows.Forms.TextBox();
            this.tbAddTeamCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTeamConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAddTeamName
            // 
            this.tbAddTeamName.Location = new System.Drawing.Point(25, 31);
            this.tbAddTeamName.Name = "tbAddTeamName";
            this.tbAddTeamName.Size = new System.Drawing.Size(176, 20);
            this.tbAddTeamName.TabIndex = 0;
            // 
            // tbAddTeamCountry
            // 
            this.tbAddTeamCountry.Location = new System.Drawing.Point(25, 81);
            this.tbAddTeamCountry.Name = "tbAddTeamCountry";
            this.tbAddTeamCountry.Size = new System.Drawing.Size(176, 20);
            this.tbAddTeamCountry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "тимот доаѓа од";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "име на тимот";
            // 
            // btnAddTeamConfirm
            // 
            this.btnAddTeamConfirm.Location = new System.Drawing.Point(25, 123);
            this.btnAddTeamConfirm.Name = "btnAddTeamConfirm";
            this.btnAddTeamConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeamConfirm.TabIndex = 4;
            this.btnAddTeamConfirm.Text = "Додади";
            this.btnAddTeamConfirm.UseVisualStyleBackColor = true;
            this.btnAddTeamConfirm.Click += new System.EventHandler(this.btnAddTeamConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(126, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 175);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTeamConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddTeamCountry);
            this.Controls.Add(this.tbAddTeamName);
            this.Name = "AddTeam";
            this.Text = "Додади тим";
            this.Load += new System.EventHandler(this.AddTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddTeamName;
        private System.Windows.Forms.TextBox tbAddTeamCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTeamConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}