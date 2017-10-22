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
    public partial class SearchForm : Form
    {
        private List<BankItem> bankData = new List<BankItem>();

        internal List<BankItem> BankData { get => bankData; set => bankData = value; }
        
        public SearchForm(List<BankItem> data)
        {
            InitializeComponent();
            BankData = data;
            textBoxId.Enabled = false;
            itemSearchTime.Enabled = false;
            comboBoxSearchDescription.Enabled = false;
            textBoxSearchAmount.Enabled = false;
            comboBoxSearchSign.Enabled = false;
        }

        #region button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (checkBoxID.Checked)
            {
                if (textBoxId.Text == "")
                {
                    MessageBox.Show("Please enter an ID", "Error!");
                    return;
                }
                BankItem temp = BankData.Find(item => item.ItemId == textBoxId.Text);
                if (temp == null)
                {
                    MessageBox.Show("Search not found!", "Error!");
                }
                else
                {
                    MessageBox.Show("Date =" + String.Format("{0:D}", Convert.ToDateTime(temp.ItemDate)) + "\n"
                        + "Description = " + temp.ItemDescription + "\n"
                        + "Amount = " + temp.ItemAmountSpent.ToString("C2", new CultureInfo("en-US")) + "\n"
                        + "Sign = " + (temp.ItemSign ? " Positive (+) " : " Negative (-) ")
                        , "ID Information");
                }
            }
            else if (checkBoxInfo.Checked)
            {
                List<BankItem> temp = BankData.FindAll(item => item.ItemDate == itemSearchTime.Value.ToShortDateString());
                // get all the date then delete each one that have

                if (comboBoxSearchDescription.SelectedItem != null)
                {
                    String stringdescription = "";
                    switch (comboBoxSearchDescription.SelectedIndex)
                    {
                        case 0:
                            stringdescription = "Income";
                            break;
                        case 1:
                            stringdescription = "ExtraMoney";
                            break;
                        case 2:
                            stringdescription = "Housing";
                            break;
                        case 3:
                            stringdescription = "Food";
                            break;
                        case 4:
                            stringdescription = "Transportation";
                            break;
                        case 5:
                            stringdescription = "Health";
                            break;
                        case 6:
                            stringdescription = "Education";
                            break;
                        case 7:
                            stringdescription = "Buying";
                            break;
                        case 8:
                            stringdescription = "Entertainment";
                            break;
                        case 9:
                            stringdescription = "Others";
                            break;
                        default:
                            break;
                    }
                    temp.RemoveAll(item => item.ItemDescription != stringdescription);
                }
                // delete Description

                if (textBoxSearchAmount.Text != "")
                {
                    double tempamount;
                    if (!double.TryParse(textBoxSearchAmount.Text, out tempamount))
                    {
                        MessageBox.Show("It is not a valid number Amount", "Error!");
                        return;
                    }
                    temp.RemoveAll(item => item.ItemAmountSpent != tempamount);
                }
                // delete amount

                if (comboBoxSearchSign.SelectedItem != null)
                {
                    bool tempsign = comboBoxSearchSign.SelectedIndex == 0 ? true : false;
                    temp.RemoveAll(item => item.ItemSign != tempsign);
                }
                // delete Sign

                if ( temp.Count == 0)
                {
                    MessageBox.Show("Search not found!", "Error!");
                }
                else
                {
                    String tempstring = "ID : " + "\n";
                    foreach(BankItem item in temp)
                    {
                        tempstring += item.ItemId.ToString() + "\n";
                    }
                    MessageBox.Show(tempstring, "ID found!");
                }
            }
            else
            {
                MessageBox.Show("Please select a way to search", "Error!");
            }
        }

        #endregion

        #region checkbox
        private void checkBoxID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxID.Checked)
            {
                textBoxId.Enabled = true;
                checkBoxInfo.Checked = false;
                itemSearchTime.Enabled = false;
                comboBoxSearchDescription.Enabled = false;
                textBoxSearchAmount.Enabled = false;
                comboBoxSearchSign.Enabled = false;
            }
            else
            {
                textBoxId.Enabled = false;
            }
        }

        private void checkBoxInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInfo.Checked)
            {
                itemSearchTime.Enabled = true;
                comboBoxSearchDescription.Enabled = true;
                textBoxSearchAmount.Enabled = true;
                comboBoxSearchSign.Enabled = true;
                checkBoxID.Checked = false;
                textBoxId.Enabled = false;
            }
            else
            {
                itemSearchTime.Enabled = false;
                comboBoxSearchDescription.Enabled = false;
                textBoxSearchAmount.Enabled = false;
                comboBoxSearchSign.Enabled = false;
            }
        }
#endregion
    }
}
