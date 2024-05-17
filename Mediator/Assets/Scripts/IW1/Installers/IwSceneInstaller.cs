using UnityEngine;
using Zenject;

public class IwSceneInstaller : MonoInstaller
{
    [SerializeField] private DefeatPanel _defeatPanel;
    [SerializeField] private Mediator _mediator;

    public override void InstallBindings()
    {
        BindLevel();
        BindMediator();
        BindDefeatPanel();
    }

    private void BindLevel()
    {
        Container.BindInterfacesAndSelfTo<Level>().AsSingle();
    }

    private void BindMediator()
    {
        Container.Bind<Mediator>().FromInstance(_mediator).AsSingle();
    }

    private void BindDefeatPanel()
    {
        Container.Bind<DefeatPanel>().FromInstance(_defeatPanel).AsSingle();
    }




}
