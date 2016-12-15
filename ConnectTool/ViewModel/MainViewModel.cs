// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainViewModel.cs" company="BKK">
// </copyright>
// <summary>
//   This class contains properties that the main View can data bind to.
//   <para>
//   See http://www.mvvmlight.net
//   </para>
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ConnectTool.ViewModel
{
    using ConnectTool.Interface;
    using ConnectTool.Interface.PopupMessage;
    using ConnectTool.Model;

    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.CommandWpf;

    /// <summary>
    ///     The main view model.
    /// </summary>
    public partial class MainViewModel : ViewModelBase
    {
        /// <summary>
        ///     The _data service.
        /// </summary>
        private readonly IDataService dataService;

        /// <summary>
        ///     Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// <param name="dataService">
        ///     The data Service.
        /// </param>
        public MainViewModel(IDataService dataService)
        {
            //RelayCommands
            this.HideErrorMessage = new RelayCommand(this.CancelPopupMessage);
            this.MessengerInstance.Register<IPopupMessage>(this, this.UpdatePopupMessage);

            // Messenges
            this.MessengerInstance.Register<IDisplayable>(this, this.UpdateCurrentViewMessage);

            // ViewSetup, Sort INavigationViews
            this.dataService = dataService;

            this.dataService.GetDisplayableViews(
                (item, error) =>
                    {
                        if (error != null) return;

                        this.ViewList = item;
                    });

            this.dataService.GetMenuNavigationalViews(
                (item, error) =>
                    {
                        if (error != null) return;

                        this.MenuNavigationList = item;
                    });
        }

        /// <summary>
        ///     Gets or sets a value indicating whether user is logged in.
        /// </summary>
        private bool IsLoggedIn { get; set; }
        
    }
}