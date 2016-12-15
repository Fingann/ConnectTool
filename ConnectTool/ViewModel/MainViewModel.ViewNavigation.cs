namespace ConnectTool.ViewModel
{
    using System.Collections.Generic;

    using ConnectTool.Interface;

    public partial class MainViewModel
    {
        /// <summary>
        ///     The current view model.
        /// </summary>
        private IDisplayable currentViewModel = new LoginViewModel();

        /// <summary>
        ///     The currentViewTitle title Displayed on top of the menu.
        /// </summary>
        private string currentViewTitle = "Login";

        /// <summary>
        ///     The navigation list.
        /// </summary>
        private Dictionary<string, IDisplayable> menuNavigationList = new Dictionary<string, IDisplayable>();

        /// <summary>
        ///     The view list.
        /// </summary>
        private Dictionary<string, IDisplayable> viewList = new Dictionary<string, IDisplayable>();

        /// <summary>
        ///     Gets or sets the current view model.
        /// </summary>
        public IDisplayable CurrentViewModel
        {
            get
            {
                if (this.IsLoggedIn) return this.currentViewModel;

                this.CurrentViewTitle = "Login";
                return new LoginViewModel();
            }

            set
            {
                this.currentViewModel = value;
                this.CurrentViewTitle = value.Title;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the welcome title.
        /// </summary>
        public string CurrentViewTitle
        {
            get
            {
                return this.currentViewTitle;
            }

            set
            {
                this.Set(ref this.currentViewTitle, value);
            }
        }

        /// <summary>
        ///     Gets or sets the navigation list.
        /// </summary>
        public Dictionary<string, IDisplayable> MenuNavigationList
        {
            get
            {
                return this.menuNavigationList;
            }

            set
            {
                this.menuNavigationList = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the view list.
        /// </summary>
        public Dictionary<string, IDisplayable> ViewList
        {
            get
            {
                return this.viewList;
            }

            set
            {
                this.viewList = value;
                this.RaisePropertyChanged();
            }
        }

        private void UpdateCurrentViewMessage(IDisplayable obj)
        {
            this.IsLoggedIn = true;
            this.CurrentViewModel = obj;
        }
    }
}