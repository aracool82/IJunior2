using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]

public class EffectFadeIn : MonoBehaviour
{
    private CanvasGroup _canvasGroup;

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    public void StartFadeIn()
    {
        _canvasGroup.blocksRaycasts = false;
        StartCoroutine(FadeIn());
    }

    public IEnumerator FadeIn( )
    {
        while (_canvasGroup.alpha <= 1f)
        {
            _canvasGroup.alpha += 0.1f;
            if (_canvasGroup.alpha == 1f)
                break;
            yield return null;
        }
        _canvasGroup.blocksRaycasts = true;
    }
}
