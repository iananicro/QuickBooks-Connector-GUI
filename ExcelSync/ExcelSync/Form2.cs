using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSync
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides Report Form
            Form1 home = new Form1();
            home.Show(); //Reopens Connector Form
        }
    }
}
