// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CustomTransitionsSample
{
	[Register ("HomeViewController")]
	partial class HomeViewController
	{
		[Outlet]
		UIKit.UIButton CenterPointButton { get; set; }

		[Outlet]
		UIKit.UIButton CircularRevealButton { get; set; }

		[Outlet]
		UIKit.UIButton RotatingImage { get; set; }

		[Outlet]
		UIKit.UILabel TransitionSpeedLabel { get; set; }

		[Outlet]
		UIKit.UISlider TransitionSpeedSlider { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CenterPointButton != null) {
				CenterPointButton.Dispose ();
				CenterPointButton = null;
			}

			if (CircularRevealButton != null) {
				CircularRevealButton.Dispose ();
				CircularRevealButton = null;
			}

			if (TransitionSpeedLabel != null) {
				TransitionSpeedLabel.Dispose ();
				TransitionSpeedLabel = null;
			}

			if (TransitionSpeedSlider != null) {
				TransitionSpeedSlider.Dispose ();
				TransitionSpeedSlider = null;
			}

			if (RotatingImage != null) {
				RotatingImage.Dispose ();
				RotatingImage = null;
			}
		}
	}
}
