using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheck : MonoBehaviour
{
    void Start()
    {
        
    }

    //플레이어가 적을 만났을때
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

