using Zenject;

public class WalletInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Wallet>().FromNew().AsSingle().NonLazy();
    }
}
