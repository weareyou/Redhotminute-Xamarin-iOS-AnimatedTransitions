using System;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace CoolAnimations.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            ButtonRevealCommand = new MvxAsyncCommand(DoButtonRevealAsync);

            SecondButtonRevealCommand = new MvxAsyncCommand(DoSecondButtonRevealAsync);

            ImageRevealCommand = new MvxAsyncCommand(DoImageRevealAsync);
        }

        public MvxAsyncCommand ButtonRevealCommand { get; private set; }

        public MvxAsyncCommand SecondButtonRevealCommand { get; private set; }

        public MvxAsyncCommand ImageRevealCommand { get; private set; }

        private async Task DoButtonRevealAsync() 
            => await NavigationService.Navigate<ButtonRevealViewModel>().ConfigureAwait(false);

        private async Task DoSecondButtonRevealAsync() 
            => await NavigationService.Navigate<SecondButtonRevealViewModel>().ConfigureAwait(false);

        private async Task DoImageRevealAsync() 
            => await NavigationService.Navigate<ImageRevealViewModel>().ConfigureAwait(false);
    }
}
