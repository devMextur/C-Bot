namespace C_Bot.Forms
{
    partial class Accounts
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
            this.DataGrid_Accounts = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBox_Add_Account = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Accounts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Add_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Accounts
            // 
            this.DataGrid_Accounts.AllowUserToAddRows = false;
            this.DataGrid_Accounts.AllowUserToDeleteRows = false;
            this.DataGrid_Accounts.AllowUserToResizeRows = false;
            this.DataGrid_Accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Accounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DataGrid_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password});
            this.DataGrid_Accounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_Accounts.Location = new System.Drawing.Point(381, 30);
            this.DataGrid_Accounts.Name = "DataGrid_Accounts";
            this.DataGrid_Accounts.RowHeadersVisible = false;
            this.DataGrid_Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Accounts.Size = new System.Drawing.Size(397, 307);
            this.DataGrid_Accounts.TabIndex = 0;
            this.DataGrid_Accounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Accounts_CellContentClick);
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PictureBox_Add_Account);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 30);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 307);
            this.panel2.TabIndex = 2;
            // 
            // PictureBox_Add_Account
            // 
            this.PictureBox_Add_Account.Image = global::C_Bot.Properties.Resources.Add_Account_Default;
            this.PictureBox_Add_Account.Location = new System.Drawing.Point(751, 3);
            this.PictureBox_Add_Account.Name = "PictureBox_Add_Account";
            this.PictureBox_Add_Account.Size = new System.Drawing.Size(22, 22);
            this.PictureBox_Add_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox_Add_Account.TabIndex = 0;
            this.PictureBox_Add_Account.TabStop = false;
            this.PictureBox_Add_Account.MouseEnter += new System.EventHandler(this.PictureBox_Add_Account_MouseEnter);
            this.PictureBox_Add_Account.MouseLeave += new System.EventHandler(this.PictureBox_Add_Account_MouseLeave);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 337);
            this.Controls.Add(this.DataGrid_Accounts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Accounts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Accounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Add_Account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Accounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PictureBox_Add_Account;
    }
}