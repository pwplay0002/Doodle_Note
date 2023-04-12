using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotalController : MonoBehaviour
{
    public GameObject targetObj;
    public GameObject toObj;
    private Vector3 toTrans;

    public bool is_in = false;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.CompareTag("Player") && !is_in)
        {
            this.is_in = true;
            toObj.GetComponent<PotalController>().is_in = true;
            targetObj = collision.transform.parent.gameObject;
            toTrans = new Vector3(toObj.transform.position.x, toObj.transform.position.y, targetObj.transform.position.z);
            StartCoroutine(TeleportRoutine());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && is_in)
        {
            this.is_in = false;
            toObj.GetComponent<PotalController>().is_in = false;
        }
    }

    IEnumerator TeleportRoutine()
    {
        yield return null;
        targetObj.transform.position = toTrans;
    }
}
