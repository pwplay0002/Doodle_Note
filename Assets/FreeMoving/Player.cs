using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private FreeJoystick joystick;
    Animator Anim;

    void Start()
    {
        joystick = GameObject.FindObjectOfType<FreeJoystick>();
        Anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            MoveControl();
            Anim.SetBool("Is_Walk", true);
            Anim.SetBool("Is_Idle", false);
            //Debug.Log(joystick.Horizontal + " / " + joystick.Vertical);
        }
        else
        {
            IdleControl();
            Anim.SetBool("Is_Walk", false);
            Anim.SetBool("Is_Idle", true);
        }
    }

    private void MoveControl()
    {
        transform.position += Vector3.up * speed * Time.deltaTime * joystick.Vertical;
        transform.position += Vector3.right * speed * Time.deltaTime * joystick.Horizontal;

        if (joystick.Horizontal > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (joystick.Horizontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
    private void IdleControl()
    {

    }
}
