using Ajf.NsPlanner3.Shared;

namespace Ajf.NsPlanner3.App
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, System.EventArgs e)
        {
            var activatable = DataContext as IActivatable;
            if (activatable != null)
                activatable.Activated();
        }
    }
}