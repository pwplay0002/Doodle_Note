using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionButton : CommonUIButton
{
    [SerializeField]
    private Transform _canvas;      // TODO : awake set canvas

    [SerializeField]
    private GameObject _uiBlurObject;
    
    [SerializeField]
    private GameObject _panelPrefab;

    private GameObject _panelObject;

    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    virtual public void OnClick()
    {
        if (_panelObject == null)
        {
            _panelObject = Instantiate(_panelPrefab, _canvas);

            _uiBlurObject.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, 255.0f);
        }
        else
        {
            if(_panelObject.activeSelf == true)
            {
                _panelObject.SetActive(false);

                _uiBlurObject.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, 0.0f);
            }
            else
            {
                _panelObject.SetActive(true);
                _uiBlurObject.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, 255.0f);
            }
        }
    }

}
