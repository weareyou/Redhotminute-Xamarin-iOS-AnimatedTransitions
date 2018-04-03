namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions
{
    public class ImageRevealTransitioningDelegate : StartImageTransitioningDelegate<ImageRevealTransition>
    {
        public ImageRevealTransitioningDelegate(float duration) : base(new ImageRevealTransition(duration, true))
        {
        }
    }
}
