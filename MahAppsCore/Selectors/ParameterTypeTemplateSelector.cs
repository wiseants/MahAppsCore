// https://stackoverflow.com/questions/24916726/change-view-with-its-viewmodel-based-on-a-viewmodel-property/24918915#24918915

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace MahAppsCore.Selectors
{
    public class ParameterTypeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SliderViewTemplate
        {
            get;
            set;
        }

        public DataTemplate BitMaskViewTemplate
        {
            get;
            set;
        }

        public override DataTemplate SelectTemplate(object selector, DependencyObject container)
        {
            // selector 타입 확인해서 템플릿 선택.
            return SliderViewTemplate;
        }
    }
}
