using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotalController : MonoBehaviour
{
    public GameObject targetObj;
    public GameObject toObj;
    private Vector3 toTrans;

    private Joystick joystick;
    private JCharacterController J_Character;

    public bool is_in = false;

    public bool is_up;
    public bool is_down;
    public bool is_left;
    public bool is_right;

    void Start()
    {
        J_Character = GameObject.Find("Player").GetComponent<JCharacterController>();

        joystick = GameObject.Find("JoyStick").GetComponent<Joystick>();

        this.is_up  = false;
        this.is_down  = false;
        this.is_left = false;
        this.is_right = false;

        if(this.CompareTag("UpPotal"))
        {
            this.is_up = true;
        }
        else if(this.CompareTag("DownPotal"))
        {
            this.is_down  = true;
        }
        else if(this.CompareTag("RightPotal"))
        {
            this.is_right = true;
        }
        else if(this.CompareTag("LeftPotal"))
        {
            this.is_left = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !is_in && J_Character.Anim_End)
        {
            this.is_in = true;
            toObj.GetComponent<PotalController>().is_in = true;

            targetObj = collision.transform.parent.gameObject;

            toTrans = new Vector3(toObj.transform.position.x, toObj.transform.position.y, targetObj.transform.position.z);

            StartCoroutine(TeleportRoutine());

            J_Character.is_up = toObj.GetComponent<PotalController>().is_up;
            J_Character.is_down = toObj.GetComponent<PotalController>().is_down;
            J_Character.is_right = toObj.GetComponent<PotalController>().is_right;
            J_Character.is_left = toObj.GetComponent<PotalController>().is_left;

            joystick.is_click = false;
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
