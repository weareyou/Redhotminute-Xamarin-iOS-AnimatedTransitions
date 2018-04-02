using AnimatedTransitions.Samples.Core.Helpers;
using MvvmCross.Core.ViewModels;

namespace AnimatedTransitions.Samples.Core.ViewModels
{
	public class HomeViewModel : BaseViewModel
	{
		public HomeViewModel()
		{
		}

		public void Init()
		{
			TransitionSpeed = Settings.TransitionSpeed == 0f ? 0.5f : Settings.TransitionSpeed;
		}

		public MvxCommand GoToCenterPointViewCommand
		{
			get
			{
				return new MvxCommand(() =>
				{
					ShowViewModel<CenterPointViewModel>();
				});
			}
		}

		public MvxCommand GoToCircleButtonViewCommand
		{
			get
			{
				return new MvxCommand(() =>
				{
					ShowViewModel<CircleButtonViewModel>();
				});
			}
		}

		public MvxCommand GoToSquareButtonViewCommand
		{
			get
			{
				return new MvxCommand(() =>
				{
					ShowViewModel<SquareButtonViewModel>();
				});
			}
		}

		public MvxCommand ShowMenuCommand
		{
			get
			{
				return new MvxCommand(() =>
				{
					ShowViewModel<MenuViewModel>();
				});
			}
		}

		public MvxCommand ShowLeftRightMenuCommand
		{
			get
			{
				return new MvxCommand(() =>
				{
					ShowViewModel<LeftRightMenuViewModel>();
				});
			}
		}


	}
}
