namespace ConnectTool.Interface.PopupMessage
{
    using System;
    using System.Windows.Media;

    /// <summary>
    /// The PopupMessage interface.
    /// </summary>
    public interface IPopupMessage
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        TimeSpan Duration { get; set; }

        /// <summary>
        /// Gets or sets the message color.
        /// </summary>
        SolidColorBrush MessageColor { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        string Title { get; set; }
    }
}