using UnityEngine;
using Zenject;

public class RandomIDCellIlnstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
         .Bind<GetRandomIdCell>()
         .FromComponentInHierarchy()
         .AsSingle();
    }
}