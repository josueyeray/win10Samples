namespace Win10InkCanvas.Views.Base
{
    using Win10InkCanvas.ViewModels.Base;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;


    /// <summary>
    /// Base class for all views
    /// </summary>
    public class ViewBase : Page
    {
        ViewModelBase vmBase;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (this.vmBase == null)
            {
                this.vmBase = (ViewModelBase)this.DataContext;
            }

            this.vmBase.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            this.vmBase.OnNavigatedFrom(e);
        }
    }
}
