using System;
using System.Collections.Generic;
using System.Text;

namespace Hudson.TrayTracker.Entities
{
    public enum BuildStatus
    {
        Successful,
        Successful_BuildInProgress,
        Indeterminate,
        Indeterminate_BuildInProgress,
        Unstable,
        Unstable_BuildInProgress,
        Failed,
        Failed_BuildInProgress
    }

    public static class BuildStatusUtils
    {
        public static bool IsBuildInProgress(BuildStatus status)
        {
            return (status == BuildStatus.Successful_BuildInProgress
                || status == BuildStatus.Indeterminate_BuildInProgress
                || status == BuildStatus.Unstable_BuildInProgress
                || status == BuildStatus.Failed_BuildInProgress);
        }
    }
}