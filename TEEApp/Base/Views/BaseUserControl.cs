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

        public void ShowErrorDialog(Exception ex, String msg)
        {
            MessageBox.Show(msg + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfoDialog(String caption, String msg)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
