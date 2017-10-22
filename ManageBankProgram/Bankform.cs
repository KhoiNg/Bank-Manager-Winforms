using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageBankProgram.Model;

namespace ManageBankProgram
{
    public partial class Bankform : Form
    {
        private List<BankItem> BankData = new List<BankItem>();
        private string LOCAL_FILE_SAVINGANDOPEN;
        private Boolean isSave = true;

        public Bankform()
        {
            InitializeComponent();

            listItemView.ColumnWidthChanging += (e, sender) =>
            {
                ColumnWidthChangingEventArgs arg = (ColumnWidthChangingEventArgs)sender;
                arg.Cancel = true;
                arg.NewWidth = listItemView.Columns[arg.ColumnIndex].Width;
            };

            // Initialize the comboBox to None
            comboBoxFilterDate.SelectedIndex = 3;
            comboBoxFilterDescription.SelectedIndex = 10;
            comboBoxFilterAmount.SelectedIndex = 4;


            // Make a path for local database and add it into program
            LOCAL_FILE_SAVINGANDOPEN = AppDomain.CurrentDomain.BaseDirectory + @"\" + "localdata.txt";
            OpenFile(LOCAL_FILE_SAVINGANDOPEN);

            showList();
        }

        #region menu
        /********************************** File Menu ***********************************/
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void openTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Select a Database Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog.FileName);
            }
            showList();
        }

        private void saveTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTxtFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // When it is exit, it will execute the Bankform_FormClosed function
        }

        /********************************** Function Menu ***********************************/

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation",
                    MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BankData = new List<BankItem>();
                comboBoxFilterDate.SelectedIndex = 3;
                comboBoxFilterDescription.SelectedIndex = 10;
                comboBoxFilterAmount.SelectedIndex = 4;
                isSave = true;
                showList();
            }               
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void saveAsExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "*Excel Files|*.xlsx;*.*/xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt;*.xls;*‌​.xml;*.xml;*.xlam;*.‌​xla;*.xlw;*.xlr;";
            saveFileDialog.Filter = "Excel Files|*.xls";
            saveFileDialog.FileName = "Excel Database";
            saveFileDialog.Title = "Save an Excel File";
            saveFileDialog.OverwritePrompt = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<BankItem> temp = BankData;
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.Write("           " + "\t" + "       ID" + "\t" + "       Date" + "\t" +
                    "       Description" + "\t" + "       Amount" + "\t" +
                    "       Sign" + "\n");
                int position = 1;
                foreach (BankItem item in temp)
                {
                    string idstring = string.Format("=\"{0}\"", item.ItemId.ToString());
                    streamWriter.Write(position.ToString() + "\t" + idstring + "\t" + item.ItemDate + "\t"
                        + item.ItemDescription + "\t" + item.ItemAmountSpent + "\t" +
                        (item.ItemSign ? "       +" : "       -") + "\n");
                    position++;
                }
                streamWriter.Close();
                MessageBox.Show("The Excel File will notify :" + "\n"
                    + "The file format and extension don't match." + "\n"
                    + "Please select YES if you want to see the Excel File." + "\n"
                    + "Using the Excel File Method to store Data in this program is not RECOMMENDED", "Note!");
            }
        }

        private void saveAsTextTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FileName = "Table Database";
            saveFileDialog.Title = "Save a Text File";
            saveFileDialog.OverwritePrompt = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine("#======================================================================================================#");
                streamWriter.WriteLine("|        |||        ID        |||     Date     |||     Description    |||       Amount       ||| Sign  |");
                List<BankItem> temp = BankData;
                int position = 1;
                foreach (BankItem item in temp)
                {
                    streamWriter.WriteLine("|------------------------------------------------------------------------------------------------------|");
                    StringBuilder tempstring = new StringBuilder();
                    tempstring.Append(String.Format("| {0} |||  {1:00000000000000}  |||  {2}  ||| {3} ||| {4} ||| {5}   |",
                        position.ToString().PadRight(6), item.ItemId, item.ItemDate.PadRight(10), item.ItemDescription.PadRight(18)
                        , item.ItemAmountSpent.ToString().PadRight(18), (item.ItemSign ? " + " : " - ")));
                    streamWriter.WriteLine(tempstring.ToString());
                    position++;
                }
                streamWriter.WriteLine("#======================================================================================================#");

                streamWriter.Close();
            }
        }

        private void accountSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm(BankData);
            accountForm.ShowDialog();
        }

        /********************************** About Menu ***********************************/
        private void aboutThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is the stimulation of a private Bank Account Control. "
                + "You can update and change your banking history as well as import/export it as a file. " + "\n"
                + "Copyright © Khoi Phan Tan Nguyen. All Rights Reserved."
                , "About!");
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: Khoi P Nguyen " + "\n"
                + "Phone Number: (605) 480-4394" + "\n"
                + "Email: nguyenphantankhoi@gmail.com " + "\n"
                + "            Khoi.Nguyen@trojans.dsu.edu" + "\n"
                + "Personal Website: " + "http://khoinguyen.byethost32.com/", "Contact");
        }
        #endregion

        #region extra function
        /**************************** Show List *******************************/
        private void showList()
        {
            listItemView.Items.Clear();
            int position = 1;
            foreach (BankItem item in BankData)
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
                temp.SubItems.Add(item.ItemAmountSpent.ToString("C2", new CultureInfo("en-US")));
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

        private bool _isChoosenForSpecificDateFilter = false;   // this variable is to recheck if we need to ask for input again
        private String _temporaryDateForFilter;                 // this variable is to store the day when we do not ask for input again
        private void showListwithFilter()
        {
            List<BankItem> tempdata = BankData;
            //filter Date - mm/dd/yyyy
            switch (comboBoxFilterDate.SelectedIndex)
            {
                case 0:
                    _isChoosenForSpecificDateFilter = false;
                    tempdata = tempdata.OrderBy(item => Convert.ToDateTime(item.ItemDate)).ToList();
                    break;
                case 1:
                    _isChoosenForSpecificDateFilter = false;
                    tempdata = tempdata.OrderByDescending(item => Convert.ToDateTime(item.ItemDate)).ToList();
                    break;
                case 2:
                    if (!_isChoosenForSpecificDateFilter)
                    {
                        SpecificDateFilter specificDateFilter = new SpecificDateFilter();
                        specificDateFilter.ShowDialog();
                        _temporaryDateForFilter = specificDateFilter.Datestring;
                        tempdata = tempdata.Where(item => item.ItemDate == _temporaryDateForFilter).ToList();
                        _isChoosenForSpecificDateFilter = true;
                    } else
                    {
                        tempdata = tempdata.Where(item => item.ItemDate == _temporaryDateForFilter).ToList();
                    }
                    break;
                case 3:
                    _isChoosenForSpecificDateFilter = false;
                    break;
                default:
                    _isChoosenForSpecificDateFilter = false;
                    break;
            }

            //filter Description
            switch (comboBoxFilterDescription.SelectedIndex)
            {
                case 0:
                    tempdata = tempdata.Where(item => item.ItemDescription == "Income").ToList();
                    break;
                case 1:
                    tempdata = tempdata.Where(item => item.ItemDescription == "ExtraMoney").ToList();
                    break;
                case 2:
                    tempdata = tempdata.Where(item => item.ItemDescription == "Housing").ToList();
                    break;
                case 3:
                    tempdata = tempdata.Where(item => item.ItemDescription == "Food").ToList();
                    break;
                case 4:
                    tempdata = tempdata.Where(item => item.ItemDescription == "Transportation").ToList();
                    break;
                case 5:
                    tempdata = tempdata.Where(item => item.ItemDescription == "Health").ToList();
                    break;
                case 6:
                    tempdata = tempdata.Where(item => item.ItemDescription == "Education").ToList();
                    break;
                case 7:
                    tempdata = tempdata.Where(item => item.ItemDescription == "Buying").ToList();
                    break;
                case 8:
                    tempdata = tempdata.Where(item => item.ItemDescription == "Entertainment").ToList();
                    break;
                case 9:
                    tempdata = tempdata.Where(item => item.ItemDescription == "Others").ToList();
                    break;
                case 10:
                    break;
                default:
                    break;
            }

            // filter Amount
            switch (comboBoxFilterAmount.SelectedIndex)
            {
                case 0:
                    tempdata = tempdata.Where(item => item.ItemAmountSpent >= 0 && item.ItemAmountSpent < 100).ToList();
                    break;
                case 1:
                    tempdata = tempdata.Where(item => item.ItemAmountSpent >= 100 && item.ItemAmountSpent < 500).ToList();
                    break;
                case 2:
                    tempdata = tempdata.Where(item => item.ItemAmountSpent >= 500 && item.ItemAmountSpent < 1000).ToList();
                    break;
                case 3:
                    tempdata = tempdata.Where(item => item.ItemAmountSpent >= 1000).ToList();
                    break;
                case 4:
                    break;
                default:
                    break;
            }


            //Show
            listItemView.Items.Clear();
            int position = 1;
            foreach (BankItem item in tempdata)
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
                temp.SubItems.Add(item.ItemAmountSpent.ToString("C2", new CultureInfo("en-US")));
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

        /**************************** Saving/Open File ************************/
        private void SavingLocalFile(string path)
        {
            List<BankItem> temp = BankData;
            TextWriter streamWriter = new StreamWriter(path);
            foreach (BankItem item in temp) {
                StringBuilder tempstring = new StringBuilder();
                tempstring.Append(String.Format("{0}|{1}|{2}|{3}|{4}", item.ItemId, item.ItemDate, item.ItemDescription, item.ItemAmountSpent, item.ItemSign));
                streamWriter.WriteLine(tempstring.ToString());
            }
            streamWriter.Close();
        }

        private void OpenFile(String openpath)
        {
            if (File.Exists(openpath) && new FileInfo(openpath).Length > 0)
            {
                bool inputmakeable = true;
                List<BankItem> temp = new List<BankItem>();
                try
                {
                    using (StreamReader sr = new StreamReader(openpath))
                    {
                        //String line = sr.ReadToEnd();
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] words = line.Split('|');
                            double amount;
                            if (!double.TryParse(words[3], out amount))
                            {
                                inputmakeable = false;
                                throw new System.Exception("Invalid Input!");
                            }
                            BankItem tempitem = new BankItem(words[0], words[1], words[2], Math.Round(amount, 2), words[4] == "True" ? true : false);
                            temp.Add(tempitem);
                        }
                    }
                }
                catch (Exception e)
                {
                    inputmakeable = false;
                    Console.WriteLine("The file could not be read. " + e);
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (inputmakeable)
                    {
                        temp = StandardShorting(temp);
                        BankData = temp;

                        // Reset Filter
                        comboBoxFilterDate.SelectedIndex = 3;
                        comboBoxFilterDescription.SelectedIndex = 10;
                        comboBoxFilterAmount.SelectedIndex = 4;

                        // Reset isSave
                        isSave = false;
                    }
                }
            }
        }

        public void SaveTxtFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FileName = "Database";
            saveFileDialog.Title = "Save a Text File";
            saveFileDialog.OverwritePrompt = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SavingLocalFile(saveFileDialog.FileName);
            }
        }

        /**************************** Initialize Shorting for Open ************************/
        private List<BankItem> StandardShorting (List<BankItem> list)
        {
            list = list.OrderBy(item => Convert.ToDateTime(item.ItemDate)).ToList();
            return list;
        }

        #endregion

        #region button
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            // reset filter 
            comboBoxFilterDate.SelectedIndex = 3;
            comboBoxFilterDescription.SelectedIndex = 10;
            comboBoxFilterAmount.SelectedIndex = 4;

            InsertForm insertForm = new InsertForm();
            insertForm.ShowDialog();
            BankItem temporary = insertForm.ItemInsert;
            if ( temporary.ItemId != null)
                this.BankData.Add(temporary);
            showList();
            isSave = false;         // It needs to be save again
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

            ChangeForm changeForm = new ChangeForm(BankData);
            changeForm.ShowDialog();
            BankData = changeForm.BankData;
            showList();
            isSave = false;         // It needs to be save again
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(BankData);
            searchForm.ShowDialog();
        }

        #endregion

        #region Filter
        private void comboBoxFilterDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            showListwithFilter();
        }

        private void comboBoxFilterDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            showListwithFilter();
        }

        private void comboBoxFilterAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            showListwithFilter();
        }

        #endregion

        #region Managing Exit Button 
        private void Bankform_FormClosed(object sender, FormClosedEventArgs e)
        {
            SavingLocalFile(LOCAL_FILE_SAVINGANDOPEN);
        }

        private void Bankform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSave)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation",
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)                 // yes >>> save
                    SaveTxtFile();
                else if (result == DialogResult.Cancel)         // cancel
                    e.Cancel = true;
                // no >>> just stop
            }
        }

        #endregion

        /**********************************************
         * Before opening, the program will TRY to open local database ( store in Base Directory )
         * and always save it before it close 
         * Name of file : localdata.txt
         * ********************************************/
    }
}
