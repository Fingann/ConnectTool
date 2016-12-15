// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataService.cs" company="BKK">
//   
// </copyright>
// <summary>
//   Defines the IDataService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ConnectTool.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using ConnectTool.Interface;

    /// <summary>
    /// The DataService interface.
    /// </summary>
    public interface IDataService
    {
        /// <summary>
        /// The get data.
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        void GetData(Action<DataItem, Exception> callback);

        /// <summary>
        /// The get navigational views.
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        void GetMenuNavigationalViews(Action<Dictionary<string, IDisplayable>, Exception> callback);

        /// <summary>
        /// The get displayable views.
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        void GetDisplayableViews(Action<Dictionary<string, IDisplayable>, Exception> callback);
    }
}
