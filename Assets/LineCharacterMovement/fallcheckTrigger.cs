using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallcheckTrigger : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Line")
        {
            GameObject.Find("Player").GetComponent<CharacterController>().moveSpeed = 5f;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Line")
        {
            GameObject.Find("Player").GetComponent<CharacterController>().moveSpeed = 0f;
        }
    }
}
