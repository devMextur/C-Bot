namespace C_Bot.Forms
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Label_Title = new System.Windows.Forms.Label();
            this.TextBox_Licence = new System.Windows.Forms.TextBox();
            this.Label_Build = new System.Windows.Forms.Label();
            this.Button_Close = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ToolTip_Build = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTip_Facebook = new System.Windows.Forms.ToolTip(this.components);
            this.PictureBox_Web = new System.Windows.Forms.PictureBox();
            this.PictureBox_Twitter = new System.Windows.Forms.PictureBox();
            this.PictureBox_Facebook = new System.Windows.Forms.PictureBox();
            this.ToolTip_Twitter = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTip_Web = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Web)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Twitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Facebook)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(12, 9);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(45, 17);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "C-BOT";
            // 
            // TextBox_Licence
            // 
            this.TextBox_Licence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TextBox_Licence.Enabled = false;
            this.TextBox_Licence.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TextBox_Licence.Location = new System.Drawing.Point(15, 43);
            this.TextBox_Licence.Multiline = true;
            this.TextBox_Licence.Name = "TextBox_Licence";
            this.TextBox_Licence.Size = new System.Drawing.Size(373, 105);
            this.TextBox_Licence.TabIndex = 1;
            this.TextBox_Licence.Text = resources.GetString("TextBox_Licence.Text");
            // 
            // Label_Build
            // 
            this.Label_Build.AutoSize = true;
            this.Label_Build.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Build.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Build.Location = new System.Drawing.Point(346, 9);
            this.Label_Build.Name = "Label_Build";
            this.Label_Build.Size = new System.Drawing.Size(42, 17);
            this.Label_Build.TabIndex = 2;
            this.Label_Build.Text = "B1000";
            this.Label_Build.MouseHover += new System.EventHandler(this.Label_Build_MouseHover);
            // 
            // Button_Close
            // 
            this.Button_Close.Location = new System.Drawing.Point(286, 166);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(102, 29);
            this.Button_Close.TabIndex = 3;
            this.Button_Close.Text = "OK";
            this.Button_Close.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(16, 159);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "c-bot.org";
            // 
            // ToolTip_Build
            // 
            this.ToolTip_Build.ToolTipTitle = "C-Bot Build";
            // 
            // ToolTip_Facebook
            // 
            this.ToolTip_Facebook.ToolTipTitle = "Facebook";
            // 
            // PictureBox_Web
            // 
            this.PictureBox_Web.Image = global::C_Bot.Properties.Resources.Web_Default;
            this.PictureBox_Web.Location = new System.Drawing.Point(75, 180);
            this.PictureBox_Web.Name = "PictureBox_Web";
            this.PictureBox_Web.Size = new System.Drawing.Size(22, 22);
            this.PictureBox_Web.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox_Web.TabIndex = 7;
            this.PictureBox_Web.TabStop = false;
            this.PictureBox_Web.MouseEnter += new System.EventHandler(this.PictureBox_Web_MouseEnter);
            this.PictureBox_Web.MouseLeave += new System.EventHandler(this.PictureBox_Web_MouseLeave);
            this.PictureBox_Web.MouseHover += new System.EventHandler(this.PictureBox_Web_MouseHover);
            // 
            // PictureBox_Twitter
            // 
            this.PictureBox_Twitter.Image = global::C_Bot.Properties.Resources.Twitter_Default;
            this.PictureBox_Twitter.Location = new System.Drawing.Point(47, 180);
            this.PictureBox_Twitter.Name = "PictureBox_Twitter";
            this.PictureBox_Twitter.Size = new System.Drawing.Size(22, 22);
            this.PictureBox_Twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox_Twitter.TabIndex = 6;
            this.PictureBox_Twitter.TabStop = false;
            this.PictureBox_Twitter.MouseEnter += new System.EventHandler(this.PictureBox_Twitter_MouseEnter);
            this.PictureBox_Twitter.MouseLeave += new System.EventHandler(this.PictureBox_Twitter_MouseLeave);
            this.PictureBox_Twitter.MouseHover += new System.EventHandler(this.PictureBox_Twitter_MouseHover);
            // 
            // PictureBox_Facebook
            // 
            this.PictureBox_Facebook.Image = global::C_Bot.Properties.Resources.Facebook_Default;
            this.PictureBox_Facebook.Location = new System.Drawing.Point(19, 180);
            this.PictureBox_Facebook.Name = "PictureBox_Facebook";
            this.PictureBox_Facebook.Size = new System.Drawing.Size(22, 22);
            this.PictureBox_Facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox_Facebook.TabIndex = 5;
            this.PictureBox_Facebook.TabStop = false;
            this.PictureBox_Facebook.MouseEnter += new System.EventHandler(this.PictureBox_Facebook_MouseEnter);
            this.PictureBox_Facebook.MouseLeave += new System.EventHandler(this.PictureBox_Facebook_MouseLeave);
            this.PictureBox_Facebook.MouseHover += new System.EventHandler(this.PictureBox_Facebook_MouseHover);
            // 
            // ToolTip_Twitter
            // 
            this.ToolTip_Twitter.ToolTipTitle = "Twitter";
            // 
            // ToolTip_Web
            // 
            this.ToolTip_Web.ToolTipTitle = "Website";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(400, 214);
            this.Controls.Add(this.PictureBox_Web);
            this.Controls.Add(this.PictureBox_Twitter);
            this.Controls.Add(this.PictureBox_Facebook);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Label_Build);
            this.Controls.Add(this.TextBox_Licence);
            this.Controls.Add(this.Label_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Web)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Twitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Facebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.TextBox TextBox_Licence;
        private System.Windows.Forms.Label Label_Build;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox PictureBox_Facebook;
        private System.Windows.Forms.ToolTip ToolTip_Build;
        private System.Windows.Forms.ToolTip ToolTip_Facebook;
        private System.Windows.Forms.PictureBox PictureBox_Twitter;
        private System.Windows.Forms.PictureBox PictureBox_Web;
        private System.Windows.Forms.ToolTip ToolTip_Twitter;
        private System.Windows.Forms.ToolTip ToolTip_Web;
    }
}