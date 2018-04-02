using System;
namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions
{
    public class RevealFromPointTransitioningDelegate : BaseStartingFrameTransitioningDelegate<RevealFromPointTransition>
    {
        public RevealFromPointTransitioningDelegate(float duration) : base(new RevealFromPointTransition(duration))
        {
        }
    }
}
