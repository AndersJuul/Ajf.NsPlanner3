using System.ComponentModel;

namespace Ajf.NsPlanner3.Shared
{
    public interface ICanShowDialog:INotifyPropertyChanged
    {
        bool ShowDialog { get; set; }
        bool? LatestDialogResult { get; set; }
    }
}