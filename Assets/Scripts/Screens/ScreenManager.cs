using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private SettingsScreen _settingsScreen;
    [SerializeField] private ShopScreen _shopScreen;
    [SerializeField] private DailyRevardScreen _dailyScreen;
    [SerializeField] private LevelsScreen _levelsScreen;

    private BaseScreen _activeScreen;

    private void Awake()
    {
        //OpenScreen(_settingsScreen);
    }

    public void OpenScreen(BaseScreen screen) 
    {
        _activeScreen = screen;
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
        //close active screen
        // open main screen // maybe always active
    }
}
