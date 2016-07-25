using Microsoft.Azure;
using Microsoft.WindowsAzure.ServiceRuntime;
using System;

namespace Contoso.Events.ViewModels
{
    public static class CloudSettings
    {
        private const int DEFAULT_LATEST_EVENTS_COUNT = 2;
        private static int? _latestEventsCount = null;

        public static int LatestEventsCount
        {
            get
            {
                if (!_latestEventsCount.HasValue)
                {
                    string latestEventsCountString = GetConfigurationSetting("LatestEventsCount");
                    int latestEventsCount;
                    if (Int32.TryParse(latestEventsCountString, out latestEventsCount))
                    {
                        _latestEventsCount = latestEventsCount;
                    }
                    else
                    {
                        _latestEventsCount = DEFAULT_LATEST_EVENTS_COUNT;
                    }
                }

                return _latestEventsCount.Value;
            }
        }

        private static string GetConfigurationSetting(string settingName)
        {
            string settingValue = default(string);
            if (RoleEnvironment.IsAvailable)
            {
                settingValue = CloudConfigurationManager.GetSetting(settingName);
            }
            return settingValue;
        }
    }
}