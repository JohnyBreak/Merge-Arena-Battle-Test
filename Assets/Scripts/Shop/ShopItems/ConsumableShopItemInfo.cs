using UnityEngine;

[CreateAssetMenu(fileName = "ConsumableShopItemInfo", menuName = "Shop/ShopItems/ConsumableShopItemInfo")]
public class ConsumableShopItemInfo : ShopItemInfo
{
    [SerializeField, Min(0)] protected int _consumableAmount;
    [SerializeField] protected Sprite _consumableIcon;

    public int ConsumableAmount => _consumableAmount;
    public Sprite ConsumableIcon => _consumableIcon;

    public override bool IsPurchased()
    {
        return false;
    }
}
