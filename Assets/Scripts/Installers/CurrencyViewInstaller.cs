using UnityEngine;
using Zenject;

public class CurrencyViewInstaller : MonoInstaller
{
    [SerializeField] private CurrencyView _instance;

    public override void InstallBindings()
    {
        Container.Bind<CurrencyView>().FromInstance(_instance).AsSingle().NonLazy();
    }
}
