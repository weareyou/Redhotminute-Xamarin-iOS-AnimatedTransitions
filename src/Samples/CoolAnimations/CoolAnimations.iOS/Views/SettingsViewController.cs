using System;
using CoolAnimations.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views.Gestures;
using MvvmCross.iOS.Views.Presenters.Attributes;
using Redhotminute.Plugin.iOS.AnimatedTransitions.Transitions;
using UIKit;

namespace CoolAnimations.iOS.Views
{
    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.FullScreen,
                          ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve)]
    public partial class SettingsViewController : MvvmCross.iOS.Views.MvxViewController<SettingsViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TransitioningDelegate = new CircleButtonRevealTransitioningDelegate(ViewModel.Duration, UIColor.White);
     
            var bindingSet = this.CreateBindingSet<SettingsViewController, SettingsViewModel>();
            bindingSet.Bind(CloseButton.Tap()).For(v => v.Command).To(vm => vm.CloseCommand);
            bindingSet.Bind(DurationSlider).For(v => v.Value).To(vm => vm.DurationSetting);
            //bindingSet.Bind(DurationLabel).For(v => v.Text).To(vm => vm.DurationText);
            bindingSet.Apply();
        }
    }
}

