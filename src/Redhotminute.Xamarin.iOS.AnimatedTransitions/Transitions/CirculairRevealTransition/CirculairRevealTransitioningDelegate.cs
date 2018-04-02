using System;
using CoreGraphics;
using Foundation;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class CirculairRevealTransitioningDelegate : BaseStartingFrameTransitioningDelegate<CirculairRevealTransition>
	{
        public CirculairRevealTransitioningDelegate(float duration, UIColor targetBackgroundColor) : base(new CirculairRevealTransition(duration, targetBackgroundColor, true))
		{
		}
	}
}
