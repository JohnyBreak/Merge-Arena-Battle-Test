
public class BackToMainScreenButton : BaseScreenOpenButton
{
    protected override void OnClick()
    {
        _screenManager.BackToMainScreen();
    }
}
