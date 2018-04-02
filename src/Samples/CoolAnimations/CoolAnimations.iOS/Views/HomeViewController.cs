using System;
using CoolAnimations.Core.ViewModels;
using CoreGraphics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views.Gestures;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace CoolAnimations.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class HomeViewController : MvxViewController<HomeViewModel>, IStartAnimationViewController
    {
        public CGRect StartFrame { get; set; }

        public UIImage StartImage { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationController.SetNavigationBarHidden(true, false);

            SettingsButton.TouchUpInside += async (sender, e) =>
            {
                StartFrame = SettingsButton.Frame;
                await ViewModel.SettingsCommand.ExecuteAsync().ConfigureAwait(false);
            };

            ButtonReveal.TouchUpInside += async (sender, e) =>
            {
                StartFrame = ButtonReveal.Frame;
                await ViewModel.ButtonRevealCommand.ExecuteAsync().ConfigureAwait(false);
            };

            SecondButtonReveal.TouchUpInside += async (sender, e) => 
            {
                StartFrame = SecondButtonReveal.Frame;
                await ViewModel.SecondButtonRevealCommand.ExecuteAsync().ConfigureAwait(false);
            };

            IconImage.TouchUpInside  += async (sender, e) =>
            {
                StartFrame = IconImage.Frame;
                StartImage = IconImage.ImageView.Image;

                await ViewModel.ImageRevealCommand.ExecuteAsync().ConfigureAwait(false);
            };
        }


    }
}