using System;
using CoreGraphics;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions;
using UIKit;

namespace CustomTransitionsSample.ViewControllers
{
    public partial class StartViewController : UIViewController, IStartAnimationViewController
    {
        private CGRect _startingFrame;
        public CGRect StartingFrame
        {
            set { this._startingFrame = value; }
            get { return this._startingFrame; }
        }

        public StartViewController() : base("StartViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            AnimationButton1.TouchDown += (sender, e) =>
            {
                var toVC = new CenterPointViewController();
                toVC.ModalPresentationStyle = UIModalPresentationStyle.FullScreen;
                toVC.TransitioningDelegate = new CenterPointRevealTransitioningDelegate(Helpers.Settings.TransitionSpeed);

                StartingFrame = AnimationButton1.Frame;
                //this.NavigationController.PushViewController(toVC, true);
                this.PresentViewController(toVC, true, null);
            };
        }
    }
}

