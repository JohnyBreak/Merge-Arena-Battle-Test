using UnityEngine;

[CreateAssetMenu(fileName = "IAPBuyButtonConfig", menuName = "Shop/ButtonConfig/IAPBuyButtonConfig")]
public class IAPBuyButtonConfig : BaseBuyButtonConfig
{
    [SerializeField] private string _buttonText;
    [SerializeField] private string _iAPCode;
    public string IAPCode => _iAPCode;

    public override string ButtonText => _buttonText;
}
