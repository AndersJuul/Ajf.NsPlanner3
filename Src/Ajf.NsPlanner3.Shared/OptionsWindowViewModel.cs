using System;
using System.IO;

namespace Ajf.NsPlanner3.Shared
{
    public class OptionsWindowViewModel : BaseViewModel, IOptionsWindowViewModel
    {
        private readonly INsPlannerSettings _nsPlannerSettings;
        private bool? _latestDialogResult;
        private bool _showDialog;
        private string _projectListLocation;

        public OptionsWindowViewModel(INsPlannerSettings nsPlannerSettings)
        {
            _nsPlannerSettings = nsPlannerSettings;

            ProjectListLocation =
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NsPlanner3");
        }

        public bool ShowDialog
        {
            get => _showDialog;
            set
            {
                _showDialog = value;
                OnPropertyChanged();
            }
        }

        public bool? LatestDialogResult
        {
            get => _latestDialogResult;
            set
            {
                _latestDialogResult = value;
                OnPropertyChanged();
            }
        }

        public string ProjectListLocation
        {
            get => _projectListLocation;
            set
            {
                _projectListLocation = value; 
                OnPropertyChanged();
            }
        }
    }
}