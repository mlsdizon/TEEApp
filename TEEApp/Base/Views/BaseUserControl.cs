using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TEEApp.Base.Views
{
    public partial class BaseUserControl : UserControl, IView
    {
        public BaseUserControl()
        {
            InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = "Office2013Dark";
        }

        protected void BindDropDownList<T>(BindingSource bs, List<T> list, RadDropDownList ddl, Boolean nullSelection)
        {
            if (bs != null)
            {
                bs.DataSource = list;
                if (nullSelection)
                {
                    ddl.SelectedIndex = -1;
                }
            }
        }

        public void ShowErrorDialog(String msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void ShowErrorDialog(Exception ex, String msg)
        {
            MessageBox.Show("Phoenix has received this error : " + ex + ". kindly report this to your administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfoDialog(String msg, String caption)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
