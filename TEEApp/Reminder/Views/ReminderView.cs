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
using TEEApp.Reminder.Interface;
using TEEApp.Reminder.Presenters;

namespace TEEApp.Reminder.Views
{
    public partial class ReminderView : BaseUserControl, IReminderView
    {
        private ReminderPresenter presenter;

        public ReminderView()
        {
            InitializeComponent();
            this.presenter = new ReminderPresenter(this);
        }

        public void BindEmployee(List<Employee> list)
        {
            this.BindDropDownList(this.employeeBindingSource, list, this.ddlEmployee, true);
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

        public int OwnerId
        {
            get { return (int)this.ddlEmployee.SelectedValue; }
            set { this.ddlEmployee.SelectedIndex = value; }
        }

        private void ddlEmployee_Validating(object sender, CancelEventArgs e)
        {
            if (this.ddlEmployee.SelectedValue == null)
            {
                this.errorProvider.SetError(this.ddlEmployee, "Required Field.");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider.SetError(this.ddlEmployee, "");
            }
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            this.presenter.AddReminder(this.OwnerId, this.ReminderText, this.ReminderDate);
        }
    }
}
