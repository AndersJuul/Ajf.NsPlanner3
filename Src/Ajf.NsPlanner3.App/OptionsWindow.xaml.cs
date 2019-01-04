using System.ComponentModel;
using Ajf.NsPlanner3.Shared;

namespace Ajf.NsPlanner3.App
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow 
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void Window_DataContextChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            var canShowDialog = e.NewValue as ICanShowDialog;
            if (canShowDialog != null)
                canShowDialog.PropertyChanged += canShowDialog_propertychanged;
        }

        private void canShowDialog_propertychanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName!= nameof(ICanShowDialog.ShowDialog))
                return;

            var canShowDialog = sender as ICanShowDialog;
            //canShowDialog.LatestDialogResult = 
                Show();
        }
    }
}
