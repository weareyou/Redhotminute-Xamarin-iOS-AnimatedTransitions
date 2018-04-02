using System;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace CoolAnimations.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
        }

        public IMvxAsyncCommand SettingsCommand => new MvxAsyncCommand(GoToSettingsAsync);

        public IMvxAsyncCommand ButtonRevealCommand => new MvxAsyncCommand(DoButtonRevealAsync);

        public IMvxAsyncCommand SecondButtonRevealCommand => new MvxAsyncCommand(DoSecondButtonRevealAsync);

        public IMvxAsyncCommand ImageRevealCommand => new MvxAsyncCommand(DoImageRevealAsync);

        private async Task GoToSettingsAsync() 
            => await NavigationService.Navigate<SettingsViewModel>().ConfigureAwait(false);

        private async Task DoButtonRevealAsync() 
            => await NavigationService.Navigate<ButtonRevealViewModel>().ConfigureAwait(false);

        private async Task DoSecondButtonRevealAsync() 
            => await NavigationService.Navigate<SecondButtonRevealViewModel>().ConfigureAwait(false);

        private async Task DoImageRevealAsync() 
            => await NavigationService.Navigate<ImageRevealViewModel>().ConfigureAwait(false);
    }
}
