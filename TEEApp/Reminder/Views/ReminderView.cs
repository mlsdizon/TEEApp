using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEEApp.Base.Views;
using TEEAppModel;
using TEEApp.Reminder.Presenters;

namespace TEEApp.Reminder.Views
{
    public partial class ReminderView : BaseUserControl
    {
        private ReminderPresenter presenter;

        public ReminderView()
        {
            InitializeComponent();
            this.presenter = new ReminderPresenter(this);

            this.ReminderDate = DateTime.Now;
        }

        public String ReminderText
        {
            get { return this.txtReminder.Text; }
            set { this.txtReminder.Text = value; }
        }

        public DateTime ReminderDate
        {
            get { return this.dtpReminderMeOn.Value; }
            set { this.dtpReminderMeOn.Value = value; }
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            this.presenter.AddReminder();
        }
    }
}
