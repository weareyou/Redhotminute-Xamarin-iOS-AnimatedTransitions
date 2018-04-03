using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class CirculairRevealTransitioningDelegate : StartFrameTransitioningDelegate<CirculairRevealTransition>
	{
        public CirculairRevealTransitioningDelegate(float duration, UIColor targetBackgroundColor) : base(new CirculairRevealTransition(duration, targetBackgroundColor, true))
		{
		}
	}
}