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
    }

    public interface IStepViewModel
    {
        string Order { get; set; }
    }

    public class StepViewModel : IStepViewModel
    {
        public StepViewModel()
        {
            Order = "A";
        }

        public string Order { get; set; }
    }
    public class StepViewModel1 : IStepViewModel
    {
        public StepViewModel1()
        {
            Order = "B";
        }
        public string Order { get; set; }
    }
    public class StepViewModel3 : IStepViewModel
    {
        public StepViewModel3()
        {
            Order = "C";
        }
        public string Order { get; set; }
    }
}