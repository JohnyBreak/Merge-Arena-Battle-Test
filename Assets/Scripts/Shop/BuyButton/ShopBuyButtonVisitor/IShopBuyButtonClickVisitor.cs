
public interface IShopBuyButtonClickVisitor
{
    public void Visit(BaseBuyButton config);
    public void Visit(CurrencyBuyButton config);
    public void Visit(IAPBuyButton config);
}
