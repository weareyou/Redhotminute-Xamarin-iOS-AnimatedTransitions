using System;
using CoreGraphics;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class SquareButtonRevealTransitioningDelegate : BaseStartingFrameTransitioningDelegate<SquareButtonRevealTransition>
	{
        public SquareButtonRevealTransitioningDelegate(float duration, UIColor targetBackgroundColor) : base(new SquareButtonRevealTransition(duration, targetBackgroundColor, true))
		{
		}
	}
}
