using System.ComponentModel;

namespace Ajf.NsPlanner3.Shared
{
    public interface IOptionsWindowViewModel: INotifyPropertyChanged,ICanShowDialog
    {
        string ProjectListLocation { get; set; }
    }
}