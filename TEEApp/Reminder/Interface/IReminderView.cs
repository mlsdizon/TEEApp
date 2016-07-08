﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEEApp.Base.Views;
using TEEAppModel;

namespace TEEApp.Reminder.Interface
{
    public interface IReminderView : IView
    {
        int OwnerId { get; set; }
        String ReminderText { get; set; }
        DateTime ReminderDate { get; set; }

        void BindEmployee(List<Employee> list);
    }
}
