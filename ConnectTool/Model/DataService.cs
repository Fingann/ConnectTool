// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataService.cs" company="BKK">
//   
// </copyright>
// <summary>
//   The data service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ConnectTool.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ConnectTool.Interface;
    using ConnectTool.Model.ViewNavigation;

    /// <summary>
    /// The data service.
    /// </summary>
    public class DataService : IDataService
    {
        /// <summary>
        /// The get data.
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service
            var item = new DataItem("Welcome to MVVM Light");
            callback(item, null);
        }

        public void GetMenuNavigationalViews(Action<Dictionary<string,IDisplayable>, Exception> callback)
        {
            var displayableViews = new DisplayableViewList().ViewList;

            var navigationalViews = displayableViews
                .Where(p => p.Value is INavigationView)
                .ToDictionary(p => p.Key,
                    p => p.Value);

            callback(navigationalViews, null);
        }

        public void GetDisplayableViews(Action<Dictionary<string, IDisplayable>, Exception> callback)
        {
            // Use this to connect to the actual data service

            var displayableViews = new DisplayableViewList().ViewList;
            callback(displayableViews, null);
        }


    }
}