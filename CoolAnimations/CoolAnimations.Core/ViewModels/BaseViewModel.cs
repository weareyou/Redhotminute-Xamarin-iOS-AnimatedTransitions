using System;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace CoolAnimations.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        public BaseViewModel()
        {
            CloseCommand = new MvxAsyncCommand(DoCloseAsync);
        }

        [MvxInject]
        public IMvxNavigationService NavigationService { get; set; }

        public IMvxAsyncCommand CloseCommand { get; private set; }

        private async Task DoCloseAsync()
        {
            await NavigationService.Close(this).ConfigureAwait(false);
        }
    }
}
