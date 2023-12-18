
using UnityEngine;
using Zenject;

public class AssetSpawner : MonoBehaviour
{
    [SerializeField] private ItemDB _itemDB;

    private IPersistentData _data;

    [Inject]
    private void Construct(IPersistentData data)
    {
        _data = data;
    }

    // Start is called before the first frame update
    void Start()
    {
        var id = _data.PlayerData.SelectedSkinID;

        var item = _itemDB.GetItemByID(id);
        ItemAssetGetter visitor = new();
        
        visitor.Visit(item);

        var asset = visitor.Asset;

        Instantiate(asset, Vector3.zero, Quaternion.identity);
    }

    private class ItemAssetGetter
    {
        public GameObject Asset {get; private set;}

        public void Visit(Item item) 
        {
            Visit((dynamic)item);
        }

        public void Visit(SkinItem item)
        {
            Asset = item.Skin;
        }

        public void Visit(CharacterSkin item)
        {
            Asset = item.Skin;
        }
    }
}
