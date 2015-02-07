namespace AccountManager
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTransAmt = new System.Windows.Forms.Label();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbDebit = new System.Windows.Forms.RadioButton();
            this.gbTransType = new System.Windows.Forms.GroupBox();
            this.rbAdjustment = new System.Windows.Forms.RadioButton();
            this.rbTransfer = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblBal = new System.Windows.Forms.Label();
            this.txtTransDesc = new System.Windows.Forms.TextBox();
            this.lblTransDesc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCheckingDataSet = new AccountManager.DBCheckingDataSet();
            this.checkingTableAdapter = new AccountManager.DBCheckingDataSetTableAdapters.CheckingTableAdapter();
            this.txtCheckNum = new System.Windows.Forms.TextBox();
            this.lblCheckNum = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbCleared = new System.Windows.Forms.CheckBox();
            this.lblTransStatus = new System.Windows.Forms.Label();
            this.txtTransAmt = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gbTransType.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCheckingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1269, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblTransAmt
            // 
            this.lblTransAmt.AutoSize = true;
            this.lblTransAmt.Location = new System.Drawing.Point(12, 44);
            this.lblTransAmt.Name = "lblTransAmt";
            this.lblTransAmt.Size = new System.Drawing.Size(102, 13);
            this.lblTransAmt.TabIndex = 2;
            this.lblTransAmt.Text = "Transaction Amount";
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Location = new System.Drawing.Point(14, 42);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(52, 17);
            this.rbCredit.TabIndex = 6;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Credit";
            this.rbCredit.UseVisualStyleBackColor = true;
            this.rbCredit.CheckedChanged += new System.EventHandler(this.rbCredit_CheckedChanged);
            // 
            // rbDebit
            // 
            this.rbDebit.AutoSize = true;
            this.rbDebit.Checked = true;
            this.rbDebit.Location = new System.Drawing.Point(14, 19);
            this.rbDebit.Name = "rbDebit";
            this.rbDebit.Size = new System.Drawing.Size(49, 18);
            this.rbDebit.TabIndex = 5;
            this.rbDebit.TabStop = true;
            this.rbDebit.Text = "Debit";
            this.rbDebit.UseCompatibleTextRendering = true;
            this.rbDebit.UseVisualStyleBackColor = true;
            this.rbDebit.CheckedChanged += new System.EventHandler(this.rbDebit_CheckedChanged);
            // 
            // gbTransType
            // 
            this.gbTransType.Controls.Add(this.rbAdjustment);
            this.gbTransType.Controls.Add(this.rbTransfer);
            this.gbTransType.Controls.Add(this.rbDebit);
            this.gbTransType.Controls.Add(this.rbCredit);
            this.gbTransType.Location = new System.Drawing.Point(12, 178);
            this.gbTransType.Name = "gbTransType";
            this.gbTransType.Size = new System.Drawing.Size(211, 71);
            this.gbTransType.TabIndex = 5;
            this.gbTransType.TabStop = false;
            this.gbTransType.Text = "Transaction Type";
            // 
            // rbAdjustment
            // 
            this.rbAdjustment.AutoSize = true;
            this.rbAdjustment.Location = new System.Drawing.Point(111, 42);
            this.rbAdjustment.Name = "rbAdjustment";
            this.rbAdjustment.Size = new System.Drawing.Size(77, 17);
            this.rbAdjustment.TabIndex = 8;
            this.rbAdjustment.TabStop = true;
            this.rbAdjustment.Text = "Adjustment";
            this.rbAdjustment.UseVisualStyleBackColor = true;
            this.rbAdjustment.CheckedChanged += new System.EventHandler(this.rbAdjustment_CheckedChanged);
            // 
            // rbTransfer
            // 
            this.rbTransfer.AutoSize = true;
            this.rbTransfer.Location = new System.Drawing.Point(111, 19);
            this.rbTransfer.Name = "rbTransfer";
            this.rbTransfer.Size = new System.Drawing.Size(64, 17);
            this.rbTransfer.TabIndex = 7;
            this.rbTransfer.TabStop = true;
            this.rbTransfer.Text = "Transfer";
            this.rbTransfer.UseVisualStyleBackColor = true;
            this.rbTransfer.CheckedChanged += new System.EventHandler(this.rbTransfer_CheckedChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(26, 255);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(125, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(309, 155);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(74, 20);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "Balance";
            // 
            // pnlBalance
            // 
            this.pnlBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBalance.Controls.Add(this.lblBal);
            this.pnlBalance.Location = new System.Drawing.Point(239, 178);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(208, 71);
            this.pnlBalance.TabIndex = 9;
            // 
            // lblBal
            // 
            this.lblBal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBal.Location = new System.Drawing.Point(3, 17);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(0, 37);
            this.lblBal.TabIndex = 10;
            // 
            // txtTransDesc
            // 
            this.txtTransDesc.Location = new System.Drawing.Point(229, 60);
            this.txtTransDesc.Name = "txtTransDesc";
            this.txtTransDesc.Size = new System.Drawing.Size(218, 20);
            this.txtTransDesc.TabIndex = 1;
            // 
            // lblTransDesc
            // 
            this.lblTransDesc.AutoSize = true;
            this.lblTransDesc.Location = new System.Drawing.Point(226, 44);
            this.lblTransDesc.Name = "lblTransDesc";
            this.lblTransDesc.Size = new System.Drawing.Size(119, 13);
            this.lblTransDesc.TabIndex = 11;
            this.lblTransDesc.Text = "Transaction Description";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.codeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.paymentAmountDataGridViewTextBoxColumn,
            this.depositAmountDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.clearedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.checkingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(453, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(804, 306);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // paymentAmountDataGridViewTextBoxColumn
            // 
            this.paymentAmountDataGridViewTextBoxColumn.DataPropertyName = "Payment Amount";
            this.paymentAmountDataGridViewTextBoxColumn.HeaderText = "Payment Amount";
            this.paymentAmountDataGridViewTextBoxColumn.Name = "paymentAmountDataGridViewTextBoxColumn";
            // 
            // depositAmountDataGridViewTextBoxColumn
            // 
            this.depositAmountDataGridViewTextBoxColumn.DataPropertyName = "Deposit Amount";
            this.depositAmountDataGridViewTextBoxColumn.HeaderText = "Deposit Amount";
            this.depositAmountDataGridViewTextBoxColumn.Name = "depositAmountDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // clearedDataGridViewTextBoxColumn
            // 
            this.clearedDataGridViewTextBoxColumn.DataPropertyName = "Cleared";
            this.clearedDataGridViewTextBoxColumn.HeaderText = "Cleared";
            this.clearedDataGridViewTextBoxColumn.Name = "clearedDataGridViewTextBoxColumn";
            // 
            // checkingBindingSource
            // 
            this.checkingBindingSource.DataMember = "Checking";
            this.checkingBindingSource.DataSource = this.dBCheckingDataSet;
            // 
            // dBCheckingDataSet
            // 
            this.dBCheckingDataSet.DataSetName = "DBCheckingDataSet";
            this.dBCheckingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkingTableAdapter
            // 
            this.checkingTableAdapter.ClearBeforeFill = true;
            // 
            // txtCheckNum
            // 
            this.txtCheckNum.Location = new System.Drawing.Point(229, 105);
            this.txtCheckNum.Name = "txtCheckNum";
            this.txtCheckNum.Size = new System.Drawing.Size(100, 20);
            this.txtCheckNum.TabIndex = 3;
            // 
            // lblCheckNum
            // 
            this.lblCheckNum.AutoSize = true;
            this.lblCheckNum.Location = new System.Drawing.Point(226, 89);
            this.lblCheckNum.Name = "lblCheckNum";
            this.lblCheckNum.Size = new System.Drawing.Size(78, 13);
            this.lblCheckNum.TabIndex = 14;
            this.lblCheckNum.Text = "Check Number";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 105);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(211, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 89);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date";
            // 
            // cbCleared
            // 
            this.cbCleared.AutoSize = true;
            this.cbCleared.Location = new System.Drawing.Point(351, 105);
            this.cbCleared.Name = "cbCleared";
            this.cbCleared.Size = new System.Drawing.Size(62, 17);
            this.cbCleared.TabIndex = 4;
            this.cbCleared.Text = "Cleared";
            this.cbCleared.UseVisualStyleBackColor = true;
            // 
            // lblTransStatus
            // 
            this.lblTransStatus.AutoSize = true;
            this.lblTransStatus.Location = new System.Drawing.Point(12, 340);
            this.lblTransStatus.Name = "lblTransStatus";
            this.lblTransStatus.Size = new System.Drawing.Size(0, 13);
            this.lblTransStatus.TabIndex = 18;
            // 
            // txtTransAmt
            // 
            this.txtTransAmt.Location = new System.Drawing.Point(12, 60);
            this.txtTransAmt.Name = "txtTransAmt";
            this.txtTransAmt.Size = new System.Drawing.Size(211, 20);
            this.txtTransAmt.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 362);
            this.Controls.Add(this.txtTransAmt);
            this.Controls.Add(this.lblTransStatus);
            this.Controls.Add(this.cbCleared);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.lblCheckNum);
            this.Controls.Add(this.txtCheckNum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTransDesc);
            this.Controls.Add(this.txtTransDesc);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.gbTransType);
            this.Controls.Add(this.lblTransAmt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Account Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbTransType.ResumeLayout(false);
            this.gbTransType.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCheckingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTransAmt;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbDebit;
        private System.Windows.Forms.GroupBox gbTransType;
        private System.Windows.Forms.RadioButton rbAdjustment;
        private System.Windows.Forms.RadioButton rbTransfer;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.TextBox txtTransDesc;
        private System.Windows.Forms.Label lblTransDesc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBCheckingDataSet dBCheckingDataSet;
        private System.Windows.Forms.BindingSource checkingBindingSource;
        private DBCheckingDataSetTableAdapters.CheckingTableAdapter checkingTableAdapter;
        private System.Windows.Forms.TextBox txtCheckNum;
        private System.Windows.Forms.Label lblCheckNum;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox cbCleared;
        private System.Windows.Forms.Label lblTransStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clearedDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtTransAmt;
    }
}

