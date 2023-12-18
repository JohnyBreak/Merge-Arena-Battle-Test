
public interface IShopBuyButtonVisitor 
{
    public void Visit(BaseBuyButtonConfig config);
    public void Visit(TicketBuyButtonConfig config);
    public void Visit(IAPBuyButtonConfig config);
}
