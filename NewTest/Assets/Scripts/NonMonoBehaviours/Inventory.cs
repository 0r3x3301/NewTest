using System.Collections.Generic;
[System.Serializable]
public class Inventory
{
    private List<Item> _items = new();
    public IReadOnlyList<Item> Items => _items;

    public void Append(Item newItem)
    {
        foreach (var item in _items)
        {
            if (item.Config == newItem.Config)
            {
                item.Count += newItem.Count;
                return;
            }
        }
        _items.Add(newItem);
    }

    public bool TryRemove(ItemConfig itemConfig, int count)
    {
        foreach (var item in _items)
        {
            if (item.Config == itemConfig)
            {
                if (count < item.Count)
                {
                    item.Count -= count;
                    return true;
                }
                else if (count == item.Count)
                {
                    _items.Remove(item);
                    return true;
                }
                else return false;
            }
        }
        return false;
    }
}