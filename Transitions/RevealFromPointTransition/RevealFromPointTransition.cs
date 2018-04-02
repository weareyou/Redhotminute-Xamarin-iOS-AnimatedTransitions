using System;
using CoreGraphics;
using UIKit;

namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions
{
    public class RevealFromPointTransition : BaseTransition
    {
        public RevealFromPointTransition(float duration, bool isPresenting = true)
        {
            Duration = duration;
            IsPresenting = isPresenting;
        }

        public override void AnimateTransition(IUIViewControllerContextTransitioning transitionContext)
        {
            var containerView = transitionContext.ContainerView;
            var fromView = transitionContext.GetViewFor(UITransitionContext.FromViewKey);
            var toView = transitionContext.GetViewFor(UITransitionContext.ToViewKey);

            var detailView = IsPresenting ? toView : fromView;

            detailView.Frame = new CGRect(0, 0, fromView.Bounds.Width, fromView.Bounds.Height);

            var initialFrame = IsPresenting ? StartingFrame : detailView.Frame;
            var finalFrame = IsPresenting ? detailView.Frame : StartingFrame;

            var xScaleFactor = IsPresenting ? initialFrame.Width / finalFrame.Width : finalFrame.Width / initialFrame.Width;
            var yScaleFactor = IsPresenting ? initialFrame.Height / finalFrame.Height : finalFrame.Height / initialFrame.Height;

            var scaleTransform = CGAffineTransform.MakeScale(xScaleFactor, yScaleFactor);

            if (IsPresenting)
            {
                detailView.Transform = scaleTransform;
                detailView.Center = new CGPoint(initialFrame.GetMidX(), initialFrame.GetMidY());
                detailView.ClipsToBounds = true;
            }

            containerView.AddSubview(toView);
            containerView.BringSubviewToFront(detailView);

            UIView.Animate(Duration, 0, UIViewAnimationOptions.CurveEaseInOut,
            () =>
            {
                detailView.Transform = IsPresenting ? CGAffineTransform.MakeIdentity() : scaleTransform;
                detailView.Center = new CGPoint(finalFrame.GetMidX(), finalFrame.GetMidY());

                if (!IsPresenting)
                {
                    fromView.Alpha = 0f;
                }
            },
                           () =>
                           {

                                if (!IsPresenting)
                               {
                                   fromView.RemoveFromSuperview();
                               }
                               transitionContext.CompleteTransition(true);

                           }
            );

        }
    }
}
