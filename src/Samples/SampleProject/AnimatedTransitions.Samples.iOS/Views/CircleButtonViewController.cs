namespace AnimatedTransitions.Samples.iOS.Views
{
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

    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.FullScreen)]
	public partial class CircleButtonViewController : MvxViewController<CircleButtonViewModel>
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
	
			TransitioningDelegate = new CircleButtonRevealTransitioningDelegate(Settings.TransitionSpeed, UIColor.FromRGB(244, 198, 249));

			CloseButton.Layer.CornerRadius = CloseButton.Frame.Size.Height / 2;

			var bindingSet = this.CreateBindingSet<CircleButtonViewController, CircleButtonViewModel>();
			bindingSet.Bind(CloseButton.Tap()).For(v => v.Command).To(vm => vm.CloseCommand);

			bindingSet.Apply();
		}
	}
}

