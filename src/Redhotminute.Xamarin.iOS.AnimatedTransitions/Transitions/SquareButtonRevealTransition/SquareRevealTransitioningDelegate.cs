using System;
using CoreGraphics;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class SquareRevealTransitioningDelegate : BaseStartFrameTransitioningDelegate<SquareRevealTransition>
	{
        public SquareRevealTransitioningDelegate(float duration, UIColor targetBackgroundColor) : base(new SquareRevealTransition(duration, targetBackgroundColor, true))
		{
		}
	}
}
