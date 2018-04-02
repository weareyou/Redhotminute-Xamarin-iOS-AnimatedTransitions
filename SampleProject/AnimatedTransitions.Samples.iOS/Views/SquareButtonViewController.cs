using System;
using AnimatedTransitions.Samples.Core.Helpers;
using AnimatedTransitions.Samples.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views.Gestures;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions;
using UIKit;

namespace AnimatedTransitions.Samples.iOS.Views
{
    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.FullScreen, ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve)]
	public partial class SquareButtonViewController : MvxViewController<SquareButtonViewModel>
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			TransitioningDelegate = new SquareButtonRevealTransitioningDelegate(Settings.TransitionSpeed, UIColor.FromRGB(183, 18, 52));

			var bindingSet = this.CreateBindingSet<SquareButtonViewController, SquareButtonViewModel>();
			bindingSet.Bind(CloseButton.Tap()).For(v => v.Command).To(vm => vm.CloseCommand);

			bindingSet.Apply();
		}

	}
}

