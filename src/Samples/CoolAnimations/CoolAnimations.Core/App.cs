using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace CoolAnimations.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            
            RegisterNavigationServiceAppStart<ViewModels.HomeViewModel>();
        }
    }
}
