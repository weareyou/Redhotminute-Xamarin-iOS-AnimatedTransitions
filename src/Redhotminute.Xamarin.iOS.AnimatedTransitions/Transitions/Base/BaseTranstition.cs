using CoreGraphics;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
	public abstract class BaseTransition : UIViewControllerAnimatedTransitioning
	{
		public float Duration { get; set; }

		public bool IsPresenting { get; set; }

		public CGRect StartingFrame { get; set; }

        public UIImage SelectedImage { get; set; }

		public abstract override void AnimateTransition(IUIViewControllerContextTransitioning transitionContext);

		public override double TransitionDuration(IUIViewControllerContextTransitioning transitionContext) { return Duration; }
	}
}