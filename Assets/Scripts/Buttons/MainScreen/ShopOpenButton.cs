using Zenject;

public class ShopOpenButton : BaseScreenOpenButton
{
    protected override void OnClick()
    {
        _screenManager.OpenShop();
    }
}
