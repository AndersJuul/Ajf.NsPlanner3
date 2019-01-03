﻿namespace Ajf.NsPlanner3.Shared
{
    public class MainWindowViewModel: IMainWindowViewModel
    {
        private readonly INsPlannerSettings _nsPlannerSettings;

        public MainWindowViewModel(INsPlannerSettings nsPlannerSettings)
        {
            _nsPlannerSettings = nsPlannerSettings;
        }

        public string Title => $"NS Planner 3.0 - {_nsPlannerSettings.ReleaseNumber}";
    }
}