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
    [Register ("LeftRightMenuViewController")]
    partial class LeftRightMenuViewController
    {
        [Outlet]
        UIKit.UIButton CloseButton { get; set; }


        [Outlet]
        UIKit.UIImageView Left1Image { get; set; }


        [Outlet]
        UIKit.UIImageView Left2Image { get; set; }


        [Outlet]
        UIKit.UIImageView Left3Image { get; set; }


        [Outlet]
        UIKit.UIImageView Right1Image { get; set; }


        [Outlet]
        UIKit.UIImageView Right2Image { get; set; }


        [Outlet]
        UIKit.UIImageView Right3Image { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CloseButton != null) {
                CloseButton.Dispose ();
                CloseButton = null;
            }

            if (Left1Image != null) {
                Left1Image.Dispose ();
                Left1Image = null;
            }

            if (Left2Image != null) {
                Left2Image.Dispose ();
                Left2Image = null;
            }

            if (Left3Image != null) {
                Left3Image.Dispose ();
                Left3Image = null;
            }

            if (Right1Image != null) {
                Right1Image.Dispose ();
                Right1Image = null;
            }

            if (Right2Image != null) {
                Right2Image.Dispose ();
                Right2Image = null;
            }

            if (Right3Image != null) {
                Right3Image.Dispose ();
                Right3Image = null;
            }
        }
    }
}