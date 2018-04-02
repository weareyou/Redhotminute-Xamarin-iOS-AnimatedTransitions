using System;
using System.Collections.Generic;
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
	public partial class LeftRightMenuViewController : MvxViewController<LeftRightMenuViewModel>, ILeftRightRevealViewController
	{
		public LeftRightMenuViewController()
		{
			TransitioningDelegate = new LeftRightInOuttTransitioningDelegate(Settings.TransitionSpeed);
		}

		public List<UIView> LeftViews
		{
			get
			{
				return new List<UIView>
				{
					Left1Image,
					Left2Image,
					Left3Image
				};
			}
		}

		public List<UIView> RightViews
		{
			get
			{
				return new List<UIView>
				{
					Right1Image,
					Right2Image,
					Right3Image
				};
			}
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var bindingSet = this.CreateBindingSet<LeftRightMenuViewController, LeftRightMenuViewModel>();
			bindingSet.Bind(CloseButton.Tap()).For(v => v.Command).To(vm => vm.CloseCommand);
			bindingSet.Apply();
		}
	}
}

