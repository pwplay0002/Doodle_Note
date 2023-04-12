using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownLineTrigger : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Line")
        {
            GameObject.Find("Player").GetComponent<JCharacterController>().is_downline = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Line")
        {
            GameObject.Find("Player").GetComponent<JCharacterController>().is_downline = false;
        }
    }
}
