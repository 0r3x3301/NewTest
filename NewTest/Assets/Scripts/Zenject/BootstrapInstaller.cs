using UnityEngine;
using Zenject;
public class BootstrapInstaller : MonoInstaller
{
    [SerializeField] private PlayerConfig _startPlayerConfig;
    public InputHandlersSelector _handlersSelector;
    public override void InstallBindings()
    {
        InjectPlayer();
    }

    private void InjectPlayer()
    {
        Container.Bind<IInputHandler>().FromInstance(_handlersSelector.GetHandler()).AsSingle();
        Container.Bind<MovementHandler>().AsSingle();
        Container.Bind<PlayerConfig>().FromInstance(_startPlayerConfig).AsSingle();

        Container.Bind<PlayerModel>().AsSingle();
    }
}
