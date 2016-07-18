using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEEApp.Base.Interface;
using TEEApp.Base.Views;
using TEEApp.Reminder.Views;
using TEEAppModel;

namespace TEEApp.Base.Presenters
{
    public class LoginPresenter : Presenter<LoginView>
    {
        private readonly TEEAppContext context;

        public LoginPresenter(LoginView view)
            : base(view)
        {
            this.context = new TEEAppContext();
            this.Initialise();
        }

        protected override void OnInitialise()
        {
             this.view.BindEmployees(this.context.Employees.ToList());
        }

        public void DoLogin()
        {
            if (this.view.EmployeeId != null && this.context.Employees.Find((int)this.view.EmployeeId) != null)
            {
                Session.EmployeeId = (int)this.view.EmployeeId;
                this.view.DoLoginSuccess();
            }
            else
            {
                this.view.ShowErrorDialog("Employee name does not exist in the Database.");
            }
        }
    }
}
