using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private FadeScreen _FadeScreen;

    [SerializeField]
    private Canvas _canvas;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.sceneLoaded += LoadedsceneEvent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (_UIManager == null)
        {
            _UIManager = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        //DontDestroyOnLoad(_canvas);
        /*
        if (_FadeScreen != null)
        {
            Debug.Log("FamdeImage no des");
            DontDestroyOnLoad(_FadeScreen.gameObject);
        }
        */
    }
    private void LoadedsceneEvent(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("FadeIn");
        ScreenFadeIn();
    }

    public void ScreenFadeIn()
    {
        _FadeScreen.Fade(1.0f, 0.0f);
    }

    public void ScreenFadeOut()
    {
        _FadeScreen.Fade(0.0f, 1.0f);      
    }

    public bool IsFading()
    {
        return _FadeScreen.IsFading();
    }

    public void SetFadeScreen(FadeScreen fadescreen)
    {
        _FadeScreen = fadescreen;
    }

    public static UIManager p_UIManager
    {
        get
        {
            if (_UIManager == null)
            {
                return null;
            }
            return _UIManager;
        }
    }

    private static UIManager _UIManager;

    //private MainMenuScreen mainMenu;

    //[SerializeField]
    //private MainMenuScreen _mainMenuScreen;
    
    //[SerializeField]
    //private  
}
