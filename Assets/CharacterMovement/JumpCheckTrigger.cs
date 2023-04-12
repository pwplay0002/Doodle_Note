using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCheckTrigger : MonoBehaviour
{
    [SerializeField] private CrayonUI Crayon_UI;

    void Start()
    {
        Crayon_UI = GameObject.Find("CrayonButton").GetComponent<CrayonUI>();
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("OriginLine") || Crayon_UI.Line_tag.ToString() == other.tag)
        {
            GameObject.Find("Player").GetComponent<JCharacterController>().is_jump = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("OriginLine") || Crayon_UI.Line_tag.ToString() == other.tag)
        {
            GameObject.Find("Player").GetComponent<JCharacterController>().is_jump = false;
        }
    }
}
