namespace AnimatedTransitions.Samples.iOS.Views
{
	using System;
	using AnimatedTransitions.Samples.Core.ViewModels;
	using CoreGraphics;
	using MvvmCross.Binding.BindingContext;
    using MvvmCross.Core.Views;
    using MvvmCross.iOS.Views;
	using Redhotminute.Plugin.iOS.AnimatedTransitions.Interfaces;
	using UIKit;


    public partial class HomeViewController : MvxViewController<HomeViewModel>, IStartAnimationViewController
	{
		private CGRect _startingFrame;
		public CGRect StartingFrame
		{
			set { this._startingFrame = value; }
			get { return this._startingFrame; }
		}

        public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			NavigationController.SetNavigationBarHidden(true, false);

			CircleButtonTransitionButton.Layer.CornerRadius = CircleButtonTransitionButton.Frame.Size.Height / 2;

			var bindingSet = this.CreateBindingSet<HomeViewController, HomeViewModel>();
			bindingSet.Bind(TransitionSpeedSlider).To(vm => vm.TransitionSpeed);
			bindingSet.Bind(TransitionSpeedValueLabel).For(v => v.Text).To(vm => vm.TransitionSpeed);
			bindingSet.Bind(MenuBarItem).To(vm => vm.ShowMenuCommand);
			bindingSet.Bind(MenuLeftRightBarItem).To(vm => vm.ShowLeftRightMenuCommand);
			bindingSet.Apply();

			CenterPointTransitionButton.TouchUpInside += (sender, e) =>
			{
				StartingFrame = CenterPointTransitionButton.Frame;
				ViewModel.GoToCenterPointViewCommand.Execute(null);
			};

			CircleButtonTransitionButton.TouchUpInside += (sender, e) =>
			{
				StartingFrame = CircleButtonTransitionButton.Frame;
				ViewModel.GoToCircleButtonViewCommand.Execute(null);
			};

			SquareButtonTransitionButton.TouchUpInside += (sender, e) =>
			{
				StartingFrame = SquareButtonTransitionButton.Frame;
				ViewModel.GoToSquareButtonViewCommand.Execute(null);
			};


		}
	}
}

