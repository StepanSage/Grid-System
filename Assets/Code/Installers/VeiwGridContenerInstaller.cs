using Code.Grid;
using UnityEngine;
using Zenject;

public class VeiwGridContenerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<ViewGridContener>()
            .FromComponentInHierarchy()
            .AsSingle()
            .NonLazy();
             
    }
}