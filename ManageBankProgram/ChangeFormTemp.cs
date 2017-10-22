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
    public partial class ChangeFormTemp : Form
    {
        private BankItem bankItem;
        internal BankItem BankItem { get => bankItem; set => bankItem = value; }

        public ChangeFormTemp(BankItem data)
        {
            InitializeComponent();
            BankItem = data;

            //set initial value for the box
            itemChangeTime.Value = Convert.ToDateTime(data.ItemDate);

            int tempdescription = -1;
            switch (BankItem.ItemDescription)
            {
                case "Income":
                    tempdescription = 0;
                    break;
                case "ExtraMoney":
                    tempdescription = 1;
                    break;
                case "Housing":
                    tempdescription = 2;
                    break;
                case "Food":
                    tempdescription = 3;
                    break;
                case "Transportation":
                    tempdescription = 4;
                    break;
                case "Health":
                    tempdescription = 5;
                    break;
                case "Education":
                    tempdescription = 6;
                    break;
                case "Buying":
                    tempdescription = 7;
                    break;
                case "Entertainment":
                    tempdescription = 8;
                    break;
                case "Others":
                    tempdescription = 9;
                    break;
                default:
                    break;
            }
            if (tempdescription != -1)
            {
                comboBoxChangeDescription.SelectedIndex = tempdescription;
            }
            else
            {
                MessageBox.Show("Cannot transfer data", "Error!");
                this.Close();
            }

            textBoxChangeAmount.Text = data.ItemAmountSpent.ToString();

            comboBoxChangeSign.SelectedIndex = data.ItemSign ? 0 : 1;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            double amount;

            // Check if it is valid
            if (textBoxChangeAmount.Text == "")
            {
                MessageBox.Show("You cannot change amount to null", "Error!");
                return;
            }
            else if (!double.TryParse(textBoxChangeAmount.Text, out amount))
            {
                MessageBox.Show("It is not a valid number Amount", "Error!");
                return;
            } else if (amount < 0)
            {
                MessageBox.Show("Amount should not be negative!", "Error!");
                return;
            }

            // Find string of each for BankItem

            // Date
            String stringdate = itemChangeTime.Value.ToShortDateString();

            // Description
            String stringdescription = "";
            switch (comboBoxChangeDescription.SelectedIndex)
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
            if (comboBoxChangeSign.SelectedIndex == 0)
            {
                stringsign = true;                // + -> true
            }
            else
            {
                stringsign = false;               // - -> false
            }

            BankItem = new BankItem(BankItem.ItemId,stringdate,stringdescription,amount,stringsign);
            this.Close();
        }
    }
}
