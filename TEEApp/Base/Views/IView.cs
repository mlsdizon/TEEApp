using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEApp.Base.Views
{
    public interface IView
    {
        void ShowErrorDialog(String msg);

        void ShowErrorDialog(Exception ex, String msg);

        void ShowInfoDialog(String msg, String caption);
    }
}
