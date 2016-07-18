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
using System.Linq;

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TEEAppContext context = new TEEAppContext();
            //context.ReminderDetails.Load();
            //Console.WriteLine(context.ReminderDetails.Local.ToBindingList());

            Timer reminderTimer = new Timer();
            reminderTimer.Interval = 60000; //Note: 1 min interval
            reminderTimer.Tick += reminderTimer_Tick;
            reminderTimer.Enabled = true;
        }

        void reminderTimer_Tick(object sender, EventArgs e)
        {
            using (TEEAppContext tempCtx = new TEEAppContext())
            {
                tempCtx.ReminderDetails.ToList();
            }
        }
    }
}
