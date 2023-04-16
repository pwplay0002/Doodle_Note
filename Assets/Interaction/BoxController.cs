using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    public bool is_fall;
    private JCharacterMovement JCM;

    void Start()
    {
        is_fall = false;
        JCM = GameObject.Find("Player").GetComponent<JCharacterMovement>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !is_fall)
        {
            Vector3 pos = other.transform.position + other.transform.right * 0.8f;
            transform.parent.position = pos;
            JCM.moveSpeed = 1.0f;
        }
        else
        {
            JCM.moveSpeed = 5.0f;
        }

    }
}
