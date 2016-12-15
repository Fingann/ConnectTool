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

        public InfoPopupMessage()
        {
            Duration = TimeSpan.FromSeconds(4);
            MessageColor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#8BC34A")); ;
        }

        public InfoPopupMessage(string title, string description, TimeSpan duration): this()
        {
            this.Description = description;
            this.Title = title;
            this.Duration = duration;

        }
        public InfoPopupMessage(string title, string description) : this()
        {
            this.Description = description;
            this.Title = title;


        }
     

        public InfoPopupMessage(string title, string description, TimeSpan duration, SolidColorBrush messageColor)
        {
            this.Description = description;
            this.Title = title;
            this.Duration = duration;
            this.MessageColor = messageColor;
        }


        public string Description { get; set; }

        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Gets or sets the message color. Light Green 500
        /// </summary>
        public SolidColorBrush MessageColor { get; set; }

        public string Title { get; set; }
    }
}