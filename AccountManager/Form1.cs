using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager
{
    public partial class Form1 : Form
    {
        double Balance;
        double bal;
        double number;
        int id;
        Transaction tempTrans = new Transaction();
        DataRow newCheckingRow;
        

        public Form1()
        {
            InitializeComponent();
            DateTimePicker dtpDate = new DateTimePicker();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCheckingDataSet.Checking' table. You can move, or remove it, as needed.
            this.checkingTableAdapter.Fill(this.dBCheckingDataSet.Checking);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
            if (dataGridView1.Rows[0].Cells[6].Value != null)
            {
                double.TryParse(dataGridView1.Rows[0].Cells[6].Value.ToString(), out bal);
                Balance = bal;
            }
            else
            {
                Balance = 0.00;
            }
            
            lblBal.Text = Balance.ToString("C2");
            this.dataGridView1.Columns[2].DefaultCellStyle.Format = "d";
            this.dataGridView1.Columns[4].DefaultCellStyle.Format = "C";
            this.dataGridView1.Columns[5].DefaultCellStyle.Format = "C";
            this.dataGridView1.Columns[6].DefaultCellStyle.Format = "C";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DialogResult Reply = MessageBox.Show("Do you want to commit your changes?", "Confirm Entry", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            while (txtTransAmt.Text != "" && Reply == DialogResult.OK)
            {
                try
                {
                    if (rbCredit.Checked)
                    {
                        addAmt();
                        tempTrans.transType = "Deposit";
                        writeRows();
                    }
                    else if (rbDebit.Checked)
                    {
                        subAmt();
                        tempTrans.transType = "Debit";
                        writeRows();
                    }
                    else if (rbTransfer.Checked)
                    {
                        addAmt();
                        tempTrans.transType = "Transfer";
                        writeRows();
                    }
                    else
                    {
                        DialogResult reply = MessageBox.Show("Is this an addition?", "Adjustment Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (reply == DialogResult.Yes)
                        {
                            addAmt();
                            tempTrans.transType = "Adjustment";
                            tempTrans.date = dtpDate.Value.ToString();
                            writeRows();
                        }
                        else if (reply == DialogResult.No)
                        {
                            subAmt();
                            tempTrans.transType = "Adjustment";
                            writeRows();
                        }
                        else if (reply == DialogResult.Cancel)
                        {
                            clearForm();
                            return;                            
                        }
                    }
                    clearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex.Message, "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            clearForm();
            
            DAL myDAL = new DAL();

            if (myDAL.insertTransaction(tempTrans) == true)
            {
                lblTransStatus.Text = "Transaction DB ADD: OK";
            }
            else
            {
                lblTransStatus.Text = "Transaction DB ADD: ERROR";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearForm();
        }
     
        private void clearForm()
        {
            txtTransAmt.Text = "";
            txtTransDesc.Text = "";
            txtCheckNum.Text = "";
            rbDebit.Checked = true;
            cbCleared.Checked = false;
            if (dataGridView1.Rows[0].Cells[6].Value != null)
            {
                double.TryParse(dataGridView1.Rows[0].Cells[6].Value.ToString(), out bal);
                Balance = bal;
            }
            lblBal.Text = Balance.ToString("C2");
            dtpDate.Value = DateTime.Now;
            txtTransAmt.Focus();
        }

        private void addAmt()
        {
            double.TryParse(txtTransAmt.Text.ToString(), out number);
            Balance = Balance + number;
            tempTrans.creditAmt = number;
            tempTrans.acctBal = Balance;
            tempTrans.transDesc = txtTransDesc.Text;
            tempTrans.date = dtpDate.Value.ToString();
            if (dataGridView1.Rows[0].Cells[0].Value != null)
            {
                int.TryParse(dataGridView1.Rows[0].Cells[0].Value.ToString(), out id);
                tempTrans.transID = id + 1;
            }
            else
            {
                tempTrans.transID = 1;
            }
            lblBal.Text = Balance.ToString("C2");
            txtTransAmt.Text = "";
            if (cbCleared.Checked)
            {
                tempTrans.isCleared = "X";
            }
            else
            {
                tempTrans.isCleared = "";
            }
        }

        private void subAmt()
        {
            double.TryParse(txtTransAmt.Text.ToString(), out number);
            Balance = Balance - number;
            tempTrans.debitAmt = number;
            tempTrans.acctBal = Balance;
            tempTrans.transDesc = txtTransDesc.Text;
            tempTrans.date = dtpDate.Value.ToString();
            if (dataGridView1.Rows[0].Cells[0].Value != null)
            {
                int.TryParse(dataGridView1.Rows[0].Cells[0].Value.ToString(), out id);
                tempTrans.transID = id + 1;
            }
            else
            {
                tempTrans.transID = 1;
            }
            lblBal.Text = Balance.ToString("C2");
            txtTransAmt.Text = "";
            if (cbCleared.Checked)
            {
                tempTrans.isCleared = "X";
            }
            else
            {
                tempTrans.isCleared = "";
            }
        }

        private void writeRows()
        {
            newCheckingRow = dBCheckingDataSet.Tables["Checking"].NewRow();
            newCheckingRow[0] = tempTrans.transID;
            newCheckingRow[1] = tempTrans.transType;
            if (tempTrans.date != null)
            {
                newCheckingRow[2] = tempTrans.date;
            }
            else
            {
                newCheckingRow[2] = DateTime.Now;
            }
            newCheckingRow[3] = tempTrans.transDesc;
            newCheckingRow[4] = tempTrans.debitAmt;
            newCheckingRow[5] = tempTrans.creditAmt;
            newCheckingRow[6] = tempTrans.acctBal;
            newCheckingRow[7] = tempTrans.isCleared;

            dBCheckingDataSet.Tables["Checking"].Rows.Add(newCheckingRow);
        }

        private void rbTransfer_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckNum.ReadOnly = true;
        }

        private void rbAdjustment_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckNum.ReadOnly = true;
        }

        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckNum.ReadOnly = true;
        }

        private void rbDebit_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckNum.ReadOnly = false;
        }
    }
}