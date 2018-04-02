namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
	using System;
	using System.Collections.Generic;
	using CoreGraphics;
	using Foundation;
	using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
	using UIKit;

    public class LeftRightInOuttTransitioningDelegate : BaseTransitioningDelegate<LeftRightInOutTransition>
	{
        public LeftRightInOuttTransitioningDelegate(float duration) : base(new LeftRightInOutTransition(duration, true))
		{
		}
	}
}
