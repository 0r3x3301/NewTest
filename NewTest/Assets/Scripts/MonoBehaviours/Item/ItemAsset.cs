using UnityEngine;
[System.Serializable]
public class ItemAsset : MonoBehaviour
{
    [field: SerializeField] public ItemConfig ItemConfig { get; private set; }
    public int ItemCount = 1;

    public Item GetItem()
    {
        return new Item(ItemConfig, ItemCount);
    }
}