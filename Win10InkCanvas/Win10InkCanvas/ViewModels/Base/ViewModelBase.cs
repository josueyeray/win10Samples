namespace Win10InkCanvas.ViewModels.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;



    /// <summary>
    /// Base ViewModel
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ViewModelBase()
        {
        }

        /// <summary>
        /// Exposes app frame to perform navigation tasks. 
        /// </summary>
        public Frame AppFrame
        {
            get { return App.RootFrame; }
        }

        /// <summary>
        /// Event to notify changes in properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Navigated to method called from base page.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public abstract Task OnNavigatedTo(NavigationEventArgs e);

        /// <summary>
        /// Navigated from method called from base page.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public abstract Task OnNavigatedFrom(NavigationEventArgs e);

        /// <summary>
        /// Raise PropertyChangfedE
        /// </summary>
        /// <param name="propertyName"></param>
        public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            var tmpHandler = PropertyChanged;
            if (tmpHandler != null)
            {
                tmpHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
