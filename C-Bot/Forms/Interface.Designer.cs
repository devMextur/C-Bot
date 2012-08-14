namespace C_Bot.Forms
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Panel_Shortcuts = new System.Windows.Forms.Panel();
            this.Menu_Settings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.separatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.seperatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.seperatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.Panel_Center = new System.Windows.Forms.Panel();
            this.PictureBox_Settings = new System.Windows.Forms.PictureBox();
            this.PictureBox_Scripts = new System.Windows.Forms.PictureBox();
            this.PictureBox_Statistics = new System.Windows.Forms.PictureBox();
            this.startScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seperatorToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Top.SuspendLayout();
            this.Panel_Shortcuts.SuspendLayout();
            this.Menu_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Scripts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Statistics)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.Black;
            this.Panel_Top.Controls.Add(this.Panel_Shortcuts);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(843, 30);
            this.Panel_Top.TabIndex = 0;
            // 
            // Panel_Shortcuts
            // 
            this.Panel_Shortcuts.Controls.Add(this.PictureBox_Settings);
            this.Panel_Shortcuts.Controls.Add(this.PictureBox_Scripts);
            this.Panel_Shortcuts.Controls.Add(this.PictureBox_Statistics);
            this.Panel_Shortcuts.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Shortcuts.Location = new System.Drawing.Point(643, 0);
            this.Panel_Shortcuts.Name = "Panel_Shortcuts";
            this.Panel_Shortcuts.Size = new System.Drawing.Size(200, 30);
            this.Panel_Shortcuts.TabIndex = 3;
            // 
            // Menu_Settings
            // 
            this.Menu_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Menu_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Menu_Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startScriptToolStripMenuItem,
            this.stopScriptToolStripMenuItem,
            this.restartScriptToolStripMenuItem,
            this.separatorToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.seperatorToolStripMenuItem1,
            this.botNetworkToolStripMenuItem,
            this.seperatorToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.Menu_Settings.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.Menu_Settings.Name = "Menu_Settings";
            this.Menu_Settings.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_Settings.Size = new System.Drawing.Size(144, 154);
            // 
            // separatorToolStripMenuItem
            // 
            this.separatorToolStripMenuItem.Name = "separatorToolStripMenuItem";
            this.separatorToolStripMenuItem.Size = new System.Drawing.Size(140, 6);
            // 
            // seperatorToolStripMenuItem1
            // 
            this.seperatorToolStripMenuItem1.Name = "seperatorToolStripMenuItem1";
            this.seperatorToolStripMenuItem1.Size = new System.Drawing.Size(140, 6);
            // 
            // seperatorToolStripMenuItem
            // 
            this.seperatorToolStripMenuItem.Name = "seperatorToolStripMenuItem";
            this.seperatorToolStripMenuItem.Size = new System.Drawing.Size(140, 6);
            // 
            // Panel_Center
            // 
            this.Panel_Center.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Center.Location = new System.Drawing.Point(0, 30);
            this.Panel_Center.Name = "Panel_Center";
            this.Panel_Center.Size = new System.Drawing.Size(843, 378);
            this.Panel_Center.TabIndex = 1;
            // 
            // PictureBox_Settings
            // 
            this.PictureBox_Settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox_Settings.ContextMenuStrip = this.Menu_Settings;
            this.PictureBox_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Settings.Image = global::C_Bot.Properties.Resources.Setting_Default;
            this.PictureBox_Settings.Location = new System.Drawing.Point(175, 3);
            this.PictureBox_Settings.Name = "PictureBox_Settings";
            this.PictureBox_Settings.Size = new System.Drawing.Size(22, 22);
            this.PictureBox_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox_Settings.TabIndex = 0;
            this.PictureBox_Settings.TabStop = false;
            this.PictureBox_Settings.Click += new System.EventHandler(this.PictureBox_Settings_Click);
            this.PictureBox_Settings.MouseEnter += new System.EventHandler(this.PictureBox_Settings_MouseEnter);
            this.PictureBox_Settings.MouseLeave += new System.EventHandler(this.PictureBox_Settings_MouseLeave);
            // 
            // PictureBox_Scripts
            // 
            this.PictureBox_Scripts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox_Scripts.ContextMenuStrip = this.Menu_Settings;
            this.PictureBox_Scripts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Scripts.Image = global::C_Bot.Properties.Resources.Scripts_Default;
            this.PictureBox_Scripts.Location = new System.Drawing.Point(147, 3);
            this.PictureBox_Scripts.Name = "PictureBox_Scripts";
            this.PictureBox_Scripts.Size = new System.Drawing.Size(22, 22);
            this.PictureBox_Scripts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox_Scripts.TabIndex = 1;
            this.PictureBox_Scripts.TabStop = false;
            this.PictureBox_Scripts.MouseEnter += new System.EventHandler(this.PictureBox_Scripts_MouseEnter);
            this.PictureBox_Scripts.MouseLeave += new System.EventHandler(this.PictureBox_Scripts_MouseLeave);
            // 
            // PictureBox_Statistics
            // 
            this.PictureBox_Statistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox_Statistics.ContextMenuStrip = this.Menu_Settings;
            this.PictureBox_Statistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Statistics.Image = global::C_Bot.Properties.Resources.Statistics_Default;
            this.PictureBox_Statistics.Location = new System.Drawing.Point(119, 3);
            this.PictureBox_Statistics.Name = "PictureBox_Statistics";
            this.PictureBox_Statistics.Size = new System.Drawing.Size(22, 22);
            this.PictureBox_Statistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox_Statistics.TabIndex = 2;
            this.PictureBox_Statistics.TabStop = false;
            this.PictureBox_Statistics.MouseEnter += new System.EventHandler(this.PictureBox_Statistics_MouseEnter);
            this.PictureBox_Statistics.MouseLeave += new System.EventHandler(this.PictureBox_Statistics_MouseLeave);
            // 
            // startScriptToolStripMenuItem
            // 
            this.startScriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startScriptToolStripMenuItem.Image")));
            this.startScriptToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startScriptToolStripMenuItem.Name = "startScriptToolStripMenuItem";
            this.startScriptToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.startScriptToolStripMenuItem.Text = "Start Script";
            // 
            // stopScriptToolStripMenuItem
            // 
            this.stopScriptToolStripMenuItem.Enabled = false;
            this.stopScriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stopScriptToolStripMenuItem.Image")));
            this.stopScriptToolStripMenuItem.Name = "stopScriptToolStripMenuItem";
            this.stopScriptToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.stopScriptToolStripMenuItem.Text = "Stop Script";
            // 
            // restartScriptToolStripMenuItem
            // 
            this.restartScriptToolStripMenuItem.Enabled = false;
            this.restartScriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restartScriptToolStripMenuItem.Image")));
            this.restartScriptToolStripMenuItem.Name = "restartScriptToolStripMenuItem";
            this.restartScriptToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.restartScriptToolStripMenuItem.Text = "Restart Script";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountsToolStripMenuItem.Image")));
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.accountsToolStripMenuItem.Text = "Accounts";
            this.accountsToolStripMenuItem.ToolTipText = "Manager Accounts";
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.accountsToolStripMenuItem_Click);
            // 
            // botNetworkToolStripMenuItem
            // 
            this.botNetworkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInToolStripMenuItem,
            this.seperatorToolStripMenuItem2,
            this.profileToolStripMenuItem});
            this.botNetworkToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("botNetworkToolStripMenuItem.Image")));
            this.botNetworkToolStripMenuItem.Name = "botNetworkToolStripMenuItem";
            this.botNetworkToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.botNetworkToolStripMenuItem.Text = "Bot network";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("signInToolStripMenuItem.Image")));
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.signInToolStripMenuItem.Text = "Sign in";
            // 
            // seperatorToolStripMenuItem2
            // 
            this.seperatorToolStripMenuItem2.Name = "seperatorToolStripMenuItem2";
            this.seperatorToolStripMenuItem2.Size = new System.Drawing.Size(107, 6);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Enabled = false;
            this.profileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profileToolStripMenuItem.Image")));
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 408);
            this.Controls.Add(this.Panel_Center);
            this.Controls.Add(this.Panel_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interface";
            this.Text = "Interface";
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Shortcuts.ResumeLayout(false);
            this.Panel_Shortcuts.PerformLayout();
            this.Menu_Settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Scripts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Statistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Panel Panel_Center;
        private System.Windows.Forms.PictureBox PictureBox_Settings;
        private System.Windows.Forms.ContextMenuStrip Menu_Settings;
        private System.Windows.Forms.ToolStripMenuItem startScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.PictureBox PictureBox_Scripts;
        private System.Windows.Forms.ToolStripSeparator seperatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox PictureBox_Statistics;
        private System.Windows.Forms.Panel Panel_Shortcuts;
        private System.Windows.Forms.ToolStripMenuItem restartScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator seperatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem botNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator seperatorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
    }
}