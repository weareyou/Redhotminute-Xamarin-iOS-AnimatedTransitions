namespace AnimatedTransitions.Samples.iOS.Views
{
	using System;
	using AnimatedTransitions.Samples.Core.Helpers;
	using AnimatedTransitions.Samples.Core.ViewModels;
	using MvvmCross.Binding.BindingContext;
	using MvvmCross.Binding.iOS.Views.Gestures;
	using MvvmCross.iOS.Views;
    using MvvmCross.iOS.Views.Presenters.Attributes;
	using Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions;
	using UIKit;

    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.FullScreen, ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve)]
    public partial class CenterPointViewController : MvxViewController<CenterPointViewModel>
	{
        public override void ViewDidLoad()
		{
			base.ViewDidLoad();
	
			TransitioningDelegate = new CenterPointRevealTransitioningDelegate(Settings.TransitionSpeed);

			var bindingSet = this.CreateBindingSet<CenterPointViewController, CenterPointViewModel>();
			bindingSet.Bind(CloseButton.Tap()).For(v => v.Command).To(vm => vm.CloseCommand);
	
			bindingSet.Apply();
		}
	}
}