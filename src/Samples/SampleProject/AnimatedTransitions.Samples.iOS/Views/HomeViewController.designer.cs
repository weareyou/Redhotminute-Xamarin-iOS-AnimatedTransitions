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

            if (MenuLeftRightBarItem != null) {
                MenuLeftRightBarItem.Dispose ();
                MenuLeftRightBarItem = null;
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
        }
    }
}