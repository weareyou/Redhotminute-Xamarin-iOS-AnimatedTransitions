// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CustomTransitionsSample.ViewControllers
{
	[Register ("CenterPointViewController")]
	partial class CenterPointViewController
	{
		[Outlet]
		UIKit.UIButton CloseButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CloseButton != null) {
				CloseButton.Dispose ();
				CloseButton = null;
			}
		}
	}
}
