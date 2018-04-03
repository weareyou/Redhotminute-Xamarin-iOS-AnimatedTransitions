using System;
using System.Linq;
using CoreGraphics;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Helpers;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
	public class SquareRevealTransition : BaseTransition
	{
		private UIView _square;

		public UIColor BubbleColor { get; set; } = UIColor.White;

		public SquareRevealTransition(float duration, UIColor color, bool isPresenting = true)
		{
			Duration = duration;
			IsPresenting = isPresenting;

			BubbleColor = color;

			_square = new UIView();
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

				_square.Frame = StartingFrame;
				_square.Center = AnimationHelper.GetCenterPointFromFrame(StartingFrame);
				_square.Transform = CGAffineTransform.MakeScale(0.001f, 0.001f);
                _square.BackgroundColor = BubbleColor;

				containerView.AddSubview(_square);

				presentedControllerView.Center = AnimationHelper.GetCenterPointFromFrame(StartingFrame);
				presentedControllerView.Transform = CGAffineTransform.MakeScale(0.001f, 0.001f);
				presentedControllerView.Alpha = 0f;

				containerView.AddSubview(toViewController.View);

				UIView.Animate(Duration, 0, UIViewAnimationOptions.CurveEaseOut,
				() =>
					{
						_square.Transform = CGAffineTransform.MakeIdentity();
						presentedControllerView.Transform = CGAffineTransform.MakeIdentity();
						presentedControllerView.Alpha = 1f;
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

				_square.Frame = CreateFrameForBubble(originalSize, AnimationHelper.GetCenterPointFromFrame(StartingFrame));
				_square.Center = AnimationHelper.GetCenterPointFromFrame(StartingFrame);

				containerView.AddSubview(toViewController.View);
				containerView.AddSubview(_square);

				UIView.Animate(Duration, 0, UIViewAnimationOptions.CurveEaseInOut,
				() =>
					{
						_square.Transform = CGAffineTransform.MakeScale(0.001f, 0.001f);

						returningControllerView.Transform = CGAffineTransform.MakeScale(0.001f, 0.001f);
						returningControllerView.Center = AnimationHelper.GetCenterPointFromFrame(StartingFrame);
						returningControllerView.Alpha = 0f;
					}, () =>
					{
						returningControllerView.Center = AnimationHelper.GetCenterPointFromFrame(StartingFrame);
						_square.RemoveFromSuperview();

						transitionContext.CompleteTransition(true);
					}
				);
			}
		}

		private CGRect CreateFrameForBubble(CGSize originalSize, CGPoint start)
		{
			var lengthX = Math.Max(start.X, originalSize.Width - start.X);
			var lengthY = Math.Max(start.Y, originalSize.Height - start.Y);

			var offset = Math.Sqrt(lengthX * lengthX + lengthY * lengthY) * 2;

			var size = new CGSize(width: offset, height: offset);

			return new CGRect(CGPoint.Empty, size: size);
		}
	}
}
