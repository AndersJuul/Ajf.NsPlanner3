using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Ajf.NsPlanner3.Shared
{
    public class MainWindowViewModel: IMainWindowViewModel
    {
        private readonly INsPlannerSettings _nsPlannerSettings;

        public MainWindowViewModel(INsPlannerSettings nsPlannerSettings, IEnumerable<IStepViewModel> stepViewModels)
        {
            _nsPlannerSettings = nsPlannerSettings;
            StepViewModels = new ObservableCollection<IStepViewModel>(stepViewModels.OrderBy(x=>x.Order));
        }

        public ObservableCollection<IStepViewModel> StepViewModels { get; private set; }

        public string Title => $"NS Planner 3.0 - {_nsPlannerSettings.ReleaseNumber}";

        public void Activated()
        {

        }
    }
}