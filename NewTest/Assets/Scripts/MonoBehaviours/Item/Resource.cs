using System.Collections.Generic;
using UnityEngine;
using Zenject;

[System.Serializable]
public class Resource : MonoBehaviour, ICanBeSelected
{
    [SerializeField] private ItemAsset _itemPrefab;
    [SerializeField] private int _itemCount;
    private List<ItemAsset> _items = new();
    private float _dropForce = 100f;
    private float _dropRangeBorder = 1f;
    [Inject] private ItemPool _itemPool;

    public void Mine()
    {
        SpawnItems();
        Destroy(gameObject);
        for (int i = 0; i < _items.Count; i++)
        {
            _items[i].gameObject.SetActive(true);
            var itemRigidbody = _items[i].GetComponent<Rigidbody>();
            DropItem(itemRigidbody);
        }
    }

    private void DropItem(Rigidbody itemRigidbody)
    {
        float dropOffsetX = Random.Range(-_dropRangeBorder * _dropForce, _dropRangeBorder * _dropForce);
        float dropOffsetY = Random.Range(_dropForce, _dropForce * 1.1f);
        float dropOffsetZ = Random.Range(-_dropRangeBorder * _dropForce, _dropRangeBorder * _dropForce);
        var dropOffset = new Vector3(dropOffsetX, dropOffsetY, dropOffsetZ);
        itemRigidbody.AddForce(Vector3.up + dropOffset);
    }

    private void SpawnItems()
    {
        for (int i = 0; i < _itemCount; i++)
        {
            var newItem = _itemPool.GetActiveItem(_itemPrefab);
            newItem.transform.position = transform.position;
            newItem.gameObject.SetActive(false);
            _items.Add(newItem);
        }
    }
}