using System;
using TMPro;
using UnityEngine;
//using Zenject;

public class CurrencyBuyButton : BaseBuyButton
{
    [SerializeField] private TextMeshProUGUI _currencyText;

    private int _price;
    public int Price => _price;
    //private Wallet _wallet;

    //[Inject]
    //private void Construct(Wallet w)
    //{
    //    _wallet = w;
    //}
    public override void Init(BaseBuyButtonConfig config, bool isPurchased)
    {
        TogglePurchasedState(isPurchased);
        _price = ((TicketBuyButtonConfig)config).Price;
        SetText(config.ButtonText);
    }

    public override void SetText(string text)
    {
        _currencyText.text = text;
    }

    protected override void OnClick()
    {
        ClickEvent?.Invoke(this);
        //if (_wallet.IsEnough(_price) == false) return;

        //_wallet.TryRemoveTickets(_price);

        //_shop.BuyButtonClicked(this);
    }
}
