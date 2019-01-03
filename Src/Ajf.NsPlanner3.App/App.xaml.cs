using Ajf.NsPlanner3.Shared;
using Ajf.NsPlanner3_App;

namespace Ajf.NsPlanner3.App
{
    public partial class App
    {
        public App()
        {
            var container = new StructureMap.Container(x=>x.AddRegistry<SharedRegistry>());
            
            var view = new MainWindow
            {
                DataContext = container.GetInstance<IMainWindowViewModel>()
            };

            view.ShowDialog();
        }
    }
}