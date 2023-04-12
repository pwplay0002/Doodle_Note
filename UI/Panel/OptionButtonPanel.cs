using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButtonPanel : MonoBehaviour
{
    //[SerializeField]
    //private GameObject _optionButtonLayout;
    /*
    [SerializeField]
    private GameObject _restartButtonPrefab;

    [SerializeField]
    private GameObject _levelSelecButtonPrefab;

    [SerializeField]
    private GameObject _exitButtonPrefab;
    */
    //private List<CommonUIButton> _optionButtonList;

    void Start()    
    {
        //Instantiate(_exitButtonPrefab);
        //_optionButtonList.Add();
        //TODO : _optionButtonList = button;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRestartLevel()
    {

    }

    public void OnLevelSelection()
    {

    }

    public void OnExitGame()
    {
        //base.OnClick();

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }

    public void OnBGMSound()
    {

    }

}
