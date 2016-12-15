namespace ConnectTool.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using System.Threading;

    using ConnectTool.Interface.PopupMessage;

    using GalaSoft.MvvmLight.CommandWpf;

    public partial class MainViewModel
    
    {
        public Queue<IPopupMessage> PopupMessageQueue = new Queue<IPopupMessage>();

        private IPopupMessage _popupMessage;

        private bool popupMessageVisible;

      

        private void CancelPopupMessage()
        {
            this.PopupMessageVisible = false;
            this.PopupMessageIsDisplaying = false;
        }

        public RelayCommand HideErrorMessage { get; private set; }

        public IPopupMessage PopupMessage
        {
            get
            {
                return this._popupMessage;
            }

            set
            {
                this._popupMessage = value;
                this.RaisePropertyChanged();
            }
        }

        public bool PopupMessageVisible
        {
            get
            {
                return this.popupMessageVisible;
            }

            set
            {
                this.popupMessageVisible = value;
                this.RaisePropertyChanged();
            }
        }

        private bool PopupMessageIsDisplaying { get; set; } = false;
        private System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        protected void DisplayPopupMessage()
        {
            if (this.PopupMessageIsDisplaying || this.PopupMessageQueue.Count <= 0) return;

            PopupMessage = this.PopupMessageQueue.Dequeue();

            this.dispatcherTimer.Interval = PopupMessage.Duration;
            this.PopupMessageIsDisplaying = true;
            this.PopupMessageVisible = true;
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            this.dispatcherTimer.Start();


            //PopupMessage = this.PopupMessageQueue.Dequeue();
            //if (PopupMessage == null) return;

            //this.PopupMessageIsDisplaying = true;
            //this.PopupMessageVisible = true;
            //if (PopupMessage.Duration > TimeSpan.Zero) this.HideErrorMessageAfter(PopupMessage.Duration);


        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            this.PopupMessageVisible = false;
            this.PopupMessageIsDisplaying = false;
            dispatcherTimer.Stop();
            DisplayPopupMessage();
        }

        //protected async void HideErrorMessageAfter(TimeSpan delayTime)
        //{
        //    await Task.Delay(delayTime);
        //    this.PopupMessageVisible = false;
        //    this.PopupMessageIsDisplaying = false;
        //}

        private void UpdatePopupMessage(IPopupMessage obj)
        {
            this.PopupMessageQueue.Enqueue(obj);
            this.DisplayPopupMessage();
        }
    }
}