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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbDisplayPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridPlakjanje = new System.Windows.Forms.DataGridView();
            this.vidnaplataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacinNaplataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastTryDataSet = new Stores_db_task.lastTryDataSet();
            this.nacin_NaplataTableAdapter = new Stores_db_task.lastTryDataSetTableAdapters.Nacin_NaplataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlakjanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacinNaplataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastTryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDisplayPrice
            // 
            this.tbDisplayPrice.BackColor = System.Drawing.Color.Lime;
            this.tbDisplayPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDisplayPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplayPrice.Location = new System.Drawing.Point(172, 50);
            this.tbDisplayPrice.Name = "tbDisplayPrice";
            this.tbDisplayPrice.Size = new System.Drawing.Size(169, 45);
            this.tbDisplayPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(188, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ЗА НАПЛАТА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(89, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "ИЗБЕРЕТЕ НАЧИН НА ПЛАЌАЊЕ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(102, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(297, 65);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "ПЛАТИ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridPlakjanje
            // 
            this.dataGridPlakjanje.AutoGenerateColumns = false;
            this.dataGridPlakjanje.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridPlakjanje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPlakjanje.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridPlakjanje.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridPlakjanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlakjanje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vidnaplataDataGridViewTextBoxColumn,
            this.iznos});
            this.dataGridPlakjanje.DataSource = this.nacinNaplataBindingSource;
            this.dataGridPlakjanje.Location = new System.Drawing.Point(50, 162);
            this.dataGridPlakjanje.Name = "dataGridPlakjanje";
            this.dataGridPlakjanje.RowHeadersWidth = 51;
            this.dataGridPlakjanje.RowTemplate.Height = 24;
            this.dataGridPlakjanje.Size = new System.Drawing.Size(401, 190);
            this.dataGridPlakjanje.TabIndex = 22;
            this.dataGridPlakjanje.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPlakjanje_CellValueChanged);
            // 
            // vidnaplataDataGridViewTextBoxColumn
            // 
            this.vidnaplataDataGridViewTextBoxColumn.DataPropertyName = "vid_naplata";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vidnaplataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.vidnaplataDataGridViewTextBoxColumn.HeaderText = "НАЧИН НА ПЛАЌАЊЕ";
            this.vidnaplataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vidnaplataDataGridViewTextBoxColumn.Name = "vidnaplataDataGridViewTextBoxColumn";
            this.vidnaplataDataGridViewTextBoxColumn.Width = 125;
            // 
            // iznos
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.iznos.DefaultCellStyle = dataGridViewCellStyle2;
            this.iznos.HeaderText = "ИЗНОС";
            this.iznos.MinimumWidth = 6;
            this.iznos.Name = "iznos";
            this.iznos.Width = 125;
            // 
            // nacinNaplataBindingSource
            // 
            this.nacinNaplataBindingSource.DataMember = "Nacin_Naplata";
            this.nacinNaplataBindingSource.DataSource = this.lastTryDataSet;
            // 
            // lastTryDataSet
            // 
            this.lastTryDataSet.DataSetName = "lastTryDataSet";
            this.lastTryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nacin_NaplataTableAdapter
            // 
            this.nacin_NaplataTableAdapter.ClearBeforeFill = true;
            // 
            // nacinPlakjanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(574, 504);
            this.Controls.Add(this.dataGridPlakjanje);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDisplayPrice);
            this.Name = "nacinPlakjanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вид наплата";
            this.Load += new System.EventHandler(this.nacinPlakjanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlakjanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacinNaplataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastTryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDisplayPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridPlakjanje;
        private lastTryDataSet lastTryDataSet;
        private System.Windows.Forms.BindingSource nacinNaplataBindingSource;
        private lastTryDataSetTableAdapters.Nacin_NaplataTableAdapter nacin_NaplataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidnaplataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos;
    }
}