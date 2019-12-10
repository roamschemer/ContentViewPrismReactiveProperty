using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContentViewPrismReactiveProperty.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ReactiveProperty<string> Text { get; set; } = new ReactiveProperty<string>();
        public ReactiveCommand Button { get; } = new ReactiveCommand();
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Button.Subscribe(_ => Text.Value = "夏狂乱");
        }
    }
}
