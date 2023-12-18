using UnityEngine;
using UnityEngine.AddressableAssets;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private Transform _canvasT;
    [SerializeField] private AssetReferenceGameObject _settingsScreen;
    //[SerializeField] private SettingsScreen _settingsScreen;
    //[SerializeField] private ShopScreen _shopScreen;
    //[SerializeField] private DailyRevardScreen _dailyScreen;
    //[SerializeField] private LevelsScreen _levelsScreen;
    [SerializeField] private AssetReferenceGameObject _shopScreen;
    [SerializeField] private AssetReferenceGameObject _dailyScreen;
    [SerializeField] private AssetReferenceGameObject _levelsScreen;

    private BaseScreen _activeScreen;
    private ScreenLoader _assetLoader;

    private void Awake()
    {
        _assetLoader = new();
        //OpenScreen(_settingsScreen);
    }

    public async void OpenScreen(AssetReferenceGameObject screen) 
    {
        _activeScreen = await _assetLoader.InstantiateAsync(screen, _canvasT);

        //_activeScreen = screen;
        _activeScreen.gameObject.SetActive(true);
    }

    public void OpenSettings() 
    {
        OpenScreen(_settingsScreen);
        //_activeScreen = _settingsScreen;
        //_activeScreen.gameObject.SetActive(true);
    }

    public void OpenShop()
    {
        OpenScreen(_shopScreen);
        //_activeScreen = _shopScreen;
        //_activeScreen.gameObject.SetActive(true);
    }

    public void OpenDaily()
    {
        OpenScreen(_dailyScreen);
        //_activeScreen = _dailyScreen;
        //_activeScreen.gameObject.SetActive(true);
    }

    public void OpenLevels()
    {
        OpenScreen(_levelsScreen);
        //_activeScreen = _levelsScreen;
        //_activeScreen.gameObject.SetActive(true);
    }

    public void BackToMainScreen() 
    {
        _activeScreen.Close();

        _assetLoader.Unload();
        
        //close active screen
        // open main screen // maybe always active
    }
}
