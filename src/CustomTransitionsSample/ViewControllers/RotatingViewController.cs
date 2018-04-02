using System;

using UIKit;

namespace CustomTransitionsSample.ViewControllers
{
    public partial class RotatingViewController : UIViewController
    {
        public RotatingViewController() : base("RotatingViewController", null)
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

