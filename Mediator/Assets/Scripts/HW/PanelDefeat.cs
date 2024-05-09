using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelDefeat : MonoBehaviour
{
    [SerializeField] private Button _restartBtn;

    public event Action OnClickRestartBtn;

    private void OnEnable()
    {
        _restartBtn.onClick.AddListener(OnClickBtn);
    }

    private void OnDisable()
    {
        _restartBtn?.onClick.RemoveListener(OnClickBtn);
    }

    public void OnClickBtn()
    {
        OnClickRestartBtn?.Invoke();
    }

    public void ShowPanel() => gameObject.SetActive(true);

    public void HidePanel() => gameObject.SetActive(false);
}


