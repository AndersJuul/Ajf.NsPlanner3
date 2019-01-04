using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Ajf.NsPlanner3.Shared
{
    public class MainWindowViewModel : BaseViewModel, IMainWindowViewModel
    {
        private readonly INsPlannerSettings _nsPlannerSettings;
        private readonly IOptionsWindowViewModel _optionsWindowViewModel;
        private bool _hasBeenActivated;

        public MainWindowViewModel(INsPlannerSettings nsPlannerSettings, IEnumerable<IStepViewModel> stepViewModels,
            IOptionsWindowViewModel optionsWindowViewModel)
        {
            _nsPlannerSettings = nsPlannerSettings;
            _optionsWindowViewModel = optionsWindowViewModel;
            StepViewModels = new ObservableCollection<IStepViewModel>(stepViewModels.OrderBy(x => x.Order));
        }

        public ObservableCollection<IStepViewModel> StepViewModels { get; }

        public string Title => $"NS Planner 3.0 - {_nsPlannerSettings.ReleaseNumber}";

        public void Activated()
        {
            // Do this only the first time.
            if (_hasBeenActivated)
                return;

            EditOptionsCommand.Execute(null);

            // Folder not present where Registry points out

            // Subfolder for relevant season is not present

            _hasBeenActivated = true;
        }

        private ICommand _editOptionsCommand;

        public ICommand EditOptionsCommand
        {
            get { return _editOptionsCommand ?? (_editOptionsCommand = new RelayCommand(param => EditOptions(), o => true)); }
        }

        private void EditOptions()
        {
            _optionsWindowViewModel.ShowDialog = true;
        }
    }
}