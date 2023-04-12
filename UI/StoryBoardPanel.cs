using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoryBoardPanel : MonoBehaviour
{
    [SerializeField]
    private List<Image> _storyBoardImageList;

    int _currentImageIndex;

    void Start()
    {
        _currentImageIndex = 0;

        foreach (Image i in _storyBoardImageList)
        {
            i.color = new Color(255.0f, 255.0f, 255.0f, 0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ShowNextImage()     //TODO : 2번째 패널부터 첫번째 이미지가 정상적으로 출력안됨 버그 픽스 필요
    {
        Debug.Log(_currentImageIndex);      

        _storyBoardImageList[_currentImageIndex].color = new Color(255.0f, 255.0f, 255.0f, 255.0f);

        Debug.Log(_currentImageIndex);

        ++_currentImageIndex;
    }
    
    public bool IsImageEnd()
    {
        if(_currentImageIndex == _storyBoardImageList.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ImageDisable()
    {
        foreach (Image i in _storyBoardImageList)
        {
            i.color = new Color(255.0f, 255.0f, 255.0f, 0.0f);
        }
    }
}
