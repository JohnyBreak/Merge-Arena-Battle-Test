using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ButtonSoundPlayerInstaller : MonoInstaller
{
    [SerializeField] private ButtonSoundPlayer _soundPlayer;

    public override void InstallBindings()
    {
        Container.Bind<ButtonSoundPlayer>().FromInstance(_soundPlayer).AsSingle().NonLazy();
    }
}
