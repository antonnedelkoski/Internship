namespace Stores_db_task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datumTextBox = new System.Windows.Forms.TextBox();
            this.kasierTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridTest = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMarket = new System.Windows.Forms.TextBox();
            this.labelMarketName = new System.Windows.Forms.Label();
            this.labelKasier = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPopust = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTest)).BeginInit();
            this.SuspendLayout();
            // 
            // datumTextBox
            // 
            this.datumTextBox.BackColor = System.Drawing.Color.Lime;
            this.datumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.datumTextBox, "datumTextBox");
            this.datumTextBox.Name = "datumTextBox";
            // 
            // kasierTextBox
            // 
            this.kasierTextBox.BackColor = System.Drawing.Color.Lime;
            this.kasierTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.kasierTextBox, "kasierTextBox");
            this.kasierTextBox.Name = "kasierTextBox";
            this.kasierTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kasierTextBox_KeyDown);
            this.kasierTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.kasierTextBox_Validating);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.Lime;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tbPrice, "tbPrice");
            this.tbPrice.Name = "tbPrice";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // dataGridTest
            // 
            this.dataGridTest.AllowDrop = true;
            this.dataGridTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTest.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridTest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shifra,
            this.articleName,
            this.kolicina,
            this.popust,
            this.price});
            this.dataGridTest.GridColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.dataGridTest, "dataGridTest");
            this.dataGridTest.Name = "dataGridTest";
            this.dataGridTest.RowTemplate.Height = 24;
            this.dataGridTest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTest_CellDoubleClick);

            this.dataGridTest.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTest_CellValueChanged);
            this.dataGridTest.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTest_RowEnter);
            this.dataGridTest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridTest_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbMarket
            // 
            this.tbMarket.BackColor = System.Drawing.Color.Lime;
            this.tbMarket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tbMarket, "tbMarket");
            this.tbMarket.Name = "tbMarket";
            this.tbMarket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMarket_KeyDown);
            this.tbMarket.Validating += new System.ComponentModel.CancelEventHandler(this.tbMarket_Validating);
            // 
            // labelMarketName
            // 
            resources.ApplyResources(this.labelMarketName, "labelMarketName");
            this.labelMarketName.BackColor = System.Drawing.SystemColors.Control;
            this.labelMarketName.ForeColor = System.Drawing.Color.Green;
            this.labelMarketName.Name = "labelMarketName";
            // 
            // labelKasier
            // 
            resources.ApplyResources(this.labelKasier, "labelKasier");
            this.labelKasier.BackColor = System.Drawing.SystemColors.Control;
            this.labelKasier.ForeColor = System.Drawing.Color.Green;
            this.labelKasier.Name = "labelKasier";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tbPopust
            // 
            this.tbPopust.BackColor = System.Drawing.Color.Lime;
            this.tbPopust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tbPopust, "tbPopust");
            this.tbPopust.Name = "tbPopust";
            this.tbPopust.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPopust_KeyDown);
            this.tbPopust.Validating += new System.ComponentModel.CancelEventHandler(this.tbPopust_Validating);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Name = "label6";
            // 
            // shifra
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shifra.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.shifra, "shifra");
            this.shifra.Name = "shifra";
            // 
            // articleName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleName.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.articleName, "articleName");
            this.articleName.Name = "articleName";
            // 
            // kolicina
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolicina.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.kolicina, "kolicina");
            this.kolicina.Name = "kolicina";
            // 
            // popust
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popust.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.popust, "popust");
            this.popust.Name = "popust";
            // 
            // price
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.price, "price");
            this.price.Name = "price";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPopust);
            this.Controls.Add(this.labelKasier);
            this.Controls.Add(this.labelMarketName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMarket);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kasierTextBox);
            this.Controls.Add(this.datumTextBox);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox datumTextBox;
        private System.Windows.Forms.TextBox kasierTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridTest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMarket;
        private System.Windows.Forms.Label labelMarketName;
        private System.Windows.Forms.Label labelKasier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPopust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn shifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn popust;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

