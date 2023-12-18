using Zenject;

public class ShopInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Shop>().FromNew().AsSingle().NonLazy();
    }
}
