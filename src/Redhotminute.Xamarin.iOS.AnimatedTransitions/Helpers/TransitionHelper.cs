using System;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Helpers
{
    public static class TransitionHelper
    {
        public static IStartAnimationViewController GetStartAnimationViewController(UIViewController source)
        {
            if (source is UINavigationController)
            {
                return ((UINavigationController)source).TopViewController as IStartAnimationViewController;
            }
            else if (source is UIViewController)
            {
                return source as IStartAnimationViewController;
            }

            return null;
        }
    }
}
