using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageBankProgram
{
    public partial class SpecificDateFilter : Form
    {
        private String datestring;

        public string Datestring { get => datestring; set => datestring = value; }

        public SpecificDateFilter()
        {
            InitializeComponent();
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            datestring = itemFilterTime.Value.ToShortDateString();
            this.Close();
        }
    }
}
