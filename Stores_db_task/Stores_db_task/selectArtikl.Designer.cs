namespace Stores_db_task
{
    partial class selectArtikl
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
            this.lbArtikli = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbArtikli
            // 
            this.lbArtikli.BackColor = System.Drawing.SystemColors.Control;
            this.lbArtikli.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtikli.FormattingEnabled = true;
            this.lbArtikli.ItemHeight = 29;
            this.lbArtikli.Location = new System.Drawing.Point(25, 12);
            this.lbArtikli.Name = "lbArtikli";
            this.lbArtikli.Size = new System.Drawing.Size(460, 613);
            this.lbArtikli.Sorted = true;
            this.lbArtikli.TabIndex = 0;
            
            this.lbArtikli.DoubleClick += new System.EventHandler(this.lbArtikli_DoubleClick);
            this.lbArtikli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbArtikli_KeyPress);
            // 
            // selectArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(525, 691);
            this.Controls.Add(this.lbArtikli);
            this.Name = "selectArtikl";
            this.Text = "Артикли";
            this.Load += new System.EventHandler(this.selectArtikl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbArtikli;
    }
}