namespace Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces
{
	using System.Collections.Generic;
	using UIKit;

	public interface ILeftRightRevealViewController
	{
		List<UIView> LeftViews { get; }

		List<UIView> RightViews { get; }
	}
}
