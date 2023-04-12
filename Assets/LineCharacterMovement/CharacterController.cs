using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    public Vector3 rotationDirection = Vector3.up;
    Vector3 movementDirection;
    public Rigidbody2D rd;

    public bool is_LineOn = true;
    public bool is_LineMid = false;
    public bool is_LineDown = false;

    public bool is_right = true;
    public bool is_up = true;
    public bool is_down = false;
    public bool is_side = false;


    void start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");


        if (is_LineOn || is_LineDown)
        {
            movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
            transform.position += movementDirection * moveSpeed * Time.deltaTime;
        }
    
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (is_LineOn)
            {
                if(is_down)
                {
                    transform.Rotate(Vector3.right * 180f, Space.World);
                    transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
                    is_LineDown = true;
                    is_LineOn = false;
                    is_up = false;
                }

            }
            else if (is_LineMid)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
                is_LineMid = false;
                is_LineOn = true;

                if (!is_up)
                {
                    is_up = true;
                    transform.Rotate(Vector3.right * 180f, Space.World);
                }
            }
            else if (is_LineDown)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
                is_LineMid = true;
                is_LineDown = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (is_LineOn)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
                is_LineOn = false;
                is_LineMid = true;
            }
            else if (is_LineMid)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
                is_LineMid = false;
                is_LineDown = true;

                if (is_up)
                {
                    is_up = false;
                    transform.Rotate(Vector3.right * 180f, Space.World);
                }
            }
            else if (is_LineDown)
            {
                if (is_down)
                {
                    transform.Rotate(Vector3.right * 180f, Space.World);
                    transform.position = new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z);
                    is_LineDown = false;
                    is_LineOn = true;
                    is_up = true;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (is_right)
            {
                is_right = false;
                transform.Rotate(Vector3.down * 180f, Space.World);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!is_right)
            {
                is_right = true;
                transform.Rotate(Vector3.up * 180f, Space.World);
            }
        }


    }
}