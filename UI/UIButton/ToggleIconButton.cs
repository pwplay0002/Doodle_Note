using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleIconButton : MonoBehaviour
{
    [SerializeField]
    private Sprite _defaultImage;

    [SerializeField]
    private Sprite _changeImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Image image = gameObject.GetComponent<Image>();

        if (image.sprite == _defaultImage)
        {
            image.sprite = _changeImage;
        }
        else
        {
            image.sprite = _defaultImage;
        }
    }
}
