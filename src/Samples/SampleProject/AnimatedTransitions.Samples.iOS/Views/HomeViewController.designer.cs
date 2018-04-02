// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AnimatedTransitions.Samples.iOS.Views
{
	[Register ("HomeViewController")]
	partial class HomeViewController
	{
		[Outlet]
		UIKit.UIButton CenterPointTransitionButton { get; set; }

		[Outlet]
		UIKit.UIButton CircleButtonTransitionButton { get; set; }

		[Outlet]
		UIKit.UIBarButtonItem MenuBarItem { get; set; }

		[Outlet]
		UIKit.UIBarButtonItem MenuLeftRightBarItem { get; set; }

		[Outlet]
		UIKit.UIButton SquareButtonTransitionButton { get; set; }

		[Outlet]
		UIKit.UISlider TransitionSpeedSlider { get; set; }

		[Outlet]
		UIKit.UILabel TransitionSpeedValueLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CenterPointTransitionButton != null) {
				CenterPointTransitionButton.Dispose ();
				CenterPointTransitionButton = null;
			}

			if (CircleButtonTransitionButton != null) {
				CircleButtonTransitionButton.Dispose ();
				CircleButtonTransitionButton = null;
			}

			if (MenuBarItem != null) {
				MenuBarItem.Dispose ();
				MenuBarItem = null;
			}

			if (SquareButtonTransitionButton != null) {
				SquareButtonTransitionButton.Dispose ();
				SquareButtonTransitionButton = null;
			}

			if (TransitionSpeedSlider != null) {
				TransitionSpeedSlider.Dispose ();
				TransitionSpeedSlider = null;
			}

			if (TransitionSpeedValueLabel != null) {
				TransitionSpeedValueLabel.Dispose ();
				TransitionSpeedValueLabel = null;
			}

			if (MenuLeftRightBarItem != null) {
				MenuLeftRightBarItem.Dispose ();
				MenuLeftRightBarItem = null;
			}
		}
	}
}
