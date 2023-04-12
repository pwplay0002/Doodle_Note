using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class mousePosition : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    void Start()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
    
    }
}
