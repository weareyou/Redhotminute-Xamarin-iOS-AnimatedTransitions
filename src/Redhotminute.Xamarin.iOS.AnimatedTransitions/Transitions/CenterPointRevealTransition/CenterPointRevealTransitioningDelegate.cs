namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class CenterPointRevealTransitioningDelegate : BaseStartFrameTransitioningDelegate<CenterPointRevealTransition>
    {
        public CenterPointRevealTransitioningDelegate(float duration) : base(new CenterPointRevealTransition(duration, true))
        {
        }
    }
}
