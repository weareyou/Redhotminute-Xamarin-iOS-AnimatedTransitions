using System;
using CoolAnimations.Core.Helpers;

namespace CoolAnimations.Core.ViewModels 
{
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel()
        {
        }

        public float DurationSetting
        {
            get => Settings.Duration;
            set 
            {
                Settings.Duration = value;
                RaisePropertyChanged(nameof(DurationText));
                RaisePropertyChanged(nameof(Duration));
            }
        }

        public string DurationText => $"Animation speed ({DurationSetting})";
    }
}
