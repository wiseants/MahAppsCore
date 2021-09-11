using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MahAppsCore
{
    public class BitMaskInfo : BindableBase
    {
        private string _key;
        private double _value;
        private bool _isEnable;

        public string Key
        {
            get => _key;
            set => _ = SetProperty(ref _key, value);
        }

        public double Value
        {
            get => _value;
            set => _ = SetProperty(ref _value, value);
        }

        public bool IsEnable
        {
            get => _isEnable;
            set => _ = SetProperty(ref _isEnable, value);
        }
    }
}
