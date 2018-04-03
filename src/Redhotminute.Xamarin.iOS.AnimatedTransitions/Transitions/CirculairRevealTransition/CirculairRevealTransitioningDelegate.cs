using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class CirculairRevealTransitioningDelegate : BaseStartFrameTransitioningDelegate<CirculairRevealTransition>
	{
        public CirculairRevealTransitioningDelegate(float duration, UIColor targetBackgroundColor) : base(new CirculairRevealTransition(duration, targetBackgroundColor, true))
		{
		}
	}
}