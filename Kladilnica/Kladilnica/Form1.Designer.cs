namespace Kladilnica
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
            this.lbBilten = new System.Windows.Forms.ListBox();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.lbTicket = new System.Windows.Forms.ListBox();
            this.nudKec = new System.Windows.Forms.NumericUpDown();
            this.nudNereseno = new System.Windows.Forms.NumericUpDown();
            this.nudDvojka = new System.Windows.Forms.NumericUpDown();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btnAddToBilten = new System.Windows.Forms.Button();
            this.btnAddNewTeam = new System.Windows.Forms.Button();
            this.tbCodeBilten = new System.Windows.Forms.TextBox();
            this.cbSelectTip = new System.Windows.Forms.ComboBox();
            this.btnAddNewMatch = new System.Windows.Forms.Button();
            this.tbCoef = new System.Windows.Forms.TextBox();
            this.nudStake = new System.Windows.Forms.NumericUpDown();
            this.tbIncome = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudKec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNereseno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDvojka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStake)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBilten
            // 
            this.lbBilten.FormattingEnabled = true;
            this.lbBilten.Location = new System.Drawing.Point(220, 27);
            this.lbBilten.Name = "lbBilten";
            this.lbBilten.Size = new System.Drawing.Size(194, 238);
            this.lbBilten.TabIndex = 0;
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.Location = new System.Drawing.Point(22, 28);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTeams.Size = new System.Drawing.Size(176, 238);
            this.lbTeams.TabIndex = 1;
            // 
            // lbTicket
            // 
            this.lbTicket.FormattingEnabled = true;
            this.lbTicket.Location = new System.Drawing.Point(445, 27);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(178, 238);
            this.lbTicket.TabIndex = 2;
            // 
            // nudKec
            // 
            this.nudKec.Location = new System.Drawing.Point(40, 315);
            this.nudKec.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            this.nudKec.Name = "nudKec";
            this.nudKec.Size = new System.Drawing.Size(86, 20);
            this.nudKec.TabIndex = 3;
            this.nudKec.Value = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            // 
            // nudNereseno
            // 
            this.nudNereseno.Location = new System.Drawing.Point(40, 341);
            this.nudNereseno.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            this.nudNereseno.Name = "nudNereseno";
            this.nudNereseno.Size = new System.Drawing.Size(86, 20);
            this.nudNereseno.TabIndex = 4;
            this.nudNereseno.Value = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            // 
            // nudDvojka
            // 
            this.nudDvojka.Location = new System.Drawing.Point(40, 367);
            this.nudDvojka.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            this.nudDvojka.Name = "nudDvojka";
            this.nudDvojka.Size = new System.Drawing.Size(86, 20);
            this.nudDvojka.TabIndex = 5;
            this.nudDvojka.Value = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(58, 393);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(77, 20);
            this.tbCode.TabIndex = 6;
            // 
            // btnAddToBilten
            // 
            this.btnAddToBilten.Location = new System.Drawing.Point(22, 419);
            this.btnAddToBilten.Name = "btnAddToBilten";
            this.btnAddToBilten.Size = new System.Drawing.Size(152, 23);
            this.btnAddToBilten.TabIndex = 7;
            this.btnAddToBilten.Text = "Додади во билтен";
            this.btnAddToBilten.UseVisualStyleBackColor = true;
            this.btnAddToBilten.Click += new System.EventHandler(this.btnAddToBilten_Click);
            // 
            // btnAddNewTeam
            // 
            this.btnAddNewTeam.Location = new System.Drawing.Point(22, 448);
            this.btnAddNewTeam.Name = "btnAddNewTeam";
            this.btnAddNewTeam.Size = new System.Drawing.Size(152, 23);
            this.btnAddNewTeam.TabIndex = 8;
            this.btnAddNewTeam.Text = "Додади нов тим";
            this.btnAddNewTeam.UseVisualStyleBackColor = true;
            this.btnAddNewTeam.Click += new System.EventHandler(this.btnAddNewTeam_Click);
            // 
            // tbCodeBilten
            // 
            this.tbCodeBilten.Location = new System.Drawing.Point(226, 327);
            this.tbCodeBilten.Name = "tbCodeBilten";
            this.tbCodeBilten.Size = new System.Drawing.Size(134, 20);
            this.tbCodeBilten.TabIndex = 9;
            // 
            // cbSelectTip
            // 
            this.cbSelectTip.FormattingEnabled = true;
            this.cbSelectTip.Items.AddRange(new object[] {
            "1",
            "X",
            "2"});
            this.cbSelectTip.Location = new System.Drawing.Point(226, 379);
            this.cbSelectTip.Name = "cbSelectTip";
            this.cbSelectTip.Size = new System.Drawing.Size(121, 21);
            this.cbSelectTip.TabIndex = 10;
            // 
            // btnAddNewMatch
            // 
            this.btnAddNewMatch.Location = new System.Drawing.Point(226, 432);
            this.btnAddNewMatch.Name = "btnAddNewMatch";
            this.btnAddNewMatch.Size = new System.Drawing.Size(152, 23);
            this.btnAddNewMatch.TabIndex = 11;
            this.btnAddNewMatch.Text = "Додади натпревар";
            this.btnAddNewMatch.UseVisualStyleBackColor = true;
            this.btnAddNewMatch.Click += new System.EventHandler(this.btnAddNewMatch_Click);
            // 
            // tbCoef
            // 
            this.tbCoef.Enabled = false;
            this.tbCoef.Location = new System.Drawing.Point(470, 308);
            this.tbCoef.Name = "tbCoef";
            this.tbCoef.Size = new System.Drawing.Size(134, 20);
            this.tbCoef.TabIndex = 12;
            // 
            // nudStake
            // 
            this.nudStake.Location = new System.Drawing.Point(470, 348);
            this.nudStake.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudStake.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudStake.Name = "nudStake";
            this.nudStake.Size = new System.Drawing.Size(134, 20);
            this.nudStake.TabIndex = 13;
            this.nudStake.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudStake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudStake_KeyDown);
            this.nudStake.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudStake_KeyUp);
            // 
            // tbIncome
            // 
            this.tbIncome.Enabled = false;
            this.tbIncome.Location = new System.Drawing.Point(470, 396);
            this.tbIncome.Name = "tbIncome";
            this.tbIncome.Size = new System.Drawing.Size(134, 20);
            this.tbIncome.TabIndex = 14;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(463, 435);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(141, 23);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Печати";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Листа на тимови";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Билтен";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Тикет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label4.Location = new System.Drawing.Point(469, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "Уплати тикет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Шифра";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Избери тип";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label8.Location = new System.Drawing.Point(218, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "Додади натпревар во тикет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label9.Location = new System.Drawing.Point(218, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "Избери натпревар од билтен или напиши шифра";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label10.Location = new System.Drawing.Point(468, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "Вкупно коефициент";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label11.Location = new System.Drawing.Point(468, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "Добивка";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label12.Location = new System.Drawing.Point(469, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "Упплата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label6.Location = new System.Drawing.Point(20, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "Креирај билтен";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label13.Location = new System.Drawing.Point(20, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "Избери 2 тима од иста држава";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label14.Location = new System.Drawing.Point(20, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 12);
            this.label14.TabIndex = 30;
            this.label14.Text = "Постави коефициенти";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 344);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "X";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 370);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 396);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Шифра";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 494);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tbIncome);
            this.Controls.Add(this.nudStake);
            this.Controls.Add(this.tbCoef);
            this.Controls.Add(this.btnAddNewMatch);
            this.Controls.Add(this.cbSelectTip);
            this.Controls.Add(this.tbCodeBilten);
            this.Controls.Add(this.btnAddNewTeam);
            this.Controls.Add(this.btnAddToBilten);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.nudDvojka);
            this.Controls.Add(this.nudNereseno);
            this.Controls.Add(this.nudKec);
            this.Controls.Add(this.lbTicket);
            this.Controls.Add(this.lbTeams);
            this.Controls.Add(this.lbBilten);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudKec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNereseno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDvojka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBilten;
        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.ListBox lbTicket;
        private System.Windows.Forms.NumericUpDown nudKec;
        private System.Windows.Forms.NumericUpDown nudNereseno;
        private System.Windows.Forms.NumericUpDown nudDvojka;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btnAddToBilten;
        private System.Windows.Forms.Button btnAddNewTeam;
        private System.Windows.Forms.TextBox tbCodeBilten;
        private System.Windows.Forms.ComboBox cbSelectTip;
        private System.Windows.Forms.Button btnAddNewMatch;
        private System.Windows.Forms.TextBox tbCoef;
        private System.Windows.Forms.NumericUpDown nudStake;
        private System.Windows.Forms.TextBox tbIncome;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

