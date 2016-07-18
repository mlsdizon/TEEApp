using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEApp.Base.Interface
{
    public interface IPresenter
    {
        /// <summary>
        /// Get the view that the presenter controls
        /// </summary>
        IView View { get; }

        /// <summary>
        /// initialise the presenter so that it is in a state ready to be used.
        /// </summary>
        void Initialise();

        /// <summary>
        /// true if the presenter has been initialised
        /// </summary>
        /// <returns></returns>
        Boolean IsInitialised();

        /// <summary>
        /// saves changes to database
        /// </summary>
        /// <returns>true if succeeds false on exception</returns>
        Boolean SaveChanges();
    }
}
