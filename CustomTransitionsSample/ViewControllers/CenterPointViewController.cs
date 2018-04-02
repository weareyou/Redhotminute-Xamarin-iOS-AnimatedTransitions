using System;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions;
using UIKit;

namespace CustomTransitionsSample.ViewControllers
{
    public partial class CenterPointViewController : UIViewController
    {
        public CenterPointViewController() : base("CenterPointViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CloseButton.TouchUpInside += (sender, e) => {
                this.DismissViewController(true, null);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

