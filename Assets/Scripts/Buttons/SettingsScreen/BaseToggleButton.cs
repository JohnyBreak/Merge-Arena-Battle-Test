using System;
using Zenject;

public abstract class BaseToggleButton : BaseUIButton
{
    public Action<bool> StateChangedEvent;

    protected bool _active;
    protected Save _save;

    [Inject]
    protected void Construct(Save save)
    {
        _save = save;
    }
}
