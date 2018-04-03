namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class FadeInFadeOutTransitioningDelegate : BaseTransitioningDelegate<FadeInFadeOutTransition>
	{
        public FadeInFadeOutTransitioningDelegate(float duration) : base(new FadeInFadeOutTransition(duration, true))
		{
		}
	}
}
