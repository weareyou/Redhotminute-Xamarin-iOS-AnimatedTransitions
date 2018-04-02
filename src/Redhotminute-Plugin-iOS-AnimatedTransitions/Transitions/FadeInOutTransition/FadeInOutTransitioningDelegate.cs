namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions
{
    public class FadeInOutTransitioningDelegate : BaseTransitioningDelegate<FadeInOutTransition>
	{
        public FadeInOutTransitioningDelegate(float duration) : base(new FadeInOutTransition(duration, true))
		{
		}
	}
}
