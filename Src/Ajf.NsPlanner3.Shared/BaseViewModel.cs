using System.ComponentModel;
using System.Runtime.CompilerServices;
using Ajf.NsPlanner3.Shared.Annotations;

namespace Ajf.NsPlanner3.Shared
{
    public class BaseViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}