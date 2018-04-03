using System;
using System.Collections.Generic;
using CoolAnimations.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views.Gestures;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions;
using UIKit;

namespace CoolAnimations.iOS.Views
{
    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.FullScreen,
                          ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve)]
    public partial class LeftRightViewController : MvxViewController<LeftRightViewModel>, ILeftRightRevealViewController
    {
        public List<UIView> LeftViews => new List<UIView> { LeftImage1, LeftImage2, LeftImage3 };

        public List<UIView> RightViews => new List<UIView> { CloseButton, RightImage1, RightImage2, RightImage3 };

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TransitioningDelegate = new LeftRightInOutTransitioningDelegate(ViewModel.Duration);

            var bindingSet = this.CreateBindingSet<LeftRightViewController, LeftRightViewModel>();
            bindingSet.Bind(CloseButton.Tap()).For(v => v.Command).To(vm => vm.CloseCommand);
            bindingSet.Apply();
        }
    }
}

