using UnityEngine;
using UnityEngine.UI;

public class DefeatPanel : MonoBehaviour
{
    [SerializeField] private Button _restartBtn;

    private Mediator _mediator;

    private void OnEnable()
    {
        _restartBtn.onClick.AddListener(OnRestartClick);
    }

    private void OnDisable()
    {
        _restartBtn?.onClick.RemoveListener(OnRestartClick);
    }

    public void Initialize(Mediator mediator)
    {
        _mediator = mediator;
    }

    public void ShowPanel() => gameObject.SetActive(true);

    public void HidePanel() => gameObject.SetActive(false);

    private void OnRestartClick()
    {
        _mediator.RestartLevel();
    }

}
