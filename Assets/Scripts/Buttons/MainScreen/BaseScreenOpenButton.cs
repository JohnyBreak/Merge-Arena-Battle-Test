using Zenject;

public abstract class BaseScreenOpenButton : BaseUIButton
{
    protected ScreenManager _screenManager;

    [Inject]
    protected void Construct(ScreenManager manager)
    {
        _screenManager = manager;
    }
}
