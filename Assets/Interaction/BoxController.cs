using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 pos = other.transform.position + other.transform.right * 0.8f;
            transform.position = pos;
        }
    }
}
