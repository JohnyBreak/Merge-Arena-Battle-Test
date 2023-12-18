
using UnityEngine;

public abstract class BaseScreen : MonoBehaviour
{
    public void Close() 
    {
        base.gameObject.SetActive(false);
    }
}
