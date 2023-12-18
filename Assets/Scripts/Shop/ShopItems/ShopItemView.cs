using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ShopItemView : MonoBehaviour
{
    [SerializeField] private Image _backGround;
    [SerializeField] private Image _icon;
    [SerializeField] private TextMeshProUGUI _titleText;
    [SerializeField] private Transform _buttonHolder;
    [SerializeField] private GameObject _currencyObject;
    [SerializeField] private Image _currencyIcon;
    [SerializeField] private TextMeshProUGUI _currencyText;
    private ShopBuyButtonFabric _buttonFabric;
    private Shop _shop;
    protected ShopItemInfo _info;

    [Inject]
    private void Construct(ShopBuyButtonFabric fabric, Shop shop)
    {
        _buttonFabric = fabric;
        _shop = shop;
    }

    public void Init(ShopItemInfo info) 
    {
        _info = info;
        _currencyObject.SetActive(false);
        _icon.sprite = info.Icon;
        _titleText.text = info.Name;

        var b = _buttonFabric.Get(_buttonHolder, info.ButtonConfig, info.IsPurchased());
        
        b.ClickEvent += OnClick;

        if (info is ConsumableShopItemInfo) 
        {
            _currencyIcon.sprite = ((ConsumableShopItemInfo)info).ConsumableIcon;
             _currencyText.text = ((ConsumableShopItemInfo)info).ConsumableAmount.ToString();
            _currencyObject.SetActive(true);
        }
    }

    private void OnClick(BaseBuyButton button) 
    {
        _shop.OnBuyButtonClicked(_info, button);
    }

}