using System;
namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class RevealFromPointTransitioningDelegate : BaseStartFrameTransitioningDelegate<RevealFromPointTransition>
    {
        public RevealFromPointTransitioningDelegate(float duration) : base(new RevealFromPointTransition(duration))
        {
        }
    }
}
