using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(UnityEngine.UI.Button))]
public abstract class BaseUIButton : MonoBehaviour
{
    protected Button _button;

    protected virtual void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    protected void OnDestroy()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    protected abstract void OnClick();
}
