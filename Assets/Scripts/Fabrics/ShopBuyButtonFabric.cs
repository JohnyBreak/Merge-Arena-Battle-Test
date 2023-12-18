using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopBuyButtonFabric", menuName = "Fabrics/ShopBuyButtonFabric")]
public class ShopBuyButtonFabric : ScriptableObject
{
    [SerializeField] private BaseBuyButton _ticketBuyButtonPrefab;
    [SerializeField] private BaseBuyButton _iapBuyButtonPrefab;

    public BaseBuyButton Get(Transform spawnT, BaseBuyButtonConfig config, bool purchased)
    {
        BaseBuyButton button;

        ShopBuyButtonVisitor visitor = new(_ticketBuyButtonPrefab, _iapBuyButtonPrefab);
        visitor.Visit(config);

        button = Instantiate(visitor.Prefab, spawnT);
        button.Init(config, purchased);
        return button;
    }

    private class ShopBuyButtonVisitor : IShopBuyButtonVisitor
    {
        private BaseBuyButton _ticketBuyButtonPrefab;
        private BaseBuyButton _iapBuyButtonPrefab;

        public ShopBuyButtonVisitor(BaseBuyButton ticketBuyButtonPrefab, BaseBuyButton iapBuyButtonPrefab)
        {
            _ticketBuyButtonPrefab = ticketBuyButtonPrefab;
            _iapBuyButtonPrefab = iapBuyButtonPrefab;
        }

        public BaseBuyButton Prefab { get; private set; }

        public void Visit(BaseBuyButtonConfig config)
        {
            Visit((dynamic)config);
        }

        public void Visit(TicketBuyButtonConfig config)
        {
            Prefab = _ticketBuyButtonPrefab;
        }

        public void Visit(IAPBuyButtonConfig config)
        {
            Prefab = _iapBuyButtonPrefab;
        }
    }
}