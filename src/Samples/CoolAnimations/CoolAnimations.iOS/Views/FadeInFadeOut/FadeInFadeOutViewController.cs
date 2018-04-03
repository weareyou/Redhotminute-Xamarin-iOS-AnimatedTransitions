using System;
using CoolAnimations.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views.Gestures;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions;
using UIKit;

namespace CoolAnimations.iOS.Views
{
    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.FullScreen,
                          ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve)]
    public partial class FadeInFadeOutViewController : MvxViewController<FadeInFadeOutViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TransitioningDelegate = new FadeInFadeOutTransitioningDelegate(ViewModel.Duration);

            var bindingSet = this.CreateBindingSet<FadeInFadeOutViewController, FadeInFadeOutViewModel>();
            bindingSet.Bind(CloseButton.Tap()).For(v => v.Command).To(vm => vm.CloseCommand);
            bindingSet.Apply();
        }
    }
}

