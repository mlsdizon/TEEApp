using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEEAppModel;
using TEEApp.Base.Presenters;
using TEEApp.Base.Interface;

namespace TEEApp.Base.Views
{
    public partial class LoginView : BaseUserControl
    {
        public LoginPresenter presenter;

        public LoginView()
        {
            InitializeComponent();
            this.presenter = new LoginPresenter(this);
        }

        public void BindEmployees(List<Employee> list)
        {
            this.BindDropDownList<Employee>(this.employeeBindingSource, list, this.ddlEmployees, true);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.WaitCursorOn();
            this.presenter.DoLogin();
            this.WaitCursorOff();
        }

        public void DoLoginSuccess()
        {
            Form f = this.Parent as Form;
            if (f != null) f.DialogResult = DialogResult.OK;
        }

        public object EmployeeId 
        {
            get { return this.ddlEmployees.SelectedValue; }
        }
    }
}
