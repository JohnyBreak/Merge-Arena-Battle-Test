using Zenject;

public class PersistentDataInstaller : MonoInstaller
{
    private IPersistentData _persistantData;

    public override void InstallBindings()
    {
        _persistantData = new PersistentData();

        IDataProvider provider = new DataLocalProvider(_persistantData);

        if(provider.TryLoad() == false) _persistantData.PlayerData = new PlayerData();

        Container.Bind<IPersistentData>().FromInstance(_persistantData).AsSingle().NonLazy();
        Container.Bind<IDataProvider>().FromInstance(provider).AsSingle().NonLazy();
    }
}
