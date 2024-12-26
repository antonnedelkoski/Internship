namespace Stores_db_task
{
    partial class nacinPlakjanje
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
            this.lbNaplata = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbNaplata
            // 
            this.lbNaplata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbNaplata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNaplata.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaplata.FormattingEnabled = true;
            this.lbNaplata.ItemHeight = 36;
            this.lbNaplata.Location = new System.Drawing.Point(0, 23);
            this.lbNaplata.Name = "lbNaplata";
            this.lbNaplata.Size = new System.Drawing.Size(329, 144);
            this.lbNaplata.TabIndex = 0;
            this.lbNaplata.SelectedIndexChanged += new System.EventHandler(this.lbNaplata_SelectedIndexChanged);
            this.lbNaplata.DoubleClick += new System.EventHandler(this.lbNaplata_DoubleClick);
            this.lbNaplata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbNaplata_KeyPress);
            // 
            // nacinPlakjanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(329, 233);
            this.Controls.Add(this.lbNaplata);
            this.Name = "nacinPlakjanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вид наплата";
            this.Load += new System.EventHandler(this.nacinPlakjanje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNaplata;
    }
}