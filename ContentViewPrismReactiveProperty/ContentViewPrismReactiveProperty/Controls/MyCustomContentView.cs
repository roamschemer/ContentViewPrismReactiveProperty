using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ContentViewPrismReactiveProperty.Controls
{
    public class MyCustomContentView : ContentView
    {
        public static readonly BindableProperty ValueProperty = BindableProperty.Create(
                                                                "TextValue",
                                                                typeof(string),
                                                                typeof(MyCustomContentView),
                                                                "初期値",
                                                                propertyChanged: (bindable, oldValue, newValue) =>
                                                                {
                                                                    ((MyCustomContentView)bindable).TextValue = newValue;
                                                                },
                                                                defaultBindingMode: BindingMode.TwoWay);
        public object TextValue
        {
            get => GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

    }
}
