using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectTool.Model.PopupMessage
{
    using System.Windows.Media;

    using ConnectTool.Interface.PopupMessage;

    public class InfoPopupMessage : IPopupMessage
    {
        public string Description { get; set; }

        public TimeSpan Duration { get; set; } = TimeSpan.FromSeconds(4);

        /// <summary>
        /// Gets or sets the message color. Light Green 500
        /// </summary>
        public SolidColorBrush MessageColor { get; set; } = (SolidColorBrush)(new BrushConverter().ConvertFrom("#8BC34A"));

        public string Title { get; set; }
    }
}