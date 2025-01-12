using System.Collections.Generic;
using UnityEngine;

public class ItemPool : MonoBehaviour
{
    [SerializeField] private Transform _itemsHolder;
    private List<ItemAsset> _activeItems = new();
    private List<ItemAsset> _inactiveItems = new();

    public ItemAsset GetActiveItem(ItemAsset itemPrefab)
    {
        ItemAsset item;
        for (int i = 0; i < _inactiveItems.Count; i++)
        {
            if (_inactiveItems[i].ItemConfig == itemPrefab.ItemConfig)
            {
                item = _inactiveItems[i];
                item.gameObject.SetActive(true);
                _activeItems.Add(item);
                _inactiveItems.RemoveAt(i);
                return item;
            }
        }
        return GameObject.Instantiate(itemPrefab, _itemsHolder);
    }

    public void Deactivate(ItemAsset item)
    {
        item.gameObject.SetActive(false);
        _inactiveItems.Add(item);
        _activeItems.Remove(item);
    }
}