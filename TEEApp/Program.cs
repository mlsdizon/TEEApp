using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TEEApp.Base.Presenters;
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

            //login
            if (!DoLogin(new LoginPresenter(new LoginView())))
            {
                System.Windows.Forms.Application.Exit();
            }

            MainForm f = new MainForm();
            f.SetView(new ReminderView());
            Application.Run(f);
        }

        /// <summary>
        /// Do the login dialog
        /// </summary>
        /// <param name="unity"></param>
        private static Boolean DoLogin(LoginPresenter pLogin)
        {
            //login
            using (Form loginForm = new Form())
            {
                loginForm.Text = "Login";
                loginForm.AutoSize = true;
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.Controls.Add((BaseUserControl)pLogin.View);
                loginForm.Icon = TEEApp.Properties.Resources.Icon;
                return loginForm.ShowDialog() == DialogResult.OK;
            }
        }
    }
}