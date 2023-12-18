
using System.Linq;

public class PurchasedShopItemChecker : IShopInfoVisitor
{
    private IPersistentData _persistentData;

    public bool IsPurchased { get; private set; }

    public PurchasedShopItemChecker (IPersistentData persistentData)
    {
        _persistentData = persistentData;
    }

    public void Visit(ShopItemInfo info)
    {
        Visit((dynamic)info);
    }

    public void Visit(ConsumableShopItemInfo info)
    {
        IsPurchased = false;
    }

    public void Visit(NonconsumableShopItemInfo info)
    {
        _persistentData.PlayerData.OpenItemIDs.Contains(info.Item.ID);
    }
}
