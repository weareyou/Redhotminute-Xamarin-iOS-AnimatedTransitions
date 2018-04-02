using System;
using CoreGraphics;
using Foundation;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class CircleButtonRevealTransitioningDelegate : BaseStartingFrameTransitioningDelegate<CircleButtonRevealTransition>
	{
        public CircleButtonRevealTransitioningDelegate(float duration, UIColor targetBackgroundColor) : base(new CircleButtonRevealTransition(duration, targetBackgroundColor, true))
		{
		}
	}
}
