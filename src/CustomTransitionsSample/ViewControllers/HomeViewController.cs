using System;
using CoreGraphics;
using CustomTransitionsSample.ViewControllers;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions;
using UIKit;

namespace CustomTransitionsSample
{
    public partial class HomeViewController : UIViewController, IStartAnimationViewController
    {
        private CGRect _startingFrame;
        public CGRect StartingFrame
        {
            set { this._startingFrame = value; }
            get { return this._startingFrame; }
        }

        public HomeViewController() : base("HomeViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CircularRevealButton.Layer.CornerRadius = CircularRevealButton.Frame.Size.Height / 2;                                

            TransitionSpeedLabel.Text = $"Transition speed: {TransitionSpeedSlider.Value}";

            TransitionSpeedSlider.ValueChanged += (sender, e) => 
            {
                Helpers.Settings.TransitionSpeed = TransitionSpeedSlider.Value;
                TransitionSpeedLabel.Text = $"Transition speed: {TransitionSpeedSlider.Value}";
            };

            CircularRevealButton.TouchUpInside += (sender, e) => 
            {
                var toVC = new CircleButtonViewController();
                toVC.ModalPresentationStyle = UIModalPresentationStyle.FullScreen;
                toVC.TransitioningDelegate = new CircleButtonRevealTransitioningDelegate(Helpers.Settings.TransitionSpeed, UIColor.Purple);

                StartingFrame = CircularRevealButton.Frame;
                this.PresentViewController(toVC, true, null);
            };

            //ButtonTransitionButton.TouchUpInside += (sender, e) => 
            //{
            //    this.NavigationController.PushViewController(new SquareButtonViewController(), true);
            //};

            CenterPointButton.TouchUpInside += (sender, e) => 
            {
                var toVC = new CenterPointViewController();
                toVC.ModalPresentationStyle = UIModalPresentationStyle.FullScreen;
                toVC.TransitioningDelegate = new CenterPointRevealTransitioningDelegate(Helpers.Settings.TransitionSpeed);

                StartingFrame = CenterPointButton.Frame;
                //this.NavigationController.PushViewController(toVC, true);
                this.PresentViewController(toVC, true, null);
            };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

