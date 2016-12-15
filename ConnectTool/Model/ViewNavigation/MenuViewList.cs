using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectTool.Interface;
using GalaSoft.MvvmLight;

namespace ConnectTool.Model.ViewNavigation
{
    /// <summary>
    /// The navigational view list.
    /// </summary>
    public class MenuViewList : ViewModelBase
    {
        /// <summary>
        /// The navigation list.
        /// </summary>
        private Dictionary<string, IDisplayable> menuNavigationList = new Dictionary<string, IDisplayable>();

        /// <summary>
        /// Gets or sets the navigation list.
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
    }
}
