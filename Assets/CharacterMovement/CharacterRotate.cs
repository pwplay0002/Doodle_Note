using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotate : MonoBehaviour
{
    public GameObject p;

    void Start()
    {
    }

    void Update()
    {
        if (p.GetComponent<CharacterController2D>().is_up)
        {
            if (p.GetComponent<CharacterController2D>().dir_right)
            {
                p.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (!p.GetComponent<CharacterController2D>().dir_right)
            {
                p.transform.eulerAngles = new Vector3(0, 180, 0);
            }
        }
        if (p.GetComponent<CharacterController2D>().is_down)
        {
            if (p.GetComponent<CharacterController2D>().dir_right)
            {
                p.transform.eulerAngles = new Vector3(-180, 0, 0);
            }
            else if (!p.GetComponent<CharacterController2D>().dir_right)
            {
                p.transform.eulerAngles = new Vector3(0, 0, -180);
            }
        }

        if (p.GetComponent<CharacterController2D>().is_right)
        {
            if (p.GetComponent<CharacterController2D>().dir_up)
            {
                p.transform.eulerAngles = new Vector3(180, 0, -90);
            }
            else if (!p.GetComponent<CharacterController2D>().dir_up)
            {
                p.transform.eulerAngles = new Vector3(0, 0, -90);
            }
        }

        if (p.GetComponent<CharacterController2D>().is_left)
        {
            if (p.GetComponent<CharacterController2D>().dir_up)
            {
                p.transform.eulerAngles = new Vector3(0, 0, 90);
            }
            else if (!p.GetComponent<CharacterController2D>().dir_up)
            {
                p.transform.eulerAngles = new Vector3(-180, 0, 90);
            }
        }
    }
}
