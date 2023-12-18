public class DailyRevardOpenButton : BaseScreenOpenButton
{
    protected override void OnClick()
    {
        _screenManager.OpenDaily();
    }
}
