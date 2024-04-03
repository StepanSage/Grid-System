using UnityEngine;
using Zenject;

public class CompareAnwerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<ComparCollider>()
            .FromComponentInHierarchy()
            .AsSingle();
            
        
           
    }
}