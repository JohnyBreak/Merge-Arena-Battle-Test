using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemDB", menuName = "Items/ItemDB")]
public class ItemDB : ScriptableObject
{
    [SerializeField] private List<Item> _items;

    public List<Item> Items => _items;

    //private void OnValidate()
    //{
    //    var itemShopAssetDuplicates = _items.GroupBy(item => item.ID)
    //        .Where(array => array.Count() > 1);

    //    if (itemShopAssetDuplicates.Count() > 0)
    //        throw new InvalidOperationException(nameof(_items));

    //}

    public Item GetItemByID(string id) 
    {
        return _items.Single(i => i.ID == id);
    }
}
