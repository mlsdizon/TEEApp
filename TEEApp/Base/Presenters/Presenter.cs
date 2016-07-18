using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEEApp.Base.Interface;
using TEEApp.Base.Views;
using TEEAppModel;

namespace TEEApp.Base.Presenters
{
    public abstract class Presenter<T> : IPresenter where T : IView
    {
        /// <summary>
        /// View that presenter controls
        /// </summary>
        protected T view;

        /// <summary>
        /// returns view as a IView
        /// </summary>
        public IView View { get { return this.view; } }

        /// <summary>
        /// tracks initialised state
        /// </summary>
        protected Boolean isInitialised;

        /// <summary>
        /// Initialised state.
        /// true if presenter is ready to function.
        /// </summary>
        /// <returns></returns>
        public Boolean IsInitialised()
        {
            return this.isInitialised;
        }

        /// <summary>
        /// Initialise presenter.
        /// If initialised already does nothing
        /// </summary>
        public virtual void Initialise()
        {
            if (this.IsInitialised()) return;

            //this.view.WaitCursorOn();

            this.isInitialised = true;
            this.OnInitialise();

            //this.view.WaitCursorOff();
        }

        protected Presenter(T view)
        {
            this.view = view;
            //this.contextFactory = contextFactory;
            //this.session = session;
            this.isInitialised = false;
            //this.isDisposing = false;
            //this.isDisposed = false;
            //this.DisposeContextOnClearAndDispose = true; //by default context,if any, gets disposed.

            ////call presenter clear on view disposed
            //this.view.Disposed += this.OnViewDisposed;
        }

        protected abstract void OnInitialise();

        /// <summary>
        /// Calls save changes on presenter's context.
        /// All exceptions are caught from the SaveChanges() call.
        /// </summary>
        /// <param name="context"></param>
        /// <returns>false on exception or context is null, true on no exception</returns>
        public virtual Boolean SaveChanges()
        {
            return true;
        }

        public virtual Boolean SaveChanges(TEEAppContext ctx)
        {
            try
            {
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
