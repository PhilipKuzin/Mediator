using UnityEngine;

public class PlayerMediator : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerPanel _playerPanel;

    private void OnEnable()
    {
        _player.OnHealthChanged += ChangeHealthView;
        _player.OnLevelChanged += ChangeLevelView;
        _player.OnPlayerReborn += ResetView;
    }

    private void OnDisable()
    {
        _player.OnHealthChanged -= ChangeHealthView;
        _player.OnLevelChanged -= ChangeLevelView;
        _player.OnPlayerReborn -= ResetView;
    }

    private void ResetView()
    {
        _playerPanel.ResetView(_player.MaxHealth, _player.StartLevel);
    }

    private void ChangeLevelView()
    {
        _playerPanel.ViewChangedLevel(_player.CurrentLevel);
    }

    private void ChangeHealthView()
    {
        _playerPanel.ViewChangedHealth(_player.CurrentHealth);
    }
}
