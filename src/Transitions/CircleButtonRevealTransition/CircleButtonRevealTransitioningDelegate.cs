using System;
using CoreGraphics;
using Foundation;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions
{
    public class CircleButtonRevealTransitioningDelegate : BaseStartingFrameTransitioningDelegate<CircleButtonRevealTransition>
	{
        public CircleButtonRevealTransitioningDelegate(float duration, UIColor targetBackgroundColor) : base(new CircleButtonRevealTransition(duration, targetBackgroundColor, true))
		{
		}
	}
}
