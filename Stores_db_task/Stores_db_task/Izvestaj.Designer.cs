namespace Stores_db_task
{
    partial class Izvestaj
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Izvestaj));
            this.dataGridIzvestaj = new System.Windows.Forms.DataGridView();
            this.labelKasier = new System.Windows.Forms.Label();
            this.labelMarketName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMarket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kasierTextBox = new System.Windows.Forms.TextBox();
            this.tbDatumOd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDatumDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.id_smetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeArtikl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumProdazba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vkupnoCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIzvestaj)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridIzvestaj
            // 
            this.dataGridIzvestaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridIzvestaj.BackgroundColor = System.Drawing.Color.White;
            this.dataGridIzvestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIzvestaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_smetka,
            this.shifra,
            this.imeArtikl,
            this.datumProdazba,
            this.kolicina,
            this.price,
            this.procent,
            this.vkupnoCena});
            this.dataGridIzvestaj.Location = new System.Drawing.Point(60, 179);
            this.dataGridIzvestaj.Name = "dataGridIzvestaj";
            this.dataGridIzvestaj.RowHeadersWidth = 51;
            this.dataGridIzvestaj.RowTemplate.Height = 24;
            this.dataGridIzvestaj.Size = new System.Drawing.Size(1255, 498);
            this.dataGridIzvestaj.TabIndex = 0;
            this.dataGridIzvestaj.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridIzvestaj_CellValueChanged);
            // 
            // labelKasier
            // 
            this.labelKasier.AutoSize = true;
            this.labelKasier.BackColor = System.Drawing.SystemColors.Control;
            this.labelKasier.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKasier.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelKasier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKasier.Location = new System.Drawing.Point(883, 107);
            this.labelKasier.Name = "labelKasier";
            this.labelKasier.Size = new System.Drawing.Size(0, 22);
            this.labelKasier.TabIndex = 21;
            // 
            // labelMarketName
            // 
            this.labelMarketName.AutoSize = true;
            this.labelMarketName.BackColor = System.Drawing.SystemColors.Control;
            this.labelMarketName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelMarketName.ForeColor = System.Drawing.Color.Black;
            this.labelMarketName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMarketName.Location = new System.Drawing.Point(185, 74);
            this.labelMarketName.Name = "labelMarketName";
            this.labelMarketName.Size = new System.Drawing.Size(0, 26);
            this.labelMarketName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(37, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "МАРКЕТ";
            // 
            // tbMarket
            // 
            this.tbMarket.BackColor = System.Drawing.Color.Lime;
            this.tbMarket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbMarket.Location = new System.Drawing.Point(119, 70);
            this.tbMarket.Name = "tbMarket";
            this.tbMarket.PasswordChar = '*';
            this.tbMarket.Size = new System.Drawing.Size(59, 30);
            this.tbMarket.TabIndex = 2;
            this.tbMarket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMarket_KeyDown);
            this.tbMarket.Validating += new System.ComponentModel.CancelEventHandler(this.tbMarket_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "КАСИЕР";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "ДАТУМ ОД";
            // 
            // kasierTextBox
            // 
            this.kasierTextBox.BackColor = System.Drawing.Color.Lime;
            this.kasierTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kasierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kasierTextBox.Location = new System.Drawing.Point(119, 118);
            this.kasierTextBox.Name = "kasierTextBox";
            this.kasierTextBox.PasswordChar = '*';
            this.kasierTextBox.Size = new System.Drawing.Size(59, 30);
            this.kasierTextBox.TabIndex = 3;
            this.kasierTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kasierTextBox_KeyDown);
            this.kasierTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.kasierTextBox_Validating);
            // 
            // tbDatumOd
            // 
            this.tbDatumOd.BackColor = System.Drawing.Color.Lime;
            this.tbDatumOd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDatumOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbDatumOd.Location = new System.Drawing.Point(119, 28);
            this.tbDatumOd.Name = "tbDatumOd";
            this.tbDatumOd.Size = new System.Drawing.Size(205, 27);
            this.tbDatumOd.TabIndex = 0;
            this.tbDatumOd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDatumOd_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(328, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "ДО";
            // 
            // tbDatumDo
            // 
            this.tbDatumDo.BackColor = System.Drawing.Color.Lime;
            this.tbDatumDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDatumDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbDatumDo.Location = new System.Drawing.Point(366, 28);
            this.tbDatumDo.Name = "tbDatumDo";
            this.tbDatumDo.Size = new System.Drawing.Size(205, 27);
            this.tbDatumDo.TabIndex = 1;
            this.tbDatumDo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDatumDo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(10, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "ЗА";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(1080, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 74);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "ПЕЧАТИ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Snow;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(569, 687);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(227, 74);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "РЕСЕТ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(881, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "ВКУПНО ПРОМЕТ:";
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.Lime;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.tbPrice.Location = new System.Drawing.Point(1080, 127);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(231, 38);
            this.tbPrice.TabIndex = 27;
            // 
            // id_smetka
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_smetka.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_smetka.HeaderText = "БР.СМЕТКА";
            this.id_smetka.MinimumWidth = 6;
            this.id_smetka.Name = "id_smetka";
            // 
            // shifra
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shifra.DefaultCellStyle = dataGridViewCellStyle2;
            this.shifra.HeaderText = "ШИФРА";
            this.shifra.MinimumWidth = 6;
            this.shifra.Name = "shifra";
            // 
            // imeArtikl
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeArtikl.DefaultCellStyle = dataGridViewCellStyle3;
            this.imeArtikl.HeaderText = "АРТИКЛ";
            this.imeArtikl.MinimumWidth = 6;
            this.imeArtikl.Name = "imeArtikl";
            // 
            // datumProdazba
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumProdazba.DefaultCellStyle = dataGridViewCellStyle4;
            this.datumProdazba.HeaderText = "ДАТУМ НА ПРОДАЖБА";
            this.datumProdazba.MinimumWidth = 6;
            this.datumProdazba.Name = "datumProdazba";
            // 
            // kolicina
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolicina.DefaultCellStyle = dataGridViewCellStyle5;
            this.kolicina.HeaderText = "КОЛИЧИНА";
            this.kolicina.MinimumWidth = 6;
            this.kolicina.Name = "kolicina";
            // 
            // price
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.DefaultCellStyle = dataGridViewCellStyle6;
            this.price.HeaderText = "ЦЕНА";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // procent
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procent.DefaultCellStyle = dataGridViewCellStyle7;
            this.procent.HeaderText = "НАПЛАТЕН ПРОЦЕНТ";
            this.procent.MinimumWidth = 6;
            this.procent.Name = "procent";
            // 
            // vkupnoCena
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vkupnoCena.DefaultCellStyle = dataGridViewCellStyle8;
            this.vkupnoCena.HeaderText = "ПРОМЕТ ПО АРТИКЛ";
            this.vkupnoCena.MinimumWidth = 6;
            this.vkupnoCena.Name = "vkupnoCena";
            // 
            // Izvestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 773);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDatumDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelKasier);
            this.Controls.Add(this.labelMarketName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMarket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kasierTextBox);
            this.Controls.Add(this.tbDatumOd);
            this.Controls.Add(this.dataGridIzvestaj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Izvestaj";
            this.Text = "Извештај";
            this.Load += new System.EventHandler(this.Izvestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIzvestaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridIzvestaj;
        private System.Windows.Forms.Label labelKasier;
        private System.Windows.Forms.Label labelMarketName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMarket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kasierTextBox;
        private System.Windows.Forms.TextBox tbDatumOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDatumDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_smetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn shifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeArtikl;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumProdazba;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn procent;
        private System.Windows.Forms.DataGridViewTextBoxColumn vkupnoCena;
    }
}