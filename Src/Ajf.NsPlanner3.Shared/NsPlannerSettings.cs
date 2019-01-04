using JCI.ITC.COMP2.Common.SettingsEnrichers;

namespace Ajf.NsPlanner3.Shared
{
    public class NsPlannerSettings: INsPlannerSettings
    {
        public NsPlannerSettings()
        {
            IdentitySettingsEnricher.Enrich(this);
        }
        public string ReleaseNumber { get; set; }
        public string ComponentName { get; set; }
        public string SuiteName { get; set; }
        public string Environment { get; set; }
    }
}