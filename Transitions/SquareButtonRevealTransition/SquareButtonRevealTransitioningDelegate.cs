using System;
using CoreGraphics;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions
{
    public class SquareButtonRevealTransitioningDelegate : BaseStartingFrameTransitioningDelegate<SquareButtonRevealTransition>
	{
        public SquareButtonRevealTransitioningDelegate(float duration, UIColor targetBackgroundColor) : base(new SquareButtonRevealTransition(duration, targetBackgroundColor, true))
		{
		}
	}
}
