using System;
using CoolAnimations.Core.ViewModels;
using CoreGraphics;
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
    public partial class ButtonRevealViewController : MvxViewController<ButtonRevealViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TransitioningDelegate = new SquareButtonRevealTransitioningDelegate(1f, UIColor.White);

            var bindingSet = this.CreateBindingSet<ButtonRevealViewController, ButtonRevealViewModel>();
            bindingSet.Bind(CloseButton.Tap()).For(v => v.Command).To(vm => vm.CloseCommand);

            bindingSet.Apply();
        }
    }


}