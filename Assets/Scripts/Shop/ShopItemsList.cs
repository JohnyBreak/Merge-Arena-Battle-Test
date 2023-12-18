using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
[CreateAssetMenu(fileName = "ShopItemsList", menuName = "Shop/ShopItemsList")]
public class ShopItemsList : ScriptableObject
{
    public List<ShopCategory> ShopCategories;

    private void OnValidate()
    {
        foreach (ShopCategory category in ShopCategories) 
        {
            if(category.ShopItemInfos.Count < 1) continue;

            if (category.ShopItemInfos[0] is NonconsumableShopItemInfo) 
            {
                var itemShopAssetDuplicates = category.ShopItemInfos.GroupBy(item => item.Asset)
            .Where(array => array.Count() > 1);

                if (itemShopAssetDuplicates.Count() > 0)
                    throw new InvalidOperationException(nameof(ShopCategories));
            }
        }
    }
}

[Serializable]
public class ShopCategory 
{
    public string Name;
    //[SerializeField] private ShopItemInfo[] _shopItemInfos;

    public List<ShopItemInfo> ShopItemInfos;// => _shopItemInfos;
}