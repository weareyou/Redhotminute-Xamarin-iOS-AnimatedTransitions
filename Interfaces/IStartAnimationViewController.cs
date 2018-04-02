using CoreGraphics;
using UIKit;

namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces
{
    public interface IStartAnimationViewController
	{
		CGRect StartingFrame { get; set; }

        UIImage SelectedImage { get; set; }
	}
}
