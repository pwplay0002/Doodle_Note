using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JCharacterRotation : MonoBehaviour
{
    public JCharacterController JCP;
    public GameObject p;

    void Start()
    {
        JCP = GetComponent<JCharacterController>();
    }

    void Update()
    {
        if (JCP.is_up)
        {
            if (JCP.dir_right)
            {
                p.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (!JCP.dir_right)
            {
                p.transform.eulerAngles = new Vector3(0, 180, 0);
            }
        }

        if (JCP.is_down)
        {
            if (JCP.dir_right)
            {
                p.transform.eulerAngles = new Vector3(-180, 0, 0);
            }
            else if (!JCP.dir_right)
            {
                p.transform.eulerAngles = new Vector3(0, 0, -180);
            }
        }

        if (JCP.is_right)
        {
            if (JCP.dir_up)
            {
                p.transform.eulerAngles = new Vector3(180, 0, -90);
            }
            else if (!JCP.dir_up)
            {
                p.transform.eulerAngles = new Vector3(0, 0, -90);
            }
        }

        if (JCP.is_left)
        {
            if (JCP.dir_up)
            {
                p.transform.eulerAngles = new Vector3(0, 0, 90);
            }
            else if (!JCP.dir_up)
            {
                p.transform.eulerAngles = new Vector3(-180, 0, 90);
            }
        }
    }
}
