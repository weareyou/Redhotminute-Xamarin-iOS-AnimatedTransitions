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
	[Register ("HomeViewController")]
	partial class HomeViewController
	{
		[Outlet]
		UIKit.UIButton ButtonReveal { get; set; }

		[Outlet]
		UIKit.UIButton FadeInFadeOutButton { get; set; }

		[Outlet]
		UIKit.UIButton IconImage { get; set; }

		[Outlet]
		UIKit.UIButton InfoButton { get; set; }

		[Outlet]
		UIKit.UIScrollView ScrollView { get; set; }

		[Outlet]
		UIKit.UIButton SecondButtonReveal { get; set; }

		[Outlet]
		UIKit.UIButton SettingsButton { get; set; }

		[Outlet]
		UIKit.UIButton ThirdButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ButtonReveal != null) {
				ButtonReveal.Dispose ();
				ButtonReveal = null;
			}

			if (FadeInFadeOutButton != null) {
				FadeInFadeOutButton.Dispose ();
				FadeInFadeOutButton = null;
			}

			if (IconImage != null) {
				IconImage.Dispose ();
				IconImage = null;
			}

			if (ScrollView != null) {
				ScrollView.Dispose ();
				ScrollView = null;
			}

			if (SecondButtonReveal != null) {
				SecondButtonReveal.Dispose ();
				SecondButtonReveal = null;
			}

			if (SettingsButton != null) {
				SettingsButton.Dispose ();
				SettingsButton = null;
			}

			if (ThirdButton != null) {
				ThirdButton.Dispose ();
				ThirdButton = null;
			}

			if (InfoButton != null) {
				InfoButton.Dispose ();
				InfoButton = null;
			}
		}
	}
}
