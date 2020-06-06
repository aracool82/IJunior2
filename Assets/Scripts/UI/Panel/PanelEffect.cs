using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]

public class PanelEffect : MonoBehaviour
{
    [SerializeField] private Button _buttonAutor;
    private bool _isVisible;
    private CanvasGroup _canvasGroup;

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 0f;
        _isVisible = false;
        _canvasGroup.blocksRaycasts = false;
    }

    public void StartEffect()
    {
        _buttonAutor.interactable = false;
        StartCoroutine(Effect(_isVisible));
        _isVisible = !_isVisible;
    }

    public IEnumerator Effect (bool isVisible)
    {
        var addAlpha = 0.1f;
        if (isVisible)
            addAlpha= -0.1f;

        while (true)
        {
            _canvasGroup.alpha += addAlpha;
            if (_canvasGroup.alpha == 1 || _canvasGroup.alpha == 0)
                break;
            yield return null;
        }

        _buttonAutor.interactable = true;

        if (_canvasGroup.alpha == 1)
            _canvasGroup.blocksRaycasts = true;
        else
            _canvasGroup.blocksRaycasts = false;
    }
}
