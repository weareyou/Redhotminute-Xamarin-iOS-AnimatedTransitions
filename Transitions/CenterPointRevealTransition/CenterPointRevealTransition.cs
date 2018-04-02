namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions
{
	using CoreGraphics;
	using Redhotminute.Plugin.iOS.AnimatedTransitions.Helpers;
	using UIKit;

	public class CenterPointRevealTransition : BaseTransition
	{
		public CenterPointRevealTransition(float duration, bool isPresenting = true)
		{
			Duration = duration;
			IsPresenting = isPresenting;
		}

		public override void AnimateTransition(IUIViewControllerContextTransitioning transitionContext)
		{
			var containerView = transitionContext.ContainerView;
			var fromViewController = transitionContext.GetViewControllerForKey(UITransitionContext.FromViewControllerKey);
			var toViewController = transitionContext.GetViewControllerForKey(UITransitionContext.ToViewControllerKey);

			toViewController.View.Frame = fromViewController.View.Frame;

			if (IsPresenting)
			{
				var presentedControllerView = toViewController.View;
				var originalCenter = presentedControllerView.Center;
				var originalSize = presentedControllerView.Frame.Size;

				presentedControllerView.Center = AnimationHelper.GetCenterPointFromFrame(StartingFrame);
				presentedControllerView.Transform = CGAffineTransform.MakeScale(0.001f, 0.001f);
				containerView.AddSubview(presentedControllerView);

				UIView.Animate(Duration, 0, UIViewAnimationOptions.CurveEaseInOut,
				() =>
					{
						presentedControllerView.Transform = CGAffineTransform.MakeIdentity();
						presentedControllerView.Center = originalCenter;
					}, () =>
					{
						transitionContext.CompleteTransition(true);
					}
				);
			}
			else
			{
				var returningControllerView = fromViewController.View;
				var originalSize = returningControllerView.Frame.Size;

				containerView.AddSubview(toViewController.View);

				UIView.Animate(Duration, 0, UIViewAnimationOptions.CurveEaseInOut,
				() =>
					{
						returningControllerView.Transform = CGAffineTransform.MakeScale(0.001f, 0.001f);
						returningControllerView.Center = AnimationHelper.GetCenterPointFromFrame(StartingFrame);
						returningControllerView.Alpha = .5f;
						containerView.InsertSubview(returningControllerView, 1);
					}, () =>
					{
						returningControllerView.Center = AnimationHelper.GetCenterPointFromFrame(StartingFrame);
						returningControllerView.RemoveFromSuperview();

						transitionContext.CompleteTransition(true);
					}
				);
			}
		}
	}
}
