using CoreGraphics;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class FadeInFadeOutTransition : BaseTransition
    {
        public FadeInFadeOutTransition(float duration, bool isPresenting = true)
        {
            Duration = duration;
            IsPresenting = isPresenting;
        }

        public override void AnimateTransition(IUIViewControllerContextTransitioning transitionContext)
        {
            var containerView = transitionContext.ContainerView;
            var fromView = transitionContext.GetViewFor(UITransitionContext.FromViewKey);
            var toView = transitionContext.GetViewFor(UITransitionContext.ToViewKey);

            if (IsPresenting)
                containerView.AddSubview(toView);
            else
                containerView.InsertSubviewBelow(toView, fromView);

            var detailView = IsPresenting ? toView : fromView;
            detailView.Frame = new CGRect(0, 0, fromView.Bounds.Width, fromView.Bounds.Height);
            detailView.Alpha = IsPresenting ? 0 : 1;

            UIView.Animate(Duration, 0, UIViewAnimationOptions.CurveEaseInOut,
            () =>
            {
                detailView.Alpha = IsPresenting ? 1 : 0;
            },
            () =>
            {
                transitionContext.CompleteTransition(true);
            });
        }
    }
}
