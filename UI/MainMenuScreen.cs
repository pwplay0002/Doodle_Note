using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{ 
    //[SerializeField]
    //private ModeSelectButton _modeSelectionPanel;

    [SerializeField]
    private string _loadSceneString;

    [SerializeField]
    private Animator _sceneAnimator;

    [SerializeField]
    private Scene _lobbyScene;

    private bool _IsClick;

    // Start is called before the first frame update
    void Start()
    {
        _IsClick = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!UIManager.p_UIManager.IsFading() && Input.GetMouseButtonDown(0))
        {
            Debug.Log("OnClick");
            UIManager.p_UIManager.ScreenFadeOut();

            _IsClick = true;
        }

        if (_IsClick)
        {
            if (!UIManager.p_UIManager.IsFading())
            {
                SceneManager.LoadScene(_loadSceneString);
            }
        }

#if UNITY_ANDROID       
        if (Input.anyKeyDown)
        {
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)
            {
               _sceneAnimator.SetTrigger("doMove");
               Debug.Log("Click");
            }        
        }
#endif   

    }


    public void OnClickNewGame()
    {
        
    }

    public void OnClickLoad()
    {

    }

    public void OnClickQuit()
    {

    }



}
