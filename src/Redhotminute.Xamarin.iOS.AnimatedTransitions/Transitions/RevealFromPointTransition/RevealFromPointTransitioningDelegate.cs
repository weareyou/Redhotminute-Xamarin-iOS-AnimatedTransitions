using System;
namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class RevealFromPointTransitioningDelegate : BaseStartingFrameTransitioningDelegate<RevealFromPointTransition>
    {
        public RevealFromPointTransitioningDelegate(float duration) : base(new RevealFromPointTransition(duration))
        {
        }
    }
}
