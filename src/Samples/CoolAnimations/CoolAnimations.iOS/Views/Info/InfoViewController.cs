using System;
using CoolAnimations.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views.Gestures;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Redhotminute.Xamarin.iOS.AnimatedTransitions.Transitions;
using UIKit;

namespace CoolAnimations.iOS.Views
{
    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.FullScreen,
                          ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve)]
    public partial class InfoViewController : MvvmCross.iOS.Views.MvxViewController<InfoViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
           
            TransitioningDelegate = new CirculairRevealTransitioningDelegate(ViewModel.Duration, UIColor.White);

            var bindingSet = this.CreateBindingSet<InfoViewController, InfoViewModel>();
            bindingSet.Bind(CloseButton.Tap()).For(v => v.Command).To(vm => vm.CloseCommand);
            bindingSet.Apply();
        }
    }
}

