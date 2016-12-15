// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CallerViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the CallerViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ConnectTool.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ConnectTool.Interface;
    using ConnectTool.Interface.PopupMessage;
    using ConnectTool.Model.PopupMessage;

    using GalaSoft.MvvmLight.CommandWpf;
    using GalaSoft.MvvmLight.Messaging;

    /// <summary>
    /// The caller view model.
    /// </summary>
    public class CallerViewModel: INavigationView, IDisplayable
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; } = "Caller View";



        public CallerViewModel()
        {
            MyCommand = new RelayCommand(
    ExecuteMyCommand);
        }

        public RelayCommand MyCommand
        {
            get;
            private set;
        }

        private void ExecuteMyCommand()
        {
            
            var popup = new ErrorPopupMessage() { Description = "Super TEST TEST TEST TEST TEST ", Title = "SuperTest" };
            Messenger.Default.Send<IPopupMessage>(popup);
        }
    }
}
