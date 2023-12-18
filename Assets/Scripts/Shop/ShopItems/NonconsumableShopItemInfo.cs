using UnityEngine;
[CreateAssetMenu(fileName = "NonconsumableShopItemInfo", menuName = "Shop/ShopItems/NonconsumableShopItemInfo")]
public class NonconsumableShopItemInfo : ShopItemInfo
{
    [SerializeField] private Item _item;
    public Item Item => _item;

    public override bool IsPurchased()
    {
        return _shopItemService.isItemPurchased(_item.ID);
    }
}
