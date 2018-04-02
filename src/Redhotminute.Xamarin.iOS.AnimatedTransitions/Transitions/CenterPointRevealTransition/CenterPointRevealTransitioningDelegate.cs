namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    using System;
    using CoreGraphics;
    using Foundation;
    using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
    using UIKit;

    public class CenterPointRevealTransitioningDelegate : BaseStartingFrameTransitioningDelegate<CenterPointRevealTransition>
    {
        public CenterPointRevealTransitioningDelegate(float duration) : base(new CenterPointRevealTransition(duration, true))
        {
        }
    }
}
