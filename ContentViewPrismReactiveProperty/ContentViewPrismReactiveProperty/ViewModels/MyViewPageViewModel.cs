using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContentViewPrismReactiveProperty.ViewModels
{
    public class MyViewPageViewModel : BindableBase
    {
        public ReactiveCommand Button1 { get; private set; } = new ReactiveCommand();
        public ReactiveCommand Button2 { get; private set; } = new ReactiveCommand();
        public ReactiveCommand Button3 { get; private set; } = new ReactiveCommand();
        public ReactiveProperty<string> Text { get; set; } = new ReactiveProperty<string>("Hello!ContentView!");
        public MyViewPageViewModel()
        {
            Button1.Subscribe(_ => Text.Value = "1");
            Button2.Subscribe(_ => Text.Value = "2");
            Button3.Subscribe(_ => Text.Value = "3");
        }
    }
}
