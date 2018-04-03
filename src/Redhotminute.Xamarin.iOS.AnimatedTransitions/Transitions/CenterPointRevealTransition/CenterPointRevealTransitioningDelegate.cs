namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class CenterPointRevealTransitioningDelegate : StartFrameTransitioningDelegate<CenterPointRevealTransition>
    {
        public CenterPointRevealTransitioningDelegate(float duration) : base(new CenterPointRevealTransition(duration, true))
        {
        }
    }
}
