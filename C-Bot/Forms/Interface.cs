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
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void PictureBox_Settings_MouseEnter(object sender, EventArgs e)
        {
            this.PictureBox_Settings.Image = C_Bot.Properties.Resources.Setting_Hover;
        }

        private void PictureBox_Settings_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBox_Settings.Image = C_Bot.Properties.Resources.Setting_Default;
        }

        private void PictureBox_Settings_Click(object sender, EventArgs e)
        {
            PictureBox_Settings.ContextMenuStrip.Show(PictureBox_Settings, 11, 11);
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Accounts().ShowDialog();
        }

        private void PictureBox_Scripts_MouseEnter(object sender, EventArgs e)
        {
            this.PictureBox_Scripts.Image = C_Bot.Properties.Resources.Scripts_Hover;
        }

        private void PictureBox_Scripts_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBox_Scripts.Image = C_Bot.Properties.Resources.Scripts_Default;
        }

        private void PictureBox_Statistics_MouseEnter(object sender, EventArgs e)
        {
            this.PictureBox_Statistics.Image = C_Bot.Properties.Resources.Statistics_Hover;
        }

        private void PictureBox_Statistics_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBox_Statistics.Image = C_Bot.Properties.Resources.Statistics_Default;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
