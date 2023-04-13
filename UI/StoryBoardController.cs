using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[System.Serializable]
public struct ImagePosition
{
    public int _x;
    public int _y;
}

public class StoryBoardController : MonoBehaviour, ISerializationCallbackReceiver //, IEqualityComparer<ImagePosition>
{
    //[System.Serializable] struct ImagePosition;

    //[SerializeField]
    //private Dictionary<Sprite, ImagePostion> _imageMap = new Dictionary<Sprite, ImagePostion>();

    //[SerializeField]
    //private List<ImagePosition> _imagePosition = new List<ImagePosition>();

    //[SerializeField]
    //private List<Sprite> _storyBoardImageList;

    //[SerializeField]
    //private List<int> _boardPageIndexList;

    [SerializeField]
    private string _nextScene;

    [SerializeField]
    private List<GameObject> _boardList;

    private StoryBoardPanel _currentPanel;
    
    int _currentBoardIndex;

    [SerializeField]
    private Transform _canvas;

    /*
    bool IEqualityComparer<ImagePostion>.Equals(ImagePostion x, ImagePostion y)
    {
        return x._x == y._x && x._y == y._y;
    }

    int IEqualityComparer<ImagePostion>.GetHashCode(ImagePostion obj)
    {
        return obj.GetHashCode();
    }
    */

    void Start()
    {
        _currentBoardIndex = 0;

        _currentPanel = Instantiate(_boardList[_currentBoardIndex], _canvas).GetComponent<StoryBoardPanel>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!UIManager.p_UIManager.IsFading() && Input.GetMouseButtonDown(0))
        {      
            if(_currentPanel.IsImageEnd())
            {
                Destroy(_currentPanel);
                _currentPanel.ImageDisable();

                ++_currentBoardIndex;

                if (_boardList.Count > _currentBoardIndex)
                {
                    _currentPanel = Instantiate(_boardList[_currentBoardIndex], _canvas).GetComponent<StoryBoardPanel>();
                }
                else
                {
                    UIManager.p_UIManager.ScreenFadeOut();

                    StartCoroutine(WaitFade());

                    //SceneManager.LoadScene(_nextScene);
                    return;
                }              
            }

            _currentPanel.ShowNextImage();
        }
    }

    private IEnumerator WaitFade()
    {

        yield return new WaitUntil(() => UIManager.p_UIManager.IsFading() == false);

        SceneManager.LoadScene("TitleScene");

    }


    //Legary
    ///////////////////////////////////////////

    public void OnBeforeSerialize()
    {
    }

    public void OnAfterDeserialize()
    {
        /*
        _imageMap = new Dictionary<Sprite, ImagePostion>();

        for (int i = 0; i != Mathf.Min(_storyBoardImageList.Count, _imagePosition.Count); i++)
        {   
            //_imageMap.Add(_storyBoardImageList[i], _imagePosition[i]);
        }
        */
    }



}
