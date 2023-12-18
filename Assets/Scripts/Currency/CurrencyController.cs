using Zenject;

public class CurrencyController
{
    private CurrencyView _view;
    private CurrencyModel _model;

    private IPersistentData _persistentData;
    private IDataProvider _dataProvider;
    [Inject]
    private void Construct(CurrencyView view, IPersistentData persistentData, IDataProvider dataProvider)
    {
        _view = view; 
        _persistentData = persistentData;
        _dataProvider = dataProvider;
        _model = new(_persistentData.PlayerData.Tickets);
        UpdateCurrencyText();
    }

    public void AddCurrency(int plusAmount) 
    {
        _model.CurrencyAmount += plusAmount;

        _persistentData.PlayerData.Tickets = _model.CurrencyAmount;
        _dataProvider.Save();
        UpdateCurrencyText();
    }

    public bool TryRemoveCurrency(int minusAmount)
    {
        if ((_model.CurrencyAmount - minusAmount) < 0) return false;

        _model.CurrencyAmount -= minusAmount;
        _persistentData.PlayerData.Tickets = _model.CurrencyAmount;
        _dataProvider.Save();
        UpdateCurrencyText();
        return true;
    }

    public bool IsEnough(int minusAmount)
    {
        return ((_model.CurrencyAmount - minusAmount) >= 0);
    }

    private void UpdateCurrencyText() 
    {
        _view.SetCurrencyText(_model.CurrencyAmount.ToString());
    }

    
}
