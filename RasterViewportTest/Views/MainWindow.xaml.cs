using RasterViewport.Core;
using System.Diagnostics;
using System.Windows;

namespace RasterViewportTest.Views
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RasterViewport.Uniform();
        }

        private void RasterViewport_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ShowInfo();
        }

        private void RasterViewport_ViewportRendered(object sender, RoutedEventArgs e)
        {
            ShowInfo();
        }

        private void ShowInfo()
        {
            Label_SourceSize.Content = string.Format("SourceSize : {0}", RasterViewport.SourceSize);
            Label_RenderingAreaSize.Content = string.Format("RenderingAreaSize : {0}", RasterViewport.RenderingAreaSize);
            Label_SourceOffsetPoint.Content = string.Format("SourceOffsetPoint : {0}", RasterViewport.SourceOffsetPoint);
            Label_ScaleFactor.Content = string.Format("ScaleFactor : {0}", RasterViewport.ScaleFactor);
            try
            {
                Label_RenderedRenderingAreaRect.Content = string.Format("RenderedRenderingAreaRect : {0}", RasterViewport.RenderedRenderingAreaRect);
            }
            catch (NotIncludeException)
            {
                Label_RenderedRenderingAreaRect.Content = "N/A";
            }
            try
            {
                Label_RenderedSourceRect.Content = string.Format("RenderedSourceRect : {0}", RasterViewport.RenderedSourceRect);
            }
            catch (NotIncludeException)
            {
                Label_RenderedSourceRect.Content = "N/A";
            }
            Label_ScaledSourceSize.Content = string.Format("ScaledSourceSize : {0}", RasterViewport.ScaledSourceSize);
            Label_ViewportRect.Content = string.Format("ViewportRect : {0}", RasterViewport.ViewportRect);
            Label_ViewportCenterDefault.Content = string.Format("ViewportCenterDefault : {0}", RasterViewport.ViewportCenterDefault);
            Label_ViewportCenterCurrent.Content = string.Format("ViewportCenterCurrent : {0}", RasterViewport.ViewportCenterCurrent);
            Label_ViewportLeftTopDefault.Content = string.Format("ViewportLeftTopDefault : {0}", RasterViewport.ViewportLeftTopDefault);
            Label_ViewportLeftTopCurrent.Content = string.Format("ViewportLeftTopCurrent : {0}", RasterViewport.ViewportLeftTopCurrent);
            Label_ViewportBottomRightDefault.Content = string.Format("ViewportBottomRightDefault : {0}", RasterViewport.ViewportBottomRightDefault);
            Label_ViewportBottomRightCurrent.Content = string.Format("ViewportBottomRightCurrent : {0}", RasterViewport.ViewportBottomRightCurrent);
        }

        private void RasterViewport_PixelPointed(object sender, RasterViewport.Views.RasterViewport.PixelPointedEventArgs e)
        {
            Trace.WriteLine(string.Format("(X, Y, B, G, R, A) = ({0}, {1}, {2}, {3}, {4}, {5})", e.X, e.Y, e.B, e.G, e.R, e.A));
            Label_Pointed.Content = string.Format("MousePointed : ({0}, {1})", e.X, e.Y);
        }
    }
}
