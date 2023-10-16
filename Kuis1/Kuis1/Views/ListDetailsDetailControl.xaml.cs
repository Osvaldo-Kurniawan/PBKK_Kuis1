using System;

using Kuis1.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Kuis1.Views
{
    public sealed partial class ListDetailsDetailControl : UserControl
    {
        public SamplePhoto ListMenuItem
        {
            get { return GetValue(ListMenuItemProperty) as SamplePhoto; }
            set { SetValue(ListMenuItemProperty, value); }
        }

        public static readonly DependencyProperty ListMenuItemProperty = DependencyProperty.Register("ListMenuItem", typeof(SamplePhoto), typeof(ListDetailsDetailControl), new PropertyMetadata(null, OnListMenuItemPropertyChanged));

        public ListDetailsDetailControl()
        {
            InitializeComponent();
        }

        private static void OnListMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ListDetailsDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
