// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AnimatedTransitions.Samples.iOS.Views
{
    [Register ("SquareButtonViewController")]
    partial class SquareButtonViewController
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