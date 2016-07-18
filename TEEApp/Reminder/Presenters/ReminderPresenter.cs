using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEEApp.Base.Presenters;
using TEEApp.Reminder.Views;
using TEEAppModel;

namespace TEEApp.Reminder.Presenters
{
    public class ReminderPresenter : Presenter<ReminderView>
    {
        private TEEAppContext context;

        public ReminderPresenter(ReminderView view)
            :base(view)
        {
            this.view = view;
            this.context = new TEEAppContext();
        }

        protected override void OnInitialise()
        {
            
        }

        public void AddReminder()
        {
            ReminderDetail rDetails = new ReminderDetail();
            rDetails.OwnerId = Session.EmployeeId;
            rDetails.ReminderText = this.view.ReminderText;
            rDetails.ReminderTime = this.view.ReminderDate;

            this.context.ReminderDetails.Add(rDetails);
            if (this.SaveChanges(this.context))
            {
                this.view.ShowInfoDialog("Reminder Successfully Added.", "Reminder");
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
