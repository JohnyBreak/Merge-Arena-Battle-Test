using TMPro;
using UnityEngine;

public class IAPBuyButton : BaseBuyButton
{
    [SerializeField] private TextMeshProUGUI _priceText;
    private string _code;
    public string Code => _code;

    public override void Init(BaseBuyButtonConfig config, bool isPurchased)
    {
        TogglePurchasedState(isPurchased);

        _code = ((IAPBuyButtonConfig)config).IAPCode;
        SetText(config.ButtonText);
    }

    public override void SetText(string text)
    {
        _priceText.text = text;
    }

    protected override void OnClick()
    {
        ClickEvent?.Invoke(this);
    }

}
