using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEApp.Base.Interface
{
    public interface IView
    {
        void ShowErrorDialog(String msg);

        void ShowErrorDialog(Exception ex, String msg);

        void ShowInfoDialog(String msg, String caption);

        /// <summary>
        /// Turns wait cursor on
        /// </summary>
        void WaitCursorOn();

        /// <summary>
        /// sets cursor to the cursor that existed before WaitCursorOn called
        /// </summary>
        void WaitCursorOff();
    }
}
