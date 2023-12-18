using UnityEngine;
using Zenject;

public class Wallet
{
    private CurrencyController _ticketController;

    [Inject]
    private void Construct(CurrencyController ctrl)
    {
        _ticketController = ctrl;
    }

    public void AddTickets(int plusAmount)
    {
        _ticketController.AddCurrency(plusAmount);
    }

    public bool TryRemoveTickets(int minusAmount)
    {
        return _ticketController.TryRemoveCurrency(minusAmount);
    }

    public bool IsEnough(int minusAmount) 
    {
        return _ticketController.IsEnough(minusAmount);
    }
}
