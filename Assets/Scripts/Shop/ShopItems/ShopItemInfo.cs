using UnityEngine;
using Zenject;

public abstract class ShopItemInfo : ScriptableObject
{
    [SerializeField] protected string _name;
    [SerializeField] protected Sprite _icon;
    [SerializeField] protected ShopAssets _asset;
    protected ShopItemService _shopItemService;
    public Sprite Icon => _icon;
    public string Name => _name;
    public ShopAssets Asset => _asset;
    public abstract bool IsPurchased();

    public Sprite BackGround;
    public BaseBuyButtonConfig ButtonConfig;

    [Inject]
    private void Construct(ShopItemService shopItemService) 
    {
        _shopItemService = shopItemService;
    }
}