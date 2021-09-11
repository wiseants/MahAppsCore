using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;

namespace MahAppsCore.Views.CustomView
{
    /// <summary>
    /// Interaction logic for BitMaskView.xaml
    /// </summary>
    public partial class BitMaskView : UserControl
    {
        #region Fields

        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(
            "ItemsSource",
            typeof(IEnumerable<BitMaskInfo>),
            typeof(BitMaskView),
            new PropertyMetadata(null, new PropertyChangedCallback(OnItemsSourcePropertyChanged)));

        #endregion

        #region Constructors

        public BitMaskView()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public IEnumerable<BitMaskInfo> ItemsSource
        {
            get => (IEnumerable<BitMaskInfo>)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        #endregion

        #region Event handlers

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

        #endregion
    }
}
