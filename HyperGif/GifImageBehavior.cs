using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace HyperGif
{
    public static class GifImageBehavior
    {
        public static ImageSource GetGifSource(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(GifSourceProperty);
        }

        public static void SetGifSource(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(GifSourceProperty, value);
        }

        // Using a DependencyProperty as the backing store for GifSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GifSourceProperty =
            DependencyProperty.RegisterAttached("GifSource", typeof(ImageSource), typeof(GifImageBehavior), new PropertyMetadata(null, new PropertyChangedCallback(OnGifSourcePropertyChanged)));

        static void OnGifSourcePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args) 
        {
            (sender as Image).Source = args.NewValue as ImageSource;
        }
    }
}
