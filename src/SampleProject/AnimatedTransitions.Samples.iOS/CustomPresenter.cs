namespace AnimatedTransitions.Samples.iOS
{
	using System;
	using AnimatedTransitions.Samples.iOS.Views;
	using MvvmCross.iOS.Views;
	using MvvmCross.iOS.Views.Presenters;
	using Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces;
	using UIKit;

	public class CustomPresenter : MvxIosViewPresenter
	{
		public CustomPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
		{
		}

		private UIViewController _currentModalView = null;
		private UIViewController _currentView = null;



        //protected override void ShowModalViewController(UIViewController viewController, MvvmCross.iOS.Views.Presenters.Attributes.MvxModalPresentationAttribute attribute, MvvmCross.Core.ViewModels.MvxViewModelRequest request)
        //{
        //    base.ShowModalViewController(viewController, attribute, request);
        //}


		//public override void Show(IMvxIosView view)
		//{
		//	if (view is IAnimatedTransitioningViewController)
		//	{
		//		_currentModalView = view as MvxViewController;
		//		_currentModalView.ModalPresentationStyle = ((IAnimatedTransitioningViewController)view).PresentationStyle;
  //              PresentModalViewController(_currentModalView, true);
		//		return;
		//	}

 	//		base.Show(view);
		//}

		//public override void Close(MvvmCross.Core.ViewModels.IMvxViewModel toClose)
		//{
		//	base.Close(toClose);
		//	//make sure there's no modal 
		//	if (_currentModalView != null)
		//	{
		//		CloseModalViewController();
		//	}
		//	else
		//	{
		//		_currentView = null;
		//	}
		//}

		//public override void CloseModalViewController()
		//{
		//	if (_currentModalView != null)
		//	{
		//		_currentModalView.DismissModalViewController(true);
		//		_currentModalView = null;
		//	}
		//}
	}
}
