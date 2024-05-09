using UnityEngine;
using TMPro;

public class PlayerPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthView;
    [SerializeField] private TMP_Text _levelView;

    public void ViewChangedHealth(int health)
    {
        _healthView.text = health.ToString();
    }

    public void ViewChangedLevel(int level)
    {
        _levelView.text = level.ToString();
    }

    public void ResetView(int health, int level)
    {
        _healthView.text = health.ToString();
        _levelView.text = level.ToString();
    }
}
