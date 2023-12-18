using UnityEngine;
[CreateAssetMenu(fileName = "TicketBuyButtonConfig", menuName = "Shop/ButtonConfig/TicketBuyButtonConfig")]
public class TicketBuyButtonConfig : BaseBuyButtonConfig
{
    [SerializeField] protected string _spriteName;
    [SerializeField, Min(0)] private int _price;
    public int Price => _price;

    public override string ButtonText => $"{_spriteName} {_price}";
}
