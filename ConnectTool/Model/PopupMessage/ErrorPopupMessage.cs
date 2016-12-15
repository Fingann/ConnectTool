using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectTool.Model.PopupMessage
{
    using System.Windows.Media;

    using ConnectTool.Interface.PopupMessage;

    /// <summary>
    /// The error popup message.
    /// </summary>
    public class ErrorPopupMessage : IPopupMessage
    {
        public string Description { get; set; }

        public TimeSpan Duration { get; set; } = TimeSpan.FromSeconds(4);

        /// <summary>
        /// Gets or sets the message color.Deep Orange A400
        /// </summary>
        public SolidColorBrush MessageColor { get; set; } = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF3D00"));

        public string Title { get; set; }
    }
}
