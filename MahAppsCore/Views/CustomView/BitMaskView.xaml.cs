using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MahAppsCore.Views.CustomView
{
    /// <summary>
    /// Interaction logic for BitMaskView.xaml
    /// </summary>
    public partial class BitMaskView : UserControl
    {
        public BitMaskView()
        {
            InitializeComponent();

            DataContext = this;

            ItemsSource = new List<BitMaskInfo>()
            {
                new BitMaskInfo() { Key="A", IsEnable = true },
                new BitMaskInfo() { Key="B", IsEnable = false },
            };
        }

        public IEnumerable ItemsSource
        {
            get => (IEnumerable)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(
            "ItemsSource",
            typeof(IEnumerable),
            typeof(BitMaskView),
            new PropertyMetadata(new PropertyChangedCallback(OnItemsSourcePropertyChanged)));

        private static void OnItemsSourcePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is BitMaskView control)
            {
                control.OnItemsSourceChanged((IEnumerable)e.OldValue, (IEnumerable)e.NewValue);
            }
        }

        private void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
        {
            // Remove handler for oldValue.CollectionChanged
            if (oldValue is INotifyCollectionChanged oldValueINotifyCollectionChanged)
            {
                oldValueINotifyCollectionChanged.CollectionChanged -= new NotifyCollectionChangedEventHandler(NewValueINotifyCollectionChanged_CollectionChanged);
            }

            // Add handler for newValue.CollectionChanged (if possible)
            if (newValue is INotifyCollectionChanged newValueINotifyCollectionChanged)
            {
                newValueINotifyCollectionChanged.CollectionChanged += new NotifyCollectionChangedEventHandler(NewValueINotifyCollectionChanged_CollectionChanged);
            }

        }

        private void NewValueINotifyCollectionChanged_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //Do your stuff here.
        }
    }
}
