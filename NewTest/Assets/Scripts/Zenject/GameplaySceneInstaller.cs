using UnityEngine;
using Zenject;

public class GameplaySceneInstaller : MonoInstaller
{
    [SerializeField] private PlayerAsset _playerPrefab;
    [SerializeField] private PlayerConfig _startPlayerConfig;
    [SerializeField] private Transform _playerSpawnPoint;

    public override void InstallBindings()
    {
        Container.Bind<PlayerConfig>().FromInstance(_startPlayerConfig).AsSingle();
        PlayerAsset playerAsset = Container.InstantiatePrefabForComponent<PlayerAsset>(_playerPrefab, _playerSpawnPoint.position, Quaternion.identity, null);
        Camera.main.GetComponent<CameraSurveillanceHandler>()?.SetTarget(playerAsset.transform);
    }
}
