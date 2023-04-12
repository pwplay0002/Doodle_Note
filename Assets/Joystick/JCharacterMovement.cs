using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JCharacterMovement : MonoBehaviour
{
    private GameObject joystick;
    private GameObject p;
    public float moveSpeed = 5f;

    void Start()
    {
        p = GameObject.Find("Player");
        joystick = GameObject.Find("JoyStick");
    }

    void Update()
    {
        float Hori = joystick.GetComponent<Joystick>().Horizontal;
        float Vert = joystick.GetComponent<Joystick>().Vertical;


        if (Vert > 0 && (-1 * Vert < Hori && Hori < Vert) && p.GetComponent<JCharacterController>().dir_up && joystick.GetComponent<Joystick>().is_click)
        {
            if ((p.GetComponent<JCharacterController>().is_left || p.GetComponent<JCharacterController>().is_right || p.GetComponent<JCharacterController>().is_side))
            {
                if (!p.GetComponent<JCharacterController>().is_fall && !p.GetComponent<JCharacterController>().is_side)
                {
                    transform.position += Vector3.up * moveSpeed * Time.deltaTime * Vert;
                }
            }
        }
        else if (Vert < 0 && (-1 * Vert > Hori && Hori > Vert) && !p.GetComponent<JCharacterController>().dir_up && joystick.GetComponent<Joystick>().is_click)
        {
            if (p.GetComponent<JCharacterController>().is_left || p.GetComponent<JCharacterController>().is_right || p.GetComponent<JCharacterController>().is_side)
            {
                if (!p.GetComponent<JCharacterController>().is_fall && !p.GetComponent<JCharacterController>().is_side)
                {
                    transform.position += Vector3.up * moveSpeed * Time.deltaTime * Vert;
                }
            }
        }
        else if (Hori < 0 && (-1 * Hori > Vert && Vert > Hori) && !p.GetComponent<JCharacterController>().dir_right && joystick.GetComponent<Joystick>().is_click)
        {
            if (p.GetComponent<JCharacterController>().is_up || p.GetComponent<JCharacterController>().is_down || p.GetComponent<JCharacterController>().is_side)
            {
                if (!p.GetComponent<JCharacterController>().is_fall && !p.GetComponent<JCharacterController>().is_side)
                {
                    transform.position += Vector3.right * moveSpeed * Time.deltaTime * Hori;
                }
            }
        }
        else if (Hori > 0 && (-1 * Hori < Vert && Vert < Hori) && p.GetComponent<JCharacterController>().dir_right && joystick.GetComponent<Joystick>().is_click)
        {
            if (p.GetComponent<JCharacterController>().is_up || p.GetComponent<JCharacterController>().is_down || p.GetComponent<JCharacterController>().is_side)
            {
                if (!p.GetComponent<JCharacterController>().is_fall && !p.GetComponent<JCharacterController>().is_side)
                {
                    transform.position += Vector3.right * moveSpeed * Time.deltaTime * Hori;
                }
            }
        }
    }
}
