using TMPro;
using UnityEngine;

public class ShopCategoryView : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _label;
    public void SetLabel(string s) 
    {
        _label.text = s;
    }
}
