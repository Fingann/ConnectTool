// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginViewModel.cs" company="BKK">
//   
// </copyright>
// <summary>
//   Defines the LoginViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ConnectTool.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;

    using ConnectTool.Interface;
    using ConnectTool.Interface.PopupMessage;
    using ConnectTool.Model.PopupMessage;

    using GalaSoft.MvvmLight.CommandWpf;
    using GalaSoft.MvvmLight.Messaging;

    /// <summary>
    /// The login view model.
    /// </summary>
    public class LoginViewModel : IDisplayable
    {

        public LoginViewModel()
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
            Messenger.Default.Send<IDisplayable>(new CallerViewModel());
            var popup = new InfoPopupMessage() {Description = "Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokke", Title = "Login"};
            Messenger.Default.Send<IPopupMessage>(popup);
        }

        /// <summary>
        /// The text.
        /// </summary>
        private string text = string.Empty;

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                this.text = value;
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; } = "Login View";
    }
}