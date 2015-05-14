namespace Win10InkCanvas.ViewModels
{
    using Base;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Windows.UI.Xaml.Navigation;

    public class UsingMVVMViewModel : ViewModelBase
    {
        DelegateCommand goBackCommand;

        /// <summary>
        /// Default constructor
        /// </summary>
        public UsingMVVMViewModel()
        {
            this.goBackCommand = new DelegateCommand(GoBackCommandExecute);
        }

        /// <summary>
        /// Command to go back to previous page.
        /// </summary>
        public ICommand GoBackCommand
        {
            get { return this.goBackCommand; }
        }

        /// <summary>
        /// Method raised when the user navigates away this page.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public override Task OnNavigatedFrom(NavigationEventArgs e)
        {
            return null;
        }

        /// <summary>
        /// Method raised when the user navigates to this page.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public override Task OnNavigatedTo(NavigationEventArgs e)
        {
            return null;
        }

        private void GoBackCommandExecute()
        {
            base.AppFrame.GoBack();
        }
    }
}
