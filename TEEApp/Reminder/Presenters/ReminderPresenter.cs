using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEEApp.Base.Presenters;
using TEEApp.Reminder.Interface;
using TEEAppModel;

namespace TEEApp.Reminder.Presenters
{
    public class ReminderPresenter : Presenter
    {
        private readonly IReminderView view;

        private TEEAppContext context;

        public ReminderPresenter(IReminderView view)
        {
            this.view = view;
            this.context = new TEEAppContext();
            this.view.BindEmployee(this.context.Employees.ToList());
        }

        public void AddReminder()
        {
            ReminderDetail rDetails = new ReminderDetail();
            rDetails.OwnerId = this.view.OwnerId;
            rDetails.ReminderText = this.view.ReminderText;
            rDetails.ReminderTime = this.view.ReminderDate;

            this.context.ReminderDetails.Add(rDetails);
            if (this.SaveChanges(this.context))
            {
                this.view.ShowInfoDialog("Reminder Successfully Added.", "Reminder");
                this.view.OwnerId = -1;
                this.view.ReminderText = String.Empty;
                this.view.ReminderDate = DateTime.Now;
            }
            else
            {
                this.view.ShowErrorDialog("Failed to Add Reminder.");
            }
        }
    }
}
