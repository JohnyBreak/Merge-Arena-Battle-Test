using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinItemView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _nameText;
    private Button _button;
    private LevelsScreen _screen;
    private Item _item;

    void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    public void Init(LevelsScreen screen, Item item) 
    {
        _screen = screen; 
        _item = item;
        _nameText.text = item.Name;
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    private void OnClick() 
    {
        _screen.OnItemClick(_item.ID);
    }
}
