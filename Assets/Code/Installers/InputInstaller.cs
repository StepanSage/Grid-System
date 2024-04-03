using Code.Grid;
using Code.Service;
using Zenject;
public class InputInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<ILisener>()
            .FromComponentInHierarchy()
            .AsSingle()
            .NonLazy();
 
    }
}
