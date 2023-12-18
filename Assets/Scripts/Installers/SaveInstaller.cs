using Zenject;

public class SaveInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Save>().FromNew().AsSingle().NonLazy();
    }
}
