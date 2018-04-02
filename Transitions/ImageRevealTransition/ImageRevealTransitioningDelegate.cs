using System;
using CoreGraphics;
using UIKit;

namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions
{
    public class ImageRevealTransitioningDelegate : BaseTransitioningDelegate<ImageRevealTransition>
    {
        public ImageRevealTransitioningDelegate(float duration) : base(new ImageRevealTransition(duration, true))
        {
        }
    }
}
