using UnityEngine;
using Zenject;

public class ScreenManagerInstaller : MonoInstaller
{
    [SerializeField] private ScreenManager _instance;

    public override void InstallBindings()
    {
        Container.Bind<ScreenManager>().FromInstance(_instance).AsSingle().NonLazy();
    }
}
