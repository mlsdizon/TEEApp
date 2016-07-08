using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEEApp.Base.Views;
using TEEAppModel;

namespace TEEApp.Base.Presenters
{
    public class Presenter : BaseUserControl
    {
        public virtual Boolean SaveChanges(TEEAppContext ctx)
        {
            try
            {
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog(ex, "An Error has occured while saving the changes.");
                return false;
            }
        }
    }
}
