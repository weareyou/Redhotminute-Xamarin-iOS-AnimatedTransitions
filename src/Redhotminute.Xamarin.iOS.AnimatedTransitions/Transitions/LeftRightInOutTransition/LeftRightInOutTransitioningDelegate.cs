namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class LeftRightInOutTransitioningDelegate : BaseTransitioningDelegate<LeftRightInOutTransition>
	{
        public LeftRightInOutTransitioningDelegate(float duration) : base(new LeftRightInOutTransition(duration, true))
		{
		}
	}
}
