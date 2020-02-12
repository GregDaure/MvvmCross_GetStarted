using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCrossTest.Core.ViewModels;

namespace MvvmCrossTest.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<HomeViewModel>();
        }
    }
}
