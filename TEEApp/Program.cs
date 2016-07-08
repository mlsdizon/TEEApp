﻿using System;
using System.Linq;
using System.Windows.Forms;
using TEEApp.Base.Views;
using TEEApp.Reminder.Views;

namespace TEEApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            form.SetView(new ReminderView());

            Application.Run(form);
        }
    }
}