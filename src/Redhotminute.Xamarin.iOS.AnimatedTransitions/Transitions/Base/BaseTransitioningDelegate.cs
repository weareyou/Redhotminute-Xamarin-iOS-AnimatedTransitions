using System;
using CoreGraphics;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
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
            IStartAnimationViewController controller = null;

            if (source is UINavigationController)
            {
                controller = ((UINavigationController)source).TopViewController as IStartAnimationViewController;
            }
            else if (source is UIViewController)
            {
                controller = source as IStartAnimationViewController;
            }

            if (controller != null)
            {
                var startingFrame = controller.StartFrame;
                if (startingFrame == CGRect.Empty)
                    throw new Exception("Starting frame is expected for this type of transition");
                
                TransitionAnimator.StartingFrame = startingFrame;

                var selectedImage = controller.StartImage;
                if (selectedImage != null)
                    TransitionAnimator.SelectedImage = selectedImage;
                    
                return TransitionAnimator;
            }

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
