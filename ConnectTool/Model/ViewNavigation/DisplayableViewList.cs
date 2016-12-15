// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DisplayableViewList.cs" company="BKK">
//   
// </copyright>
// <summary>
//   Defines the DisplayableViewList type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ConnectTool.Model.ViewNavigation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ConnectTool.Interface;
    using ConnectTool.ViewModel;

    using GalaSoft.MvvmLight;

    /// <summary>
    /// The displayable view list.
    /// </summary>
    public class DisplayableViewList: ViewModelBase
    {
        /// <summary>
        /// The view list.
        /// </summary>
        private Dictionary<string, IDisplayable> viewList = new Dictionary<string, IDisplayable>
                                                                {
                                                                        { "Login", new LoginViewModel() },
                                                                        { "Caller", new CallerViewModel() }
                                                                };

        /// <summary>
        /// Gets or sets the view list.
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
    }
}
