using CoreAnimation;
using CoreGraphics;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Helpers
{
    public static class AnimationHelper
	{
		public static CGPoint GetCenterPointFromFrame(CGRect rect)
		{
			return new CGPoint(rect.GetMidX(), rect.GetMidY());
		}

        public static CATransform3D YRotation(float angle)
        {
            return CATransform3D.MakeRotation(angle, 0, 1, 0);
        }

        public static CATransform3D PerspectiveTransform()
        {
            var transform = CATransform3D.Identity;
            transform.m34 = -0.002f;
            return transform;
        }

        public static void PerspectiveTransform(UIView view)
        {
            var transform = CATransform3D.Identity;
            transform.m34 = -0.002f;

            view.Layer.SublayerTransform = transform;
        }
	}
}
