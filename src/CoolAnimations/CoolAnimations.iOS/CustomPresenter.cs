using System;
using MvvmCross.iOS.Views.Presenters;
using UIKit;

namespace CoolAnimations.iOS
{
    public class CustomPresenter : MvxIosViewPresenter
    {
        public CustomPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {
        }

		protected override void CloseModalViewController(UIViewController modalController)
		{
            //base.CloseModalViewController(modalController);

            if (modalController == null)
                return;

            if (modalController is UINavigationController modalNavController)
            {
                foreach (var item in modalNavController.ViewControllers)
                    item.DidMoveToParentViewController(null);
            }

            modalController.DismissViewController(true, null);
            ModalViewControllers.Remove(modalController);
		}

	}
}
