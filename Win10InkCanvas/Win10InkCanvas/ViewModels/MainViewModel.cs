namespace Win10InkCanvas.ViewModels
{
    using System.Threading.Tasks;
    using Base;
    using Windows.UI.Xaml.Navigation;
    using System.Windows.Input;
    using Win10InkCanvas.Views;




    /// <summary>
    /// MainView page viewmodel.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private DelegateCommand navigateToBasicInkCommand;
        private DelegateCommand navigateToMultipleSurfacesCommand;
        private DelegateCommand navigateToMultipleSurfacesMVVMCommand;

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainViewModel()
        {
            this.navigateToBasicInkCommand = new DelegateCommand(NavigateToBasicInkExecute);
            this.navigateToMultipleSurfacesCommand = new DelegateCommand(NavigateToMultipleSurfacesExecute);
            this.navigateToMultipleSurfacesMVVMCommand = new DelegateCommand(NavigateToMultipleSurfacesMVVMExecute);
        }

        /// <summary>
        /// Command to navigate to basic ink demo view
        /// </summary>
        public ICommand NavigateToBasicInkCommand
        {
            get { return this.navigateToBasicInkCommand; }
        }

        /// <summary>
        /// Command to navigate to multiple surfaces demo view
        /// </summary>
        public ICommand NavigateToMultipleSurfacesCommand
        {
            get { return this.navigateToMultipleSurfacesCommand; }
        }

        /// <summary>
        /// Command to navigate to multiple surfaces using mvvm demo view
        /// </summary>
        public ICommand NavigateToMultipleSurfacesMVVMCommand
        {
            get { return this.navigateToMultipleSurfacesMVVMCommand; }
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

        private void NavigateToBasicInkExecute()
        {
            base.AppFrame.Navigate(typeof(BasicInkView));
        }

        private void NavigateToMultipleSurfacesExecute()
        {
            base.AppFrame.Navigate(typeof(MultipleSurfacesView));
        }

        private void NavigateToMultipleSurfacesMVVMExecute()
        {
            base.AppFrame.Navigate(typeof(UsingMVVMView));
        }
    }
}
