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

        public IMvxAsyncCommand InfoCommand => new MvxAsyncCommand(GoToInfoAsync);

        public IMvxAsyncCommand SettingsCommand => new MvxAsyncCommand(GoToSettingsAsync);

        public IMvxAsyncCommand CenterPointRevealCommand => new MvxAsyncCommand(DoCenterPointRevealAsync);

        public IMvxAsyncCommand SecondButtonRevealCommand => new MvxAsyncCommand(DoSecondButtonRevealAsync);

        public IMvxAsyncCommand ImageRevealCommand => new MvxAsyncCommand(DoImageRevealAsync);

        public IMvxAsyncCommand LeftRightRevealCommand => new MvxAsyncCommand(DoThirdButtonRevealAsync);

        public IMvxAsyncCommand FadeInFadeOutCommand => new MvxAsyncCommand(DoFadeInFadeOutAsync);

        private async Task GoToInfoAsync()
            => await NavigationService.Navigate<InfoViewModel>().ConfigureAwait(false);

        private async Task GoToSettingsAsync() 
            => await NavigationService.Navigate<SettingsViewModel>().ConfigureAwait(false);

        private async Task DoCenterPointRevealAsync() 
            => await NavigationService.Navigate<CenterPointRevealViewModel>().ConfigureAwait(false);

        private async Task DoSecondButtonRevealAsync() 
            => await NavigationService.Navigate<CirculairRevealViewModel>().ConfigureAwait(false);

        private async Task DoImageRevealAsync() 
            => await NavigationService.Navigate<ImageRevealViewModel>().ConfigureAwait(false);

        private async Task DoThirdButtonRevealAsync()
            => await NavigationService.Navigate<LeftRightViewModel>().ConfigureAwait(false);

        private async Task DoFadeInFadeOutAsync()
            => await NavigationService.Navigate<FadeInFadeOutViewModel>().ConfigureAwait(false);

    }
}
