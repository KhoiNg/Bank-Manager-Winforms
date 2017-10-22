using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageBankProgram.Model;

namespace ManageBankProgram
{
    public partial class InsertForm : Form
    {
        private BankItem itemInsert = new BankItem();

        internal BankItem ItemInsert { get => itemInsert; set => itemInsert = value; }

        public InsertForm()
        {
            InitializeComponent();
        }

        #region info Button
        private void comboBoxInsertDescription_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemInsertTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxInsertSign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            double amount;
        
            // Check if it is valid
            if (comboBoxInsertDescription.SelectedItem == null)
            {
                MessageBox.Show("Please choose an Description","Error!");
                return;
            }
            else if (textBoxInsertAmount.Text == "")
            {
                MessageBox.Show("Please enter an Amount","Error!");
                return;
            } else if (!double.TryParse(textBoxInsertAmount.Text, out amount))
            {
                MessageBox.Show("It is not a valid number Amount","Error!");
                return;
            } else if (amount < 0)
            {
                MessageBox.Show("Amount should not be negative!", "Error!");
                return;
            }
            else if (comboBoxInsertSign.SelectedItem == null)
            {
                MessageBox.Show("Please enter a Sign","Error!");
                return;
            }

            // Find string of each for BankItem

            // Date
            String stringdate = itemInsertTime.Value.ToShortDateString();

            // Description
            String stringdescription = "";
            switch (comboBoxInsertDescription.SelectedIndex)
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

            // Amount
            Math.Round(amount, 2);

            // Sign
            Boolean stringsign;
            if ( comboBoxInsertSign.SelectedIndex == 0)
            {
                stringsign = true;                // + -> true
            } else
            {
                stringsign = false;               // - -> false
            }

            // Generate ID code
            String temp = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");
            String stringcode = (comboBoxInsertDescription.SelectedIndex + 1).ToString() +
                temp[10].ToString() + temp[9].ToString() + temp[12].ToString()
                + temp[13].ToString() + temp[15].ToString() + temp[16].ToString()
                + temp[1].ToString() + temp[2].ToString() + temp[3].ToString()
                + temp[4].ToString() + temp[5].ToString() + temp[6].ToString()
                + temp[7].ToString();
            //MessageBox.Show("Code = " + stringcode);
            // format = SelectedDescriptionPosition + CurrentTime(hh mm ss yyy MM dd )

            /*
            char tempforAmount;
            if (amount < 100)
            {
                tempforAmount = '1';
            }
            else if (amount < 500)
            {
                tempforAmount = '2';
            }
            else if (amount < 1000)
            {
                tempforAmount = '3';
            }
            else
            {
                tempforAmount = '4';
            }
            String stringcode = stringdate[3].ToString() + stringdate[4].ToString() +
                            stringdate[0].ToString() + stringdate[1].ToString()
                            + stringdate[6].ToString() + stringdate[7].ToString() + stringdate[8].ToString()
                            + stringdate[9].ToString() + comboBoxInsertDescription.SelectedIndex.ToString()
                            + tempforAmount.ToString() + (stringsign ? "1" : "0") +
                            tempforCurrentTime[6].ToString() + tempforCurrentTime[7].ToString()
                            + tempforCurrentTime[3].ToString() + tempforCurrentTime[4].ToString()
                            + tempforCurrentTime[0].ToString() + tempforCurrentTime[1].ToString()
                            + (tempforCurrentTime[8].ToString() + tempforCurrentTime[9].ToString() == "AM" ? "1" : "2");
             format = dd mm yyyy AmountRange Sign(1:0) TimeGenerate(ssmmhh + am = 1 pm = 2)
            ****************** old code **************
             */




            ItemInsert = new BankItem(stringcode, stringdate, stringdescription, amount, stringsign);
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
