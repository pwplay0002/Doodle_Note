using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScreen : MonoBehaviour
{
    [SerializeField]
    private Image _fadeImage;

    [SerializeField]
    private float _fadeTime;

    private bool _isFading;

    void Start()
    {      
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Awake()
    {
        _fadeImage.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);

        UIManager.p_UIManager.SetFadeScreen(this);

        _fadeImage = GetComponent<Image>();
        _isFading = false;

        Fade(1, 0);
    }

    public void Fade(float start, float end)
    {
        if (!_isFading)
        {
            _isFading = true;
            StartCoroutine(FadeCoroutine(start, end));
        }
    }

    private IEnumerator FadeCoroutine(float start, float end)
    {
        float currentTime = 0.0f;
        float fadeAlpha = 0.0f;

        while (fadeAlpha < 1)
        {
            currentTime += Time.deltaTime;
            fadeAlpha = currentTime / _fadeTime;

            Color color = _fadeImage.color;
            color.a = Mathf.Lerp(start, end, fadeAlpha);
            _fadeImage.color = color;

            yield return null;
        }

        _isFading = false;
    }

    public bool IsFading()
    {
        return _isFading;
    }
}
