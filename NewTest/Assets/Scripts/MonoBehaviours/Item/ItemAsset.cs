using UnityEngine;
public class ItemAsset : MonoBehaviour
{
    [SerializeField] private ItemConfig _itemConfig;
    [SerializeField] private int _itemCount = 1;

    public Item GetItem()
    {
        return new Item(_itemConfig, _itemCount);
    }
}