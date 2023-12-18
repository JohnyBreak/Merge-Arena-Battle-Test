public class SettingsOpenButton : BaseScreenOpenButton
{
    protected override void OnClick()
    {
        _screenManager.OpenSettings();
    }
}
