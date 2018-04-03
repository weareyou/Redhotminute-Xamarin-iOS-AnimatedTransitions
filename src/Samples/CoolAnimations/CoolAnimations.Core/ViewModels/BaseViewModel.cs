using System;
using System.Threading.Tasks;
using CoolAnimations.Core.Helpers;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace CoolAnimations.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        public BaseViewModel()
        {
        }

        [MvxInject]
        public IMvxNavigationService NavigationService { get; set; }

        public IMvxAsyncCommand CloseCommand 
            => new MvxAsyncCommand(DoCloseAsync);

        public float Duration => Settings.Duration;

        private async Task DoCloseAsync()
            => await NavigationService.Close(this).ConfigureAwait(false);
    }
}
