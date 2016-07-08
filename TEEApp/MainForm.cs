using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TEEAppModel;
using Telerik.WinControls;
using System.Data.Entity;
using Telerik.WinControls.UI;

namespace TEEApp
{
    public partial class MainForm : RadForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void SetView(UserControl view)
        {
            this.Controls.Add(view);
            view.Dock = DockStyle.Fill;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon.Visible = false;
        }
    }
}
