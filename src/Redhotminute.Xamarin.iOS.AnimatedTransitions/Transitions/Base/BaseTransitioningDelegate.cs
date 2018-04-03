using Redhotminute.Xamarin.iOS.AnimatedTransitions.Helpers;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public abstract class BaseTransitioningDelegate<T> : UIViewControllerTransitioningDelegate where T : BaseTransition
    {
        protected T TransitionAnimator;

        public BaseTransitioningDelegate(T transition)
        {
            TransitionAnimator = transition;
        }

        public override IUIViewControllerAnimatedTransitioning GetAnimationControllerForPresentedController(UIViewController presented, UIViewController presenting, UIViewController source)
        {
            var controller = TransitionHelper.GetStartAnimationViewController(source);

            if (controller != null)
                return TransitionAnimator;
            
            return null;
        }

        public override IUIViewControllerAnimatedTransitioning GetAnimationControllerForDismissedController(UIViewController dismissed)
        {
            if (TransitionAnimator != null)
            {
                TransitionAnimator.IsPresenting = false;
                return TransitionAnimator;
            }

            return null;
        }
    }
}
