namespace AnimatedTransitions.Samples.iOS.Views
{
	using System;
	using AnimatedTransitions.Samples.Core.Helpers;
	using AnimatedTransitions.Samples.Core.ViewModels;
	using Foundation;
	using MvvmCross.Binding.BindingContext;
	using MvvmCross.Binding.iOS.Views.Gestures;
	using MvvmCross.iOS.Views;
    using MvvmCross.iOS.Views.Presenters.Attributes;
    using Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces;
	using Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions;
	using UIKit;

    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.FullScreen, ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve)]
	public partial class MenuViewController : MvxViewController<MenuViewModel>
	{
		public MenuViewController()
		{
			TransitioningDelegate = new FadeInOutTransitioningDelegate(Settings.TransitionSpeed);
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var bindingSet = this.CreateBindingSet<MenuViewController, MenuViewModel>();
			bindingSet.Bind(CloseButton.Tap()).For(v => v.Command).To(vm => vm.CloseCommand);
			bindingSet.Apply();

		}
	}
}

