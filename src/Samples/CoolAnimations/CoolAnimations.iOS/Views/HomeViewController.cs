using System;
using CoolAnimations.Core.ViewModels;
using CoreGraphics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views.Gestures;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Helpers;
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

            var bindingSet = this.CreateBindingSet<HomeViewController, HomeViewModel>();
            bindingSet.Bind(FadeInFadeOutButton.Tap()).For(v => v.Command).To(vm => vm.FadeInFadeOutCommand);
            bindingSet.Apply();

            SettingsButton.TouchUpInside += async (sender, e) =>
            {
                StartFrame = AnimationHelper.GetFrameFromViewInScrollView(ScrollView, SettingsButton.Frame);
                await ViewModel.SettingsCommand.ExecuteAsync().ConfigureAwait(false);
            };

            InfoButton.TouchUpInside += async (sender, e) =>
            {
                StartFrame = AnimationHelper.GetFrameFromViewInScrollView(ScrollView, InfoButton.Frame);
                await ViewModel.InfoCommand.ExecuteAsync().ConfigureAwait(false);
            };

            ButtonReveal.TouchUpInside += async (sender, e) =>
            {
                StartFrame = AnimationHelper.GetFrameFromViewInScrollView(ScrollView, ButtonReveal.Frame);
                await ViewModel.CenterPointRevealCommand.ExecuteAsync().ConfigureAwait(false);
            };

            SecondButtonReveal.TouchUpInside += async (sender, e) => 
            {
                StartFrame = AnimationHelper.GetFrameFromViewInScrollView(ScrollView, SecondButtonReveal.Frame);
                await ViewModel.SecondButtonRevealCommand.ExecuteAsync().ConfigureAwait(false);
            };

            IconImage.TouchUpInside  += async (sender, e) =>
            {
                StartFrame = AnimationHelper.GetFrameFromViewInScrollView(ScrollView, IconImage.Frame);
                StartImage = IconImage.ImageView.Image;

                await ViewModel.ImageRevealCommand.ExecuteAsync().ConfigureAwait(false);
            };

            ThirdButton.TouchUpInside += async (sender, e) =>
            {
                //StartFrame = AnimationHelper.GetFrameFromViewInScrollView(ScrollView, SecondButtonReveal.Frame);
                await ViewModel.LeftRightRevealCommand.ExecuteAsync().ConfigureAwait(false);
            };
        }
    }
}