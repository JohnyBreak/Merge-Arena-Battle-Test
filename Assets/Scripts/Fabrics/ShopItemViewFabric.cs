using UnityEngine;

[CreateAssetMenu(fileName = "ShopItemViewFabric", menuName = "Fabrics/ShopItemViewFabric")]
public class ShopItemViewFabric : ScriptableObject
{
    [SerializeField] private ShopItemView _shopItemPrefab;

    public ShopItemView Get(Transform spawnT, ShopItemInfo info)
    {
        var item = Instantiate(_shopItemPrefab, spawnT);
        item.Init(info);

        return item;
    }


}
