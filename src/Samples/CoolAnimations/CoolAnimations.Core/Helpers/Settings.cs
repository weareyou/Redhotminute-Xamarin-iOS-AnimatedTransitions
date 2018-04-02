using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace CoolAnimations.Core.Helpers
{
    public class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        #endregion

        public static string GeneralSettings
        {
            get => AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            set => AppSettings.AddOrUpdateValue(SettingsKey, value);
        }

        public static float Duration
        {
            get => AppSettings.GetValueOrDefault("duration", 0.3f);
            set => AppSettings.AddOrUpdateValue("duration", value); 
        }
    }
}
