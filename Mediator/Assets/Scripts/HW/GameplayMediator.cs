using UnityEngine;

public class GameplayMediator : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PanelDefeat _defeatPanel;

    public void OnEnable()
    {
        _player.Dead += OnPlayerDead;
        _defeatPanel.OnClickRestartBtn += Restart;
    }

    public void OnDisable()
    {
        _player.Dead -= OnPlayerDead;
        _defeatPanel.OnClickRestartBtn -= Restart;
    }

    public void Restart()
    {
        _player.Reborn();
        _defeatPanel.HidePanel();
    }

    private void OnPlayerDead()
    {
        _defeatPanel.ShowPanel();
    }
}
