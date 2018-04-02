﻿using System;
using CoolAnimations.Core.Helpers;

namespace CoolAnimations.Core.ViewModels 
{
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel()
        {
        }

        //public float DurationSetting
        //{
        //    get => Settings.Duration;
        //    set 
        //    {
        //        Settings.Duration = value;
        //        RaisePropertyChanged(nameof(DurationText));
        //    }
        //}

        private float _durationSetting;
        public float DurationSetting
        {
            get => _durationSetting;
            set => InvokeOnMainThread(() => SetProperty(ref _durationSetting, value));
        }

        public string DurationText => $"Duration animation ({DurationSetting})";
    }
}
