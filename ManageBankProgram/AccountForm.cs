using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageBankProgram.Model;

namespace ManageBankProgram
{
    public partial class AccountForm : Form
    {
        private List<BankItem> BankData = new List<BankItem>();
        private CultureInfo Currency = new CultureInfo("en-US");

        public AccountForm(List<BankItem> list)
        {
            InitializeComponent();
            BankData = list;
            Currency.NumberFormat.CurrencyNegativePattern = 1;
            InitializeFeature();
        }

        #region checkBox and Button
        private void checkBoxReceive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReceive.Checked)
            {
                checkBoxSpending.Checked = false;
                showList(ListFilter(1));
                textBoxSum.Text = CalculateAmount(ListFilter(1)).ToString("C2",Currency);
            } else
            {
                InitializeFeature();
            }
        }

        private void checkBoxSpending_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpending.Checked)
            {
                checkBoxReceive.Checked = false;
                showList(ListFilter(0));
                textBoxSum.Text = CalculateAmount(ListFilter(0)).ToString("C2",Currency);
            }
            else
            {
                InitializeFeature();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

#region function
        private void showList(List<BankItem> TempBankList)
        {
            if (TempBankList == null)
            {
                TempBankList = BankData;
            }
            listItemView.Items.Clear();
            int position = 1;
            foreach (BankItem item in TempBankList)
            {
                ListViewItem temp = new ListViewItem(position.ToString());
                // position
                temp.SubItems.Add(item.ItemId);
                // id
                DateTime tempdate = Convert.ToDateTime(item.ItemDate);
                temp.SubItems.Add(String.Format("{0:D}", tempdate));
                // date
                temp.SubItems.Add(item.ItemDescription);
                // description
                temp.SubItems.Add(item.ItemAmountSpent.ToString("C2", Currency));
                // Money
                temp.UseItemStyleForSubItems = false;
                temp.SubItems.Add(item.ItemSign ? "+" : "-");
                if (!item.ItemSign) temp.SubItems[5].ForeColor = Color.Red;
                else temp.SubItems[5].ForeColor = Color.Green;
                // Sign
                listItemView.Items.Add(temp);
                position++;
            }
        }

        private double CalculateAmount(List<BankItem> TempBankList)
        {
            if (TempBankList == null)
            {
                TempBankList = BankData;
            }
            double sum = 0;
            foreach (BankItem item in TempBankList)
            {
                if (item.ItemSign)
                {
                    sum += item.ItemAmountSpent;
                }
                else
                {
                    sum -= item.ItemAmountSpent;
                }
            }
            return Math.Round(sum, 2);
        }

        private List<BankItem> ListFilter (int Case)
        {
            List<BankItem> tempdata = BankData;
            if (Case == 1)                                              // receive
            {
                tempdata = tempdata.Where(item => item.ItemSign == true).ToList();
            } else if (Case == 0)                                       // spend
            {
                tempdata = tempdata.Where(item => item.ItemSign == false).ToList();
            }

            return tempdata;
        }

        private void InitializeFeature()
        {
            showList(BankData);
            textBoxBalance.Text = CalculateAmount(BankData).ToString("C2",Currency);
            textBoxSum.Text = CalculateAmount(BankData).ToString("C2",Currency);
        }
#endregion
    }
}
