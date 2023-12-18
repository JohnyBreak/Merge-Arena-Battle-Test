using Zenject;

public class CurrencyControllerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<CurrencyController>().FromNew().AsSingle().NonLazy();
    }
}
