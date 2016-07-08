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
    public partial class BaseUserControl : UserControl
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
    }
}
