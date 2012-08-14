using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Bot.Forms
{
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void DataGrid_Accounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBox_Add_Account_MouseEnter(object sender, EventArgs e)
        {
            this.PictureBox_Add_Account.Image = C_Bot.Properties.Resources.Add_Account_Hover;
        }

        private void PictureBox_Add_Account_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBox_Add_Account.Image = C_Bot.Properties.Resources.Add_Account_Default;
        }
    }
}
