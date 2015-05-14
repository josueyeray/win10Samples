namespace Win10InkCanvas.Views
{
    using Windows.Foundation;
    using Windows.UI;
    using Windows.UI.Input.Inking;
    using Windows.UI.Xaml.Input;

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MultipleSurfacesView
    {
        InkDrawingAttributes dAtt;

        public MultipleSurfacesView()
        {
            this.InitializeComponent();

            this.dAtt = new InkDrawingAttributes();
            this.dAtt.Color = Colors.Black;
            this.dAtt.DrawAsHighlighter = false;
            this.dAtt.PenTip = PenTipShape.Circle;
            this.dAtt.Size = new Size(2,2);

            InkCanvasControl.InkPresenter.UpdateDefaultDrawingAttributes(this.dAtt);
            InkCanvasControl.InkPresenter.InputDeviceTypes = Windows.UI.Core.CoreInputDeviceTypes.Mouse | Windows.UI.Core.CoreInputDeviceTypes.Pen | Windows.UI.Core.CoreInputDeviceTypes.Touch;
        }

        private void Pen_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.dAtt.Color = Colors.Black;
            this.dAtt.DrawAsHighlighter = false;
            this.dAtt.PenTip = PenTipShape.Circle;
            this.dAtt.Size = new Size(2,2);

            InkCanvasControl.InkPresenter.UpdateDefaultDrawingAttributes(this.dAtt);
        }

        private void Green_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.dAtt.Color = Colors.LightGreen;
            this.dAtt.DrawAsHighlighter = true;
            this.dAtt.PenTip = PenTipShape.Rectangle;
            this.dAtt.Size = new Size(4, 15);

            InkCanvasControl.InkPresenter.UpdateDefaultDrawingAttributes(this.dAtt);
        }

        private void Blue_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.dAtt.Color = Colors.LightBlue;
            this.dAtt.DrawAsHighlighter = true;
            this.dAtt.PenTip = PenTipShape.Rectangle;
            this.dAtt.Size = new Size(4, 15);

            InkCanvasControl.InkPresenter.UpdateDefaultDrawingAttributes(this.dAtt);
        }

        private void Pink_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.dAtt.Color = Colors.Pink;
            this.dAtt.DrawAsHighlighter = true;
            this.dAtt.PenTip = PenTipShape.Rectangle;
            this.dAtt.Size = new Size(4, 15);

            InkCanvasControl.InkPresenter.UpdateDefaultDrawingAttributes(this.dAtt);
        }
    }
}
