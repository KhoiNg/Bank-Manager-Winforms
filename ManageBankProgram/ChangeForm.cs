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
    public partial class ChangeForm : Form
    {
        private List<BankItem> bankData = new List<BankItem>();
        internal List<BankItem> BankData { get => bankData; set => bankData = value; }

         public ChangeForm(List<BankItem> data)
        {
            InitializeComponent();
            BankData = data;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            BankItem temp = BankData.Find(item => item.ItemId == textBoxId.Text);
            if (temp == null)
            {
                MessageBox.Show("It is not a valid Id", "Error!");
                return;
            }
            else
            {
                BankData.Remove(temp);
                MessageBox.Show("Delete Successfully!", "Compele!");
                this.Close();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            BankItem temp = BankData.Find(item => item.ItemId == textBoxId.Text);
            if (temp == null)
            {
                MessageBox.Show("It is not a valid Id", "Error!");
                return;
            }
            else 
            {
                ChangeFormTemp changeFormTemp = new ChangeFormTemp(temp);
                changeFormTemp.ShowDialog();
                BankItem newtemp = changeFormTemp.BankItem;         // get the Item
                int tempposition = BankData.IndexOf(temp);          // get the position
                BankData[tempposition] = newtemp;                   // replace
                this.Close();
            }
        }
    }
}
