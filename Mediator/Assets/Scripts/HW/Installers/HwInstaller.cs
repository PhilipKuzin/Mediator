using System;
using UnityEngine;
using Zenject;

public class HwInstaller : MonoInstaller
{
    [SerializeField] private PanelDefeat panelDefeat;
    [SerializeField] private PlayerPanel playerPanel;
    [SerializeField] private Player player;
    public override void InstallBindings()
    {
        BindPlayer();
        BindGameplayMediator();
        BindPlayerMediator();
    }

    private void BindPlayer()
    {
        Container.Bind<Player>().FromInstance(player).AsSingle();
    }

    private void BindPlayerMediator()
    {
        Container.Bind<PlayerPanel>().FromInstance(playerPanel).AsSingle();
    }

    private void BindGameplayMediator()
    {
        Container.Bind<PanelDefeat>().FromInstance(panelDefeat).AsSingle();
    }
}
