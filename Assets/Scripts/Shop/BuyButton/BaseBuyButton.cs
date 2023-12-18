
using UnityEngine;
//using Zenject;

public abstract class BaseBuyButton : BaseUIButton
{
    public System.Action<BaseBuyButton> ClickEvent;
    [SerializeField] private GameObject _purchasedHolder;
    //protected Shop _shop;

    //[Inject]
    //private void Construct(Shop shop)
    //{
    //    _shop = shop;
    //}

    public abstract void SetText(string text);
    public abstract void Init(BaseBuyButtonConfig config, bool isPurchased);

    protected void TogglePurchasedState(bool purchased) 
    {
        _button.interactable = !purchased;
        _purchasedHolder.SetActive(purchased);
    }

    public void Purchase() 
    {
        _button.interactable = false;
        _purchasedHolder.SetActive(true);
    }
}
