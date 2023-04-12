using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public RectTransform handle;
    public RectTransform outLine;

    private float deadZone = 0;
    private float handleRange = 1;
    private Vector3 input = Vector3.zero;
    private Canvas canvas;

    public float Horizontal { get{ return input.x; } set { input.x = value; } }
    public float Vertical { get { return input.y; } set { input.y = value; } }

    private GameObject jst;
    private GameObject P;

    public bool is_click;

    void Start()
    {
        jst = GameObject.Find("Joystick");
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        outLine = jst.gameObject.GetComponent<RectTransform>();
        P = GameObject.Find("Player");
        is_click = false;

        jst.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        jst.SetActive(true);
        outLine.anchoredPosition = Input.mousePosition;
        //Debug.Log("Click Down");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 radius = outLine.sizeDelta / 2;
        input = (eventData.position - outLine.anchoredPosition) / (radius * canvas.scaleFactor);

        //Debug.Log("Drag");

        if (Vertical > 0 && (-1 * Vertical < Horizontal && Horizontal < Vertical)) // 위
        {
            Horizontal = 0;
        }
        else if(Vertical < 0 && (-1 * Vertical > Horizontal && Horizontal > Vertical)) // 아래
        {
            Horizontal = 0;
        }
        else if(Horizontal > 0 && (-1 * Horizontal < Vertical && Vertical < Horizontal)) // 오른쪽
        {
            Vertical = 0;
        }
        else if(Horizontal < 0 && (-1 * Horizontal > Vertical && Vertical > Horizontal)) // 왼쪽
        {
            Vertical = 0;
        }

        HandleInput(input.magnitude, input.normalized);
        handle.anchoredPosition = input * radius * handleRange;
    }

    private void HandleInput(float magnitude, Vector2 normalised)
    {
        if(magnitude > deadZone)
        {
            if(magnitude > 1)
            {
                input = normalised;
            }
            else
            {
                input = Vector2.zero;
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        input = Vector2.zero;

        handle.anchoredPosition = input * outLine.sizeDelta;
        jst.SetActive(false);
        //Debug.Log("Click up");
        is_click = true;
    }

}
