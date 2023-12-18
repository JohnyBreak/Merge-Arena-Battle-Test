using UnityEngine;

[CreateAssetMenu(fileName = "ShopCategoryViewFabric", menuName = "Fabrics/ShopCategoryViewFabric")]
public class ShopCategoryViewFabric : ScriptableObject
{
    [SerializeField] private ShopCategoryView _shopCategoryPrefab;

    public ShopCategoryView Get(Transform spawnT, string name) 
    {
        var category = Instantiate(_shopCategoryPrefab, spawnT);
        category.SetLabel(name);
        return category;
    }
}
