namespace Win10InkCanvas.ViewModels.Base
{
    using Autofac;

    /// <summary>
    /// Locator class for viewmodels and service, IoC
    /// </summary>
    public class ViewModelLocator
    {
        private IContainer container;

        public ViewModelLocator()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<BasicInkViewModel>();
            builder.RegisterType<MultipeSurfaceViewModel>();
            builder.RegisterType<UsingMVVMViewModel>();

            this.container = builder.Build();
        }

        /// <summary>
        /// MainView viewmodel.
        /// </summary>
        public MainViewModel MainVM
        {
            get { return this.container.Resolve<MainViewModel>(); }
        }

        /// <summary>
        /// Basic Ink Viewmodel.
        /// </summary>
        public BasicInkViewModel BasicInkVM
        {
            get { return this.container.Resolve<BasicInkViewModel>(); }
        }

        /// <summary>
        /// Multiple surface Viewmodel
        /// </summary>
        public MultipeSurfaceViewModel MultipeSurfaceVM
        {
            get { return this.container.Resolve<MultipeSurfaceViewModel>(); }
        }

        /// <summary>
        /// Multiple surface using MVVM Viewmodel
        /// </summary>
        public UsingMVVMViewModel UsingMVVMVM
        {
            get { return this.container.Resolve<UsingMVVMViewModel>(); }
        }
    }
}
