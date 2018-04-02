namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions
{
	using System;
	using System.Collections.Generic;
	using CoreGraphics;
	using Foundation;
	using Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces;
	using UIKit;

    public class LeftRightInOuttTransitioningDelegate : BaseTransitioningDelegate<LeftRightInOutTransition>
	{
        public LeftRightInOuttTransitioningDelegate(float duration) : base(new LeftRightInOutTransition(duration, true))
		{
		}
	}
}
