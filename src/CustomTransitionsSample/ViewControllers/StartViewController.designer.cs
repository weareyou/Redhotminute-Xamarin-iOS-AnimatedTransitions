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
	[Register ("StartViewController")]
	partial class StartViewController
	{
		[Outlet]
		UIKit.UIButton AnimationButton1 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (AnimationButton1 != null) {
				AnimationButton1.Dispose ();
				AnimationButton1 = null;
			}
		}
	}
}
