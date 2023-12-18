using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemInfoDB", menuName = "Shop/ItemInfoDB")]
public class ItemInfoDB : ScriptableObject
{
    [SerializeField] private List<ConsumableShopItemInfo> _consumableItems;
    [SerializeField] private List<NonconsumableShopItemInfo> _nonconsumableItems;

    public List<ConsumableShopItemInfo> ConsumableItems => _consumableItems;
    public List<NonconsumableShopItemInfo> NonconsumableItems => _nonconsumableItems;

    private void OnValidate()
    {
        var itemShopAssetDuplicates = _nonconsumableItems.GroupBy(item => item.Asset)
            .Where(array => array.Count() > 1);

        if (itemShopAssetDuplicates.Count() > 0)
            throw new InvalidOperationException(nameof(_nonconsumableItems));

    }
}

