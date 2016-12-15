// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignDataService.cs" company="BKK">
//   
// </copyright>
// <summary>
//   Defines the DesignDataService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ConnectTool.Design
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ConnectTool.Interface;
    using ConnectTool.Model;
    using ConnectTool.Model.ViewNavigation;

    /// <summary>
    /// The design data service.
    /// </summary>
    public class DesignDataService : IDataService
    {
        /// <summary>
        /// The get data.
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data
            var item = new DataItem("Welcome to MVVM Light [design]");
            callback(item, null);
        }

        /// <summary>
        /// The get navigational views.
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        public void GetMenuNavigationalViews(Action<Dictionary<string, IDisplayable>, Exception> callback)
        {
            var displayableViews = new DisplayableViewList().ViewList;

            var navigationalViews = displayableViews.Where(p => p.Value is INavigationView)
                .ToDictionary(p => p.Key, p => p.Value);

            callback(navigationalViews, null);
        }

        /// <summary>
        /// The get displayable views.
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        public void GetDisplayableViews(Action<Dictionary<string, IDisplayable>, Exception> callback)
        {
            // Use this to connect to the actual data service
            var displayableViews = new DisplayableViewList().ViewList;
            callback(displayableViews, null);
        }
    }
}