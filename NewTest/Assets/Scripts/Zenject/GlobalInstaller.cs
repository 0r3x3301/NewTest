using Zenject;
public class GlobalInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IInputHandler>().To<DesktopInputHandler>().AsSingle();
    }
}
