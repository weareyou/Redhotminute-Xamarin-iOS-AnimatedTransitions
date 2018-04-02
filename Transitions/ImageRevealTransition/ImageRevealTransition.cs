using System;
using CoreGraphics;
using UIKit;

namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions
{
    // https://medium.com/@samstone/create-custom-uinavigationcontroller-transitions-in-ios-1acd6a0b6d25
    public class ImageRevealTransition : BaseTransition
    {
        private const int CustomAnimatorTag = 99;

        public ImageRevealTransition(float duration, bool isPresenting = true)
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

            var artwork = detailView.ViewWithTag(CustomAnimatorTag) as UIImageView;
            var artworkFrame = artwork.Frame;
            artwork.Image = SelectedImage;
            artwork.Alpha = 0;

            var transitionImageView = new UIImageView(IsPresenting ? StartingFrame : artworkFrame);
            transitionImageView.Image = SelectedImage;

            containerView.AddSubview(transitionImageView);

            toView.Frame = new CGRect(0, 0, fromView.Bounds.Width, fromView.Bounds.Height);
            toView.Alpha = IsPresenting ? 0 : 1;

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

            toView.LayoutIfNeeded();

            UIView.Animate(Duration, 0, UIViewAnimationOptions.CurveEaseInOut, () =>
            {
                detailView.Transform = IsPresenting ? CGAffineTransform.MakeIdentity() : scaleTransform;
                detailView.Center = new CGPoint(finalFrame.GetMidX(), finalFrame.GetMidY());

                transitionImageView.Frame = IsPresenting ? artworkFrame : StartingFrame;

                detailView.Alpha = IsPresenting ? 1 : 0;
            }, 
            () => {
                transitionContext.CompleteTransition(true);
                transitionImageView.RemoveFromSuperview();
                artwork.Alpha = 1;
            });
        }
    }
}
