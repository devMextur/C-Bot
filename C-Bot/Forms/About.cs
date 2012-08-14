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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void PictureBox_Facebook_MouseEnter(object sender, EventArgs e)
        {
            this.PictureBox_Facebook.Image = C_Bot.Properties.Resources.Facebook_Hover;
        }

        private void PictureBox_Facebook_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBox_Facebook.Image = C_Bot.Properties.Resources.Facebook_Default;
        }

        private void Label_Build_MouseHover(object sender, EventArgs e)
        {
            this.ToolTip_Build.Show("Version: 1000\r\nStatus: EXPERIMENTAL", Label_Build);
        }

        private void PictureBox_Facebook_MouseHover(object sender, EventArgs e)
        {
            this.ToolTip_Facebook.Show("Join our Facebook page, and get always the newest C-Bot build.", PictureBox_Facebook);
        }

        private void PictureBox_Twitter_MouseEnter(object sender, EventArgs e)
        {
            this.PictureBox_Twitter.Image = C_Bot.Properties.Resources.Twitter_Hover;
        }

        private void PictureBox_Twitter_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBox_Twitter.Image = C_Bot.Properties.Resources.Twitter_Default;
        }

        private void PictureBox_Web_MouseEnter(object sender, EventArgs e)
        {
            this.PictureBox_Web.Image = C_Bot.Properties.Resources.Web_Hover;
        }

        private void PictureBox_Web_MouseLeave(object sender, EventArgs e)
        {
            this.PictureBox_Web.Image = C_Bot.Properties.Resources.Web_Default;
        }

        private void PictureBox_Twitter_MouseHover(object sender, EventArgs e)
        {
            this.ToolTip_Twitter.Show("Follow us on Twitter to get the newest updates about C-Bot.", PictureBox_Twitter);
        }

        private void PictureBox_Web_MouseHover(object sender, EventArgs e)
        {
            this.ToolTip_Web.Show("Visit our website to download/view the newest version of C-Bot and his features.", PictureBox_Web);
        }
    }
}
