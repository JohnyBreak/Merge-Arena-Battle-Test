
public interface IShopInfoVisitor 
{
    public void Visit(ShopItemInfo info);
    public void Visit(ConsumableShopItemInfo info);
    public void Visit(NonconsumableShopItemInfo info);
}
