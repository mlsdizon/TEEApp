using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEEApp.Reminder.Interface;
using TEEAppModel;

namespace TEEApp.Reminder.Presenters
{
    public class ReminderPresenter
    {
        private readonly IReminderView view;

        private TEEAppContext context;

        public ReminderPresenter(IReminderView view)
        {
            this.view = view;
            this.context = new TEEAppContext();
            this.view.BindEmployee(this.context.Employees.ToList());
        }

        public void AddReminder(int ownerId, string reminderText, DateTime reminderDate)
        {
            ReminderDetail rDetails = new ReminderDetail();
            rDetails.OwnerId = ownerId;
            rDetails.ReminderText = reminderText;
            rDetails.ReminderTime = reminderDate;

            this.context.ReminderDetails.Add(rDetails);
            this.context.SaveChanges();
        }
    }
}
