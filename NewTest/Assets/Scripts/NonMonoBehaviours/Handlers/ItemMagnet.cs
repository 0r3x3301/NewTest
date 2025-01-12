using System.Collections.Generic;
using UnityEngine;
public class ItemMagnet
{
    private List<ItemAsset> _items = new();

    private ItemTaker _itemTaker;
    private float _magnetPower = 8f;

    public ItemMagnet(ItemTaker itemTaker) 
    {
        _itemTaker = itemTaker;
    }

    public void Catch(ItemAsset itemAsset)
    {
        if (!_items.Contains(itemAsset))
        {
            _items.Add(itemAsset);
        }
    }

    public void Attract(Vector3 position)
    {
        for (int i = 0; i < _items.Count; i++)
        {
            Vector3 itemPosition = _items[i].transform.position;
            if (Vector3.Distance(itemPosition, position) > 1f)
            {
                _items[i].transform.position = Vector3.MoveTowards(itemPosition, position, _magnetPower * Time.deltaTime);
            }
            else
            {
                _itemTaker.TakeItem(_items[i]);
                _items.RemoveAt(i);
            }
        }
    }
}