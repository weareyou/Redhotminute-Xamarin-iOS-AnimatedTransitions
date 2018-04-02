namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    using CoreGraphics;
    using Redhotminute.Xamarin.iOS.AnimatedTransitions.Helpers;
    using UIKit;

    public class FadeInOutTransition : BaseTransition
    {
        public FadeInOutTransition(float duration, bool isPresenting = true)
        {
            Duration = duration;
            IsPresenting = isPresenting;
        }

        public override void AnimateTransition(IUIViewControllerContextTransitioning transitionContext)
        {
            var containerView = transitionContext.ContainerView;
            var fromViewController = transitionContext.GetViewControllerForKey(UITransitionContext.FromViewControllerKey);
            var toViewController = transitionContext.GetViewControllerForKey(UITransitionContext.ToViewControllerKey);

            toViewController.View.Alpha = 0f;

            containerView.AddSubview(toViewController.View);

            UIView.Animate(Duration, 0, UIViewAnimationOptions.CurveEaseInOut,
              () =>
                  {
                      toViewController.View.Alpha = 1f;
                  }, () =>
                  {
                      transitionContext.CompleteTransition(true);
                  }
              );
        }
    }
}
