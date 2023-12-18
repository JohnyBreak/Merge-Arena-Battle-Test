using Zenject;

public class ShopItemService
{
    private IPersistentData _persistentData;
    [Inject]
    private void Construct(IPersistentData persistentData)
    {
        _persistentData = persistentData;
    }

    public bool isItemPurchased(string id)
    {
        return _persistentData.PlayerData.ItemIsOpen(id);
    }
}
