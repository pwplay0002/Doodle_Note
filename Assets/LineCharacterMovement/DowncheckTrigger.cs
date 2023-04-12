using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DowncheckTrigger : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Line")
        {
            GameObject.Find("Player").GetComponent<CharacterController>().is_down = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Line")
        {
            GameObject.Find("Player").GetComponent<CharacterController>().is_down = false;
        }
    }
}
