using UnityEngine;
using Zenject;

public class ShopFabricsInstaller : MonoInstaller
{
    [SerializeField] private ShopBuyButtonFabric _buttons;
    [SerializeField] private ShopItemViewFabric _shopItemViews;
    [SerializeField] private ShopCategoryViewFabric _shopCategories;

    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<ShopBuyButtonFabric>().FromInstance(_buttons).AsSingle();
        Container.BindInterfacesAndSelfTo<ShopItemViewFabric>().FromInstance(_shopItemViews).AsSingle();
        Container.BindInterfacesAndSelfTo<ShopCategoryViewFabric>().FromInstance(_shopCategories).AsSingle();
    }
}