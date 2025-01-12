[System.Serializable]
public class Item
{
    public ItemConfig Config {  get; private set; }
    public int Count { get; set; }

    public Item(ItemConfig config, int count = 1)
    {
        Config = config;
        Count = count;
    }
}