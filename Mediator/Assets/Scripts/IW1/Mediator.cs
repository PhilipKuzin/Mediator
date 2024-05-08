using UnityEngine;

public class Mediator : MonoBehaviour
{
    [SerializeField] private DefeatPanel _panel;

    private Level _level;

    private void OnDestroy()
    {
        _level.Defeat -= OnLevelDefeat;
    }

    public void Initialize(Level level)
    {
        _level = level;
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
