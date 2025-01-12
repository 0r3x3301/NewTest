using UnityEngine;
using Zenject;

public class GameplaySceneInstaller : MonoInstaller
{
    [SerializeField] private PlayerAsset _playerPrefab;
    [SerializeField] private PlayerConfig _startPlayerConfig;
    [SerializeField] private Transform _playerSpawnPoint;
    [SerializeField] private InputHandlerSelector _inputHandlerSelector;
    [SerializeField] private ItemPool _itemPool;

    public override void InstallBindings()
    {
        Container.Bind<ItemPool>().FromInstance(_itemPool).AsSingle();
        Container.Bind<IInputHandler>().FromInstance(_inputHandlerSelector.InputHandler).AsSingle();
        Container.Bind<PlayerConfig>().FromInstance(_startPlayerConfig).AsSingle();
        PlayerAsset playerAsset = Container.InstantiatePrefabForComponent<PlayerAsset>(_playerPrefab, _playerSpawnPoint.position, Quaternion.identity, null);
        Camera.main.GetComponent<CameraSurveillanceHandler>()?.SetTarget(playerAsset.transform);
    }
}
