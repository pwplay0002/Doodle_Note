using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CommonUIButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private float _closeUpHorizontal;

    [SerializeField]
    private float _closeUpVertical;

    private float _defaultHorizontal;
    private float _defaultVertical;

    // Start is called before the first frame update
    protected void Start()
    {
        RectTransform rectTran = gameObject.GetComponent<RectTransform>();
        _defaultHorizontal = rectTran.rect.width;
        _defaultVertical = rectTran.rect.height;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        RectTransform rectTran = gameObject.GetComponent<RectTransform>();
        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, _closeUpHorizontal);
        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, _closeUpVertical);

        Debug.Log(rectTran.rect);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log(_defaultHorizontal);

        RectTransform rectTran = gameObject.GetComponent<RectTransform>();
        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, _defaultHorizontal);
        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, _defaultVertical);
    }
    


}
