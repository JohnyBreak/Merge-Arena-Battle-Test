public class MusicButton : BaseToggleButton
{
    protected override void Awake()
    {
        base.Awake();
        _active = _save.ShouldPlayMusic();
    }

    protected override void OnClick()
    {
        _active = !_active;

        _save.SaveMusicState(_active);

        StateChangedEvent?.Invoke(_active);
    }
}
