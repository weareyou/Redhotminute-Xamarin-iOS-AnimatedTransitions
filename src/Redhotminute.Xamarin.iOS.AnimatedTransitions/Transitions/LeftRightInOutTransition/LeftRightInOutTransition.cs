using System.Collections.Generic;
using CoreGraphics;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class LeftRightInOutTransition : BaseTransition
    {
        public LeftRightInOutTransition(float duration, bool isPresenting = true)
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

            //var containerView = transitionContext.ContainerView;
            //var fromViewController = transitionContext.GetViewControllerForKey(UITransitionContext.FromViewControllerKey);
            //var toViewController = transitionContext.GetViewControllerForKey(UITransitionContext.ToViewControllerKey);

            //toViewController.View.Alpha = 0f;

            //containerView.AddSubview(toViewController.View);

            //List<UIView> leftViews;
            //List<UIView> rightViews;

            //if (IsPresenting)
            //{
            //    leftViews = ((ILeftRightRevealViewController)toViewController).LeftViews;
            //    rightViews = ((ILeftRightRevealViewController)toViewController).RightViews;

            //    foreach (var view in leftViews)
            //    {
            //        view.Transform = OffStage(-150f);
            //    }
            //    foreach (var view in rightViews)
            //    {
            //        view.Transform = OffStage(150f);
            //    }

            //    UIView.Animate(Duration, 0, UIViewAnimationOptions.CurveEaseInOut,
            //  () =>
            //  {
            //      toViewController.View.Alpha = 1f;

            //      foreach (var view in leftViews)
            //      {
            //          view.Transform = CGAffineTransform.MakeIdentity();
            //      }
            //      foreach (var view in rightViews)
            //      {
            //          view.Transform = CGAffineTransform.MakeIdentity();
            //      }
            //  }, () =>
            //  {
            //      fromViewController.View.RemoveFromSuperview();
            //      transitionContext.CompleteTransition(true);
            //  }
            //  );
            //}
            //else
            //{
            //    leftViews = ((ILeftRightRevealViewController)fromViewController).LeftViews;
            //    rightViews = ((ILeftRightRevealViewController)fromViewController).RightViews;

            //    UIView.Animate(Duration, 0, UIViewAnimationOptions.CurveEaseInOut,
            //  () =>
            //  {
            //      toViewController.View.Alpha = 1f;

            //      foreach (var view in leftViews)
            //      {
            //          view.Transform = OffStage(-150f);
            //      }
            //      foreach (var view in rightViews)
            //      {
            //          view.Transform = OffStage(150f);
            //      }
            //  }, () =>
            //  {
            //      fromViewController.View.RemoveFromSuperview();
            //      transitionContext.CompleteTransition(true);
            //  }
            //  );
            //}
        }

        private CGAffineTransform OffStage(float amount)
        {
            return CGAffineTransform.MakeTranslation(amount, 0);
        }


    }
}
