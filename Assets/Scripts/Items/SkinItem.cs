using UnityEngine;

public abstract class SkinItem : Item
{
    [SerializeField] private GameObject _skin;
    public  GameObject Skin => _skin;
}
