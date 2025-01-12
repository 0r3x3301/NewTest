using UnityEngine;
public class ItemTaker : MonoBehaviour
{
    [SerializeField] Transform _transform;
    private Inventory _inventory;
    private ItemMagnet _itemMagnet;

    public void TakeItem(ItemAsset itemAsset)
    {
        _inventory.Append(itemAsset.GetItem());
        Destroy(itemAsset.gameObject);
    }

    private void OnValidate()
    {
        _transform = GetComponent<Transform>();
    }

    public void Init(Inventory inventory)
    {
        _inventory = inventory;
        _itemMagnet = new(this);
    }

    private void Update()
    {
        _itemMagnet.Attract(_transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        ItemAsset itemAsset = other.GetComponent<ItemAsset>();
        if (itemAsset != null)
        {
            _itemMagnet.Catch(itemAsset);
        }
    }
}