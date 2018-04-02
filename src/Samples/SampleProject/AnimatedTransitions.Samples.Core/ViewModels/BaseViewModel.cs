namespace AnimatedTransitions.Samples.Core.ViewModels
{
	using System;
	using AnimatedTransitions.Samples.Core.Helpers;
	using MvvmCross.Core.ViewModels;

	public class BaseViewModel : MvxViewModel
	{
		private float _transitionSpeed;
		public float TransitionSpeed
		{
			get { return Settings.TransitionSpeed; }
			set
			{
				Settings.TransitionSpeed = (float)Math.Round(value, 2);
				SetProperty(ref this._transitionSpeed, value);
			}
		}

		public BaseViewModel()
		{
		}

		public MvxCommand CloseCommand
		{
			get
			{
				return new MvxCommand(() => Close(this));
			}
		}
	}
}
