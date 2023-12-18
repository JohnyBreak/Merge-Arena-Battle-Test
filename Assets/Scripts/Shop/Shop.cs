
using Zenject;

public class Shop
{
    private Wallet _wallet;
    private IDataProvider _dataLocalProvider;
    private IPersistentData _persistentData;

    [Inject]
    private void Construct(Wallet wallet, IPersistentData persistentData, IDataProvider dataLocalProvider)
    {
        _wallet = wallet;
        _persistentData = persistentData;
        _dataLocalProvider = dataLocalProvider;
    }

    public void OnBuyButtonClicked(ShopItemInfo shopItemInfo, BaseBuyButton buyButton)
    {
        ShopBuyButtonClickVisitor visitor = new ShopBuyButtonClickVisitor(_wallet, shopItemInfo,_persistentData);

        visitor.Visit(buyButton);

        _dataLocalProvider.Save();
    }

    private class ShopBuyButtonClickVisitor : IShopBuyButtonClickVisitor
    {
        private Wallet _wallet;
        private IPersistentData _persistentData;
        private ShopItemInfo _shopItemInfo;

        public ShopBuyButtonClickVisitor(Wallet wallet, ShopItemInfo shopItemInfo, IPersistentData persistentData)
        {
            _wallet = wallet;
            _shopItemInfo = shopItemInfo;
            _persistentData = persistentData;
        }
        public void Visit(BaseBuyButton button)
        {
            Visit((dynamic)button);
        }

        public void Visit(CurrencyBuyButton button)
        {
            if (_wallet.IsEnough(button.Price) == false) return;

            IShopInfoVisitor visitor = new ShopItemUnlocker(_persistentData);

            visitor.Visit(_shopItemInfo);

            _wallet.TryRemoveTickets(button.Price);

            button.Purchase();
        }

        public void Visit(IAPBuyButton button)
        {
        }

        private class ShopItemUnlocker : IShopInfoVisitor
        {
            private IPersistentData _persistentData;

            public ShopItemUnlocker(IPersistentData persistentData) 
            {
                _persistentData = persistentData;
            }

            public void Visit(ShopItemInfo info)
            {
                Visit((dynamic)info);
            }

            public void Visit(ConsumableShopItemInfo info)
            {
                throw new System.NotImplementedException();
            }

            public void Visit(NonconsumableShopItemInfo info)
            {
                _persistentData.PlayerData.OpenItem(info.Item.ID);
            }
        }
    }

}
