using System.Windows;
using Ajf.NsPlanner3.Shared;

namespace Ajf.NsPlanner3.App
{
    public partial class App
    {
        public App()
        {
            // Disable shutdown when the dialog closes
            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            var container = new StructureMap.Container(x=>x.AddRegistry<SharedRegistry>());
            
            var mainWindow = new MainWindow
            {
                DataContext = container.GetInstance<IMainWindowViewModel>()
            };

            mainWindow.ShowDialog();
        }
    }
}