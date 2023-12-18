public class SoundButton : BaseToggleButton
{
    protected override void Awake()
    {
        base.Awake();
        _active = _save.ShouldPlayButtonSound();
    }

    protected override void OnClick()
    {
        _active = !_active;

        _save.SaveButtonSoundState(_active);

        StateChangedEvent?.Invoke(_active);
    }
}
