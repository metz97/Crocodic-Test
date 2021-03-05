using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKataKunci_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtKataKunci.Text) && !String.IsNullOrEmpty(txtParagraf.Text))
                lblTotal.Text = (txtParagraf.Text.Split(new string[] { txtKataKunci.Text },
                    StringSplitOptions.None).Length - 1).ToString();
            else
                lblTotal.Text = "0";
        }

        private void txtParagraf_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtKataKunci.Text) && !String.IsNullOrEmpty(txtParagraf.Text))
                lblTotal.Text = (txtParagraf.Text.Split(new string[] { txtKataKunci.Text },
                    StringSplitOptions.None).Length - 1).ToString();
            else
                lblTotal.Text = "0";
        }
    }
}
