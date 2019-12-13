using System;

using R5T.Cherusci;


namespace R5T.Shrewsbury
{
    public static class Utilities
    {
        public static string GetConfigurationNameSpecificAppSettingsJsonFileName(string baseAppsettingsFileNameWithoutExtension, string configurationNameAppSettingsFileNameToken)
        {
            var appSettingsJsonFileName = $"{baseAppsettingsFileNameWithoutExtension}.{configurationNameAppSettingsFileNameToken}.{FileExtensions.Json}";
            return appSettingsJsonFileName;
        }

        public static string GetConfigurationNameSpecificAppSettingsJsonFileName(string configurationNameAppSettingsFileNameToken)
        {
            var appsSettingsJsonFileName = Utilities.GetConfigurationNameSpecificAppSettingsJsonFileName(Constants.DefaultBaseAppSettingsFileNameWithoutExtension, configurationNameAppSettingsFileNameToken);
            return appsSettingsJsonFileName;
        }
    }
}
