using UnityEngine;
using Zenject;
public class BootstrapInstaller : MonoInstaller
{
    [SerializeField] private PlayerConfig _startPlayerConfig;
    public override void InstallBindings()
    {
        Container.Bind<PlayerConfig>().FromScriptableObject(_startPlayerConfig).AsSingle();
    }
}
