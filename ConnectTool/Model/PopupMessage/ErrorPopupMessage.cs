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

        public ErrorPopupMessage()
        {
            Duration = TimeSpan.FromSeconds(4);
            MessageColor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF3D00"));
        }

        public ErrorPopupMessage(string title, string description, TimeSpan duration): this()
        {
            this.Description = description;
            this.Title = title;
            this.Duration = duration;
           
        }
        public ErrorPopupMessage(string title, string description) : this()
        {
            this.Description = description;
            this.Title = title;
            

        }
        public ErrorPopupMessage(string title, Exception exception) : this()
        {
            this.Title = title;
            this.Description = exception.Message;

        }


        public ErrorPopupMessage(string title,string description, TimeSpan duration, SolidColorBrush messageColor)
        {
            this.Description = description;
            this.Title = title;
            this.Duration = duration;
            this.MessageColor = messageColor;
        }

        public string Description { get; set; }

        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Gets or sets the message color.Deep Orange A400
        /// </summary>
        public SolidColorBrush MessageColor { get; set; } 

        public string Title { get; set; }
    }
}
