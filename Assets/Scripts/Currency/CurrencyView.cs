using UnityEngine;
using TMPro;
public class CurrencyView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void SetCurrencyText(string text) 
    {
        _text.text = text;
    }
}
