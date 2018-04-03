// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CoolAnimations.iOS.Views
{
	[Register ("LeftRightViewController")]
	partial class LeftRightViewController
	{
		[Outlet]
		UIKit.UIButton CloseButton { get; set; }

		[Outlet]
		UIKit.UIView LeftImage1 { get; set; }

		[Outlet]
		UIKit.UIView LeftImage2 { get; set; }

		[Outlet]
		UIKit.UIView LeftImage3 { get; set; }

		[Outlet]
		UIKit.UIView RightImage1 { get; set; }

		[Outlet]
		UIKit.UIView RightImage2 { get; set; }

		[Outlet]
		UIKit.UIView RightImage3 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CloseButton != null) {
				CloseButton.Dispose ();
				CloseButton = null;
			}

			if (LeftImage1 != null) {
				LeftImage1.Dispose ();
				LeftImage1 = null;
			}

			if (LeftImage2 != null) {
				LeftImage2.Dispose ();
				LeftImage2 = null;
			}

			if (LeftImage3 != null) {
				LeftImage3.Dispose ();
				LeftImage3 = null;
			}

			if (RightImage1 != null) {
				RightImage1.Dispose ();
				RightImage1 = null;
			}

			if (RightImage2 != null) {
				RightImage2.Dispose ();
				RightImage2 = null;
			}

			if (RightImage3 != null) {
				RightImage3.Dispose ();
				RightImage3 = null;
			}
		}
	}
}
