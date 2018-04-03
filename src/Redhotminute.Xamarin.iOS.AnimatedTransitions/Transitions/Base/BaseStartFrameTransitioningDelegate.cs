using System;
using CoreGraphics;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Helpers;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class BaseStartFrameTransitioningDelegate<T> : BaseTransitioningDelegate<T> where T : BaseTransition
    {
        public BaseStartFrameTransitioningDelegate(T transition) : base(transition)
        {
        }

        public override IUIViewControllerAnimatedTransitioning GetAnimationControllerForPresentedController(UIViewController presented, UIViewController presenting, UIViewController source)
        {
            var controller = TransitionHelper.GetStartAnimationViewController(source);

            if (controller != null)
            {
                var startingFrame = controller.StartFrame;
                if (startingFrame == CGRect.Empty)
                    throw new Exception("Starting frame is expected for this type of transition");

                TransitionAnimator.StartingFrame = startingFrame;

                return TransitionAnimator;
            } 

            return null;
        }
    }
}
