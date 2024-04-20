using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP12thProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            EmailName.KeyDown += TextBox_KeyDown;
            PassLog.KeyDown += TextBox_KeyDown;
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Control currentControl = (Control)sender;
                int currentIndex = currentControl.TabIndex;
                Control nextControl = this.GetNextControl(currentControl, true);
                if (nextControl != null && nextControl is TextBox)
                {
                    nextControl.Focus();
                }
                e.Handled = true;
            }
        }
        CLient a = new CLient();
        private void EmailName_TextChanged(object sender, EventArgs e)
        {
            a.ClientMail = EmailName.Text;
            a.ClientName = EmailName.Text;
        }

        private void PassLog_TextChanged(object sender, EventArgs e)
        {
            a.ClientPassword = PassLog.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5= new Form5();
            form5.ShowDialog();
        }
    }
}
