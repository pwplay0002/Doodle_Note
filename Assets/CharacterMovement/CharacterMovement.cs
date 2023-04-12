using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Joystick joystick;
    private GameObject p;
    public float moveSpeed = 5f;

    void Start()
    {
        p = GameObject.Find("Player");
        joystick = GameObject.FindObjectOfType<Joystick>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (p.GetComponent<CharacterController2D>().is_left || p.GetComponent<CharacterController2D>().is_right || p.GetComponent<CharacterController2D>().is_side)
            {
                if (!p.GetComponent<CharacterController2D>().is_fall)
                    transform.position = new Vector2(transform.position.x, transform.position.y + (moveSpeed * Time.deltaTime));
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (p.GetComponent<CharacterController2D>().is_left || p.GetComponent<CharacterController2D>().is_right || p.GetComponent<CharacterController2D>().is_side)
            {
                if (!p.GetComponent<CharacterController2D>().is_fall)
                    transform.position = new Vector2(transform.position.x, transform.position.y - (moveSpeed * Time.deltaTime));
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (p.GetComponent<CharacterController2D>().is_up || p.GetComponent<CharacterController2D>().is_down || p.GetComponent<CharacterController2D>().is_side)
            {
                if (!p.GetComponent<CharacterController2D>().is_fall)
                    transform.position = new Vector2(transform.position.x - (moveSpeed * Time.deltaTime), transform.position.y);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (p.GetComponent<CharacterController2D>().is_up || p.GetComponent<CharacterController2D>().is_down || p.GetComponent<CharacterController2D>().is_side)
            {
                if (!p.GetComponent<CharacterController2D>().is_fall)
                    transform.position = new Vector2(transform.position.x + (moveSpeed * Time.deltaTime), transform.position.y);
            }
        }
    }
}
