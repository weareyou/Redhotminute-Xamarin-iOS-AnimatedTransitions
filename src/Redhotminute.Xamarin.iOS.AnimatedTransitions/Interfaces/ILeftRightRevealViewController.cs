using System.Collections.Generic;
using UIKit;

namespace Redhotminute.Xamarin.iOS.AnimatedTransitions.Interfaces
{
	public interface ILeftRightRevealViewController
	{
		List<UIView> LeftViews { get; }

		List<UIView> RightViews { get; }
	}
}
