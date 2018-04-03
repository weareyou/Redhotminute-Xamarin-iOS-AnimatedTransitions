using System;
namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class RevealFromPointTransitioningDelegate : StartFrameTransitioningDelegate<RevealFromPointTransition>
    {
        public RevealFromPointTransitioningDelegate(float duration) : base(new RevealFromPointTransition(duration))
        {
        }
    }
}
