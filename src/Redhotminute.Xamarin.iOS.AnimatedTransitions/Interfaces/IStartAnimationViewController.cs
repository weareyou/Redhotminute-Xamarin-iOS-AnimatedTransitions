using CoreGraphics;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces
{
    public interface IStartAnimationViewController
	{
		CGRect StartFrame { get; set; }

        UIImage StartImage { get; set; }
	}
}
