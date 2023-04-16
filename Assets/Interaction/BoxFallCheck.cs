using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFallCheck : MonoBehaviour
{
    [SerializeField] private CrayonUI Crayon_UI;
    private BoxController BC;

    void Start()
    {
        Crayon_UI = GameObject.Find("CrayonButton").GetComponent<CrayonUI>();
        BC = GameObject.Find("Interaction").GetComponent<BoxController>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("OriginLine") || Crayon_UI.Line_tag.ToString() == other.tag)
        {
            BC.is_fall = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("OriginLine") || Crayon_UI.Line_tag.ToString() == other.tag)
        {
            BC.is_fall = true;
        }
    }
}