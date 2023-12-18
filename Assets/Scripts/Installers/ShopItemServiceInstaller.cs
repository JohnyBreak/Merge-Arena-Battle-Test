using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ShopItemServiceInstaller : MonoInstaller
{
    [SerializeField] private List<ShopItemInfo> _soList;

    public override void InstallBindings()
    {
        Container.Bind<ShopItemService>().FromNew().AsSingle().NonLazy();

        foreach (var scriptableObject in _soList)
        {
            Container.QueueForInject(scriptableObject);
        }
    }
}
