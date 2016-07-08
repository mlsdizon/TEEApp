using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEEAppModel;

namespace TEEApp.Reminder.Interface
{
    public interface IReminderView
    {
        String ReminderText { get; }
        DateTime ReminderDate { get; }

        void BindEmployee(List<Employee> list);
    }
}
