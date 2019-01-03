using Ajf.NsPlanner3_App;

namespace Ajf.NsPlanner3.App
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            var view = new MainWindow();

            view.ShowDialog();
        }
    }
}