using UnityEngine;
[CreateAssetMenu]
[System.Serializable]
public class ItemConfig : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Texture2D _icon;

    public string Name => _name;
    public string Description => _description;
    public Texture2D Icon => _icon;
}