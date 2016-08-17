using System;
using System.Configuration;

namespace Contoso.Events.ViewModels
{
    public static class CloudSettings
    {
        private static int? _latestEventsCount = null;

        public static int LatestEventsCount
        {
            get
            {
                if (!_latestEventsCount.HasValue)
                {
                    string latestEventsCountString = ConfigurationManager.AppSettings["LatestEventsCount"];
                    int latestEventsCount = 0;
                    Int32.TryParse(latestEventsCountString, out latestEventsCount);
                    _latestEventsCount = latestEventsCount;
                }

                return _latestEventsCount.Value;
            }
        }
    }
}