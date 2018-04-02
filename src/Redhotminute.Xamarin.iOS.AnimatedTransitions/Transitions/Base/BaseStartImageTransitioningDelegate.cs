﻿using System;
using CoreGraphics;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class BaseStartImageTransitioningDelegate<T> : BaseTransitioningDelegate<T> where T : BaseTransition
    {
        public BaseStartImageTransitioningDelegate(T transition) : base(transition)
        {
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
                    throw new Exception($"{nameof(controller.StartFrame)} is required for this type of transition");

                TransitionAnimator.StartingFrame = startingFrame;

                var selectedImage = controller.StartImage;
                if (selectedImage == null)
                    throw new Exception($"{nameof(controller.StartImage)} is required for this type of transition");
                    
                TransitionAnimator.SelectedImage = selectedImage;

                return TransitionAnimator;
            }

            return null;
        }
    }
}