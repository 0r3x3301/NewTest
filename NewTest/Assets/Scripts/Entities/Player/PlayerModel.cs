using UnityEngine;
using Zenject;

public class PlayerModel
{
    public string Name { get; private set; }
    public float Speed { get; private set; }
    public float Health { get; private set; }
    public Transform Transform { get; private set; }

    [Inject]
    public PlayerModel(PlayerConfig config, Transform transform)
    {
        Name = config.Name;
        Speed = config.Speed;
        Health = config.Health;
        Transform = transform;
        Transform.position = config.StartPosition;
    }

    public void SetHealth(float value)
    {
        Health = value;
    }
    public void SetName(string value)
    {
        Name = value;
    }
    public void SetSpeed(float value)
    {
        Speed = value;
    }

    public void SetTransform(Transform value)
    {
        Transform = value;
    }
}
