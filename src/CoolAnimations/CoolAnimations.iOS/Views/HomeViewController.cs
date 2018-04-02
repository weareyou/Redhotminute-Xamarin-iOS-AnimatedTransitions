using System;
using CoolAnimations.Core.ViewModels;
using CoreGraphics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views.Gestures;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Helpers;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace CoolAnimations.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class HomeViewController : MvxViewController<HomeViewModel>, IStartAnimationViewController
    {
        public CGRect StartingFrame { get; set; }

        public UIImage SelectedImage { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationController.SetNavigationBarHidden(true, false);

            ButtonReveal.TouchUpInside += async (sender, e) =>
            {
                StartingFrame = ButtonReveal.Frame;
                await ViewModel.ButtonRevealCommand.ExecuteAsync().ConfigureAwait(false);
            };

            SecondButtonReveal.TouchUpInside += async (sender, e) => 
            {
                StartingFrame = SecondButtonReveal.Frame;
                await ViewModel.SecondButtonRevealCommand.ExecuteAsync().ConfigureAwait(false);
            };

            IconImage.TouchUpInside  += async (sender, e) =>
            {
                StartingFrame = IconImage.Frame;
                SelectedImage = IconImage.ImageView.Image;

                await ViewModel.ImageRevealCommand.ExecuteAsync().ConfigureAwait(false);
            };

        }
    }
}