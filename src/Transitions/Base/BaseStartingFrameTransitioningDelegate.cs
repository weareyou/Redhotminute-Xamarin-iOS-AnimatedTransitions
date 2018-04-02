using System;
using CoreGraphics;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions
{
    public class BaseStartingFrameTransitioningDelegate<T> : BaseTransitioningDelegate<T> where T : BaseTransition
    {
        public BaseStartingFrameTransitioningDelegate(T transition) : base(transition)
        {
        }

        public override IUIViewControllerAnimatedTransitioning GetAnimationControllerForPresentedController(UIViewController presented, UIViewController presenting, UIViewController source)
        {
            IStartAnimationViewController controller = null;

            if(source is UINavigationController)
            {
                controller = ((UINavigationController)source).TopViewController as IStartAnimationViewController;
            } 
            else if (source is UIViewController)
            {
                controller = source as IStartAnimationViewController;
            }

            if (controller != null)
            {
                var startingFrame = controller.StartingFrame;
                if (startingFrame == CGRect.Empty)
                    throw new Exception("Starting frame is expected for this type of transition");

                TransitionAnimator.StartingFrame = startingFrame;

                return TransitionAnimator;
            } 

            return null;
        }
    }
}
