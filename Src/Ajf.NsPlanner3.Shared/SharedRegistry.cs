using System.Reflection;
using StructureMap;

namespace Ajf.NsPlanner3.Shared
{
    public class SharedRegistry:Registry
    {
        public SharedRegistry()
        {
            Scan(s=>
            {
                s.Assembly(Assembly.GetExecutingAssembly());
                s.WithDefaultConventions();
                s.AddAllTypesOf<IStepViewModel>();

                For<IOptionsWindowViewModel>().Use<OptionsWindowViewModel>().Singleton();
                For<IMainWindowViewModel>().Use<MainWindowViewModel>().Singleton();
            });
        }
    }
}