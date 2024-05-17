using UnityEngine;
using Zenject;

public class Mediator : MonoBehaviour
{
    private DefeatPanel _panel;
    private Level _level;

    private void OnDisable()
    {
        _level.Defeat -= OnLevelDefeat;
    }

    [Inject]
    private void Construct (Level level, DefeatPanel defeatPanel)
    {
        _level = level;
        _panel = defeatPanel;
        _level.Defeat += OnLevelDefeat;
    }

    public void RestartLevel()
    {
        _panel.HidePanel();
        _level.Restart();
    }
    
    private void OnLevelDefeat()
    {
        _panel.ShowPanel();
    }


}
