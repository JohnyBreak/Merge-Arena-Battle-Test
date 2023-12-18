using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ShopScreen : BaseScreen
{
    [SerializeField] private ShopItemsList _shopItemList;
    private ShopCategoryViewFabric _shopCategoryViewFabric;
    private ShopItemViewFabric _shopItemViewFabric;
    [SerializeField] private Transform _spawnT;

    [Inject]
    private void Construct(ShopItemViewFabric shopItem, ShopCategoryViewFabric shopCategories)
    {
        _shopCategoryViewFabric = shopCategories;
        _shopItemViewFabric = shopItem;
    }

    private IEnumerator Start()
    {
        Transform tempSpawnT;

        foreach (var categoryI in _shopItemList.ShopCategories)
        {
            var category = _shopCategoryViewFabric.Get(_spawnT, categoryI.Name);
            tempSpawnT = category.transform;
            foreach (var info in categoryI.ShopItemInfos)
            {
                _shopItemViewFabric.Get(tempSpawnT, info);
            }
        }
        yield return null;
        LayoutRebuilder.ForceRebuildLayoutImmediate(_spawnT.GetComponent<RectTransform>());
    }
}
