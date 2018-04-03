using System;
using System.Linq;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class LeftRightInOutTransitioningDelegate<T> : BaseTransitioningDelegate<T> where T : BaseTransition
    {
        public LeftRightInOutTransitioningDelegate(T transition) : base(transition)
        {
        }

        public override IUIViewControllerAnimatedTransitioning GetAnimationControllerForPresentedController(UIViewController presented, UIViewController presenting, UIViewController source)
        {
            if (presented is ILeftRightRevealViewController)
            {
                var controller = presented as ILeftRightRevealViewController;
                if (controller.LeftViews == null || !controller.LeftViews.Any() || controller.RightViews == null || !controller.RightViews.Any()) 
                    throw new Exception($"Left and right views are required for this type of transition");

                return TransitionAnimator;
            }

            return null;
        }
    }
}
