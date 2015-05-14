using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Win10InkCanvas.Behaviors
{

    public class InkCanvasAttributesBehavior : DependencyObject, Microsoft.Xaml.Interactivity.IBehavior
    {
        private Image associatedImage;
        private InkDrawingAttributes dAttributes;

        private readonly DependencyProperty AssociatedInkCanvasProperty = DependencyProperty.Register("AssociatedInkCanvas", typeof(InkCanvas), typeof(InkCanvasAttributesBehavior), null);
        private readonly DependencyProperty PenSizeProperty = DependencyProperty.Register("PenSize", typeof(Size), typeof(InkCanvasAttributesBehavior), null);
        private readonly DependencyProperty PenColorProperty = DependencyProperty.Register("PenColor", typeof(Color), typeof(InkCanvasAttributesBehavior), null);
        private readonly DependencyProperty IsHighlighterProperty = DependencyProperty.Register("IsHighlighter", typeof(bool), typeof(InkCanvasAttributesBehavior), null);

        public DependencyObject AssociatedObject
        {
            get { return this.associatedImage; }
        }

        public InkCanvas AssociatedInkCanvas
        {
            get { return (InkCanvas)this.GetValue(AssociatedInkCanvasProperty); }
            set { this.SetValue(AssociatedInkCanvasProperty, value); }
        }

        public Size PenSize
        {
            get { return (Size)this.GetValue(PenSizeProperty); }
            set { this.SetValue(PenSizeProperty, value); }
        }

        public Color PenColor
        {
            get { return (Color)this.GetValue(PenColorProperty); }
            set { this.SetValue(PenColorProperty, value); }
        }

        public bool IsHighlighter
        {
            get { return (bool)this.GetValue(IsHighlighterProperty); }
            set { this.SetValue(IsHighlighterProperty, value); }
        }

        public void Attach(DependencyObject associatedObject)
        {
            dAttributes = new InkDrawingAttributes();

            this.associatedImage = (Image)associatedObject;
            this.associatedImage.Tapped += AssociatedImage_Tapped;
        }

        public void Detach()
        {
            if (this.associatedImage != null)
                this.associatedImage.Tapped -= AssociatedImage_Tapped;
        }

        private void AssociatedImage_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            dAttributes.Size = this.PenSize;
            dAttributes.Color = this.PenColor;
            dAttributes.DrawAsHighlighter = this.IsHighlighter;

            AssociatedInkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(dAttributes);
        }
    }
}
