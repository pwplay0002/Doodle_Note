using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheck : MonoBehaviour
{
    void Start()
    {
        
    }

    //�÷��̾ ���� ��������
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Enemy") 
        {
            //GameObject.Find("Player").GetComponent<JCharacterController>().is_fall = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            //GameObject.Find("Player").GetComponent<JCharacterController>().is_fall = true;
        }
    }

}

