using System;
using CoolAnimations.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views.Gestures;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions;
using UIKit;

namespace CoolAnimations.iOS.Views
{
    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.FullScreen,
                          ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve)]
    public partial class ImageRevealViewController : MvxViewController<ImageRevealViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TargetImage.Tag = 99;

            //TransitioningDelegate = new RevealFromPointTransitioningDelegate(.3f);
            TransitioningDelegate = new ImageRevealTransitioningDelegate(.25f);

            var bindingSet = this.CreateBindingSet<ImageRevealViewController, ImageRevealViewModel>();
            bindingSet.Bind(CloseButton.Tap()).For(v => v.Command).To(vm => vm.CloseCommand);
            bindingSet.Apply();
        }
    }
}

