namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class ImageRevealTransitioningDelegate : BaseStartImageTransitioningDelegate<ImageRevealTransition>
    {
        public ImageRevealTransitioningDelegate(float duration) : base(new ImageRevealTransition(duration, true))
        {
        }
    }
}
