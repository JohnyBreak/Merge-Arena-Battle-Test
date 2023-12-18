
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class LevelsScreen : BaseScreen
{
    [SerializeField] private SkinItemView _skinItemViewPrefab;
    [SerializeField] private Transform _spawnT;
    [SerializeField] private ItemDB _itemDB;

    private IPersistentData _data;
    private IDataProvider _dataProvider;

    [Inject]
    private void Construct(IPersistentData data, IDataProvider dataProvider) 
    {
        _data = data;
        _dataProvider = dataProvider;
    }

    private void OnEnable()
    {
        while (_spawnT.childCount > 0)
        {
            DestroyImmediate(_spawnT.GetChild(0).gameObject);
        }

        foreach (var item in _data.PlayerData.OpenItemIDs) 
        {
            var view = Instantiate(_skinItemViewPrefab, _spawnT);
            view.Init(this, _itemDB.GetItemByID(item));
        }
    }

    public void OnItemClick(string id) 
    {
        _data.PlayerData.SelectedSkinID = id;
        _dataProvider.Save();
        SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single);
    }
}
