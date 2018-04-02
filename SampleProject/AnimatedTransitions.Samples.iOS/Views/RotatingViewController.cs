using System;
using AnimatedTransitions.Samples.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using UIKit;

namespace AnimatedTransitions.Samples.iOS.Views
{
    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.FullScreen, ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve)]
    public partial class RotatingViewController : MvxViewController<RotatingViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //TransitioningDelegate = new CenterPointRevealTransitioningDelegate(Settings.TransitionSpeed);
        }

    }
}

