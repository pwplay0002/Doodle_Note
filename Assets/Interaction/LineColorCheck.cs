using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineColorCheck : MonoBehaviour
{
    public GameObject Crayon_UI;

    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("OriginLine"))
        {
            for (int i = 0; i < 7; i++)
            {
                Crayon_UI.transform.GetChild(i + 1).GetComponent<Button>().interactable = true;
            }
        }
        else
        {
            for(int i = 0; i < 7; i++)
            {
                Crayon_UI.transform.GetChild(i + 1).GetComponent<Button>().interactable = false;
            }
        }
    }
}
