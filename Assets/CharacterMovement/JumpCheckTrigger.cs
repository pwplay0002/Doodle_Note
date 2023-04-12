using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCheckTrigger : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Line")
        {
            GameObject.Find("Player").GetComponent<JCharacterController>().is_jump = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Line")
        {
            GameObject.Find("Player").GetComponent<JCharacterController>().is_jump = false;
        }
    }
}
