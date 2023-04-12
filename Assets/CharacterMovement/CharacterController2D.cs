using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{


    public bool is_up = true;     // 캐릭터가 라인 위에 있을때
    public bool is_down = false;  // 캐릭터가 라인 아래에 있을때
    public bool is_right = false; // 캐릭터가 라인 오른쪽에 있을때
    public bool is_left = false;  // 캐릭터가 라인 왼쪽에 있을때

    public bool dir_up = false;    // true이면 진행 방향이 위일때, false이면 진행 방행이 아래일때
    public bool dir_right = true; // true이면 진행방향이 오른쪽일때, false이면 진행 방향이 왼쪽일때

    public bool is_fall;
    public bool is_side = false;

    public bool is_mid = false;
    public bool is_jump = false;

    // 한칸씩 이동하는 것 구현 o 
    // 위에 있는 bool변수의 경우의 수마다 로테이션 넣어주기 o
    // 사이드 감지 및 사이드 있을때만 방행 전환 o 
    // 떨어짐 감지 o
    // 각 라인마다 상태 1 ~ 3 구현 o


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (is_left || is_right || is_side)
            {
                

                if (is_up && dir_right)
                {
                    is_up = false;
                    is_left = true;
                    dir_up = true;
                }
                else if (is_up && !dir_right)
                {
                    is_up = false;
                    is_right = true;
                    dir_up = true;
                }

                if (!dir_up)
                {
                    dir_up = true;
                }
            }

            if (is_down && !is_mid)
            {
                is_mid = true;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 0f;
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f);
            }
            else if (is_down && is_mid)
            {
                is_mid = false;
                is_down = false;
                is_up = true;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 5f;
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f);
            }
            else if (is_mid && !is_right && !is_left)
            {
                is_mid = false;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 5f;
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f);
            }

            if(is_up && is_jump)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + 1f);
                is_up = false;
                is_down = true;
            }

        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (is_left || is_right || is_side)
            {
                if (is_down && dir_right)
                {
                    is_down = false;
                    is_left = true;
                    dir_up = false;
                }
                else if (is_down && !dir_right)
                {
                    is_down = false;
                    is_right = true;
                    dir_up = false;
                }

                if (dir_up)
                {
                    dir_up = false;
                }
            }

            if (is_up && !is_mid)
            {
                is_mid = true;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 0f;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f);
            }
            else if (is_up && is_mid)
            {
                is_mid = false;
                is_up = false;
                is_down = true;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 5f;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f);
            }
            else if (is_mid && !is_right && !is_left)
            {
                is_mid = false;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 5f;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f);
            }

            if (is_down && is_jump)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - 1f);
                is_down = false;
                is_up = true;
            }
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (is_up || is_down || is_side)
            {
                if (is_left && dir_up)
                {
                    is_left = false;
                    is_down = true;
                    dir_right = false;
                }
                else if (is_left && !dir_up)
                {
                    is_left = false;
                    is_up = true;
                    dir_right = false;
                }

                if (dir_right)
                {
                    dir_right = false;
                }
            }

            if (is_right && !is_mid)
            {
                is_mid = true;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 0f;
                transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y);
            }
            else if (is_right && is_mid)
            {
                is_mid = false;
                is_right = false;
                is_left = true;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 5f;
                transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y);
            }
            else if (is_mid && !is_up && !is_down)
            {
                is_mid = false;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 5f;
                transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y);
            }


            if (is_left && is_jump)
            {
                transform.position = new Vector2(transform.position.x - 1f, transform.position.y);
                is_left = false;
                is_right = true;
            }
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (is_up || is_down || is_side)
            {
                if (is_right && dir_up)
                {
                    is_right = false;
                    is_down = true;
                    dir_right = true;
                }
                else if (is_right && !dir_up)
                {
                    is_right = false;
                    is_up = true;
                    dir_right = true;
                }

                if (!dir_right)
                {
                    dir_right = true;
                }
            }

            if (is_left && !is_mid)
            {
                is_mid = true;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 0f;
                transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y);
            }
            else if (is_left && is_mid)
            {
                is_mid = false;
                is_left = false;
                is_right = true;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 5f;
                transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y);
            }
            else if (is_mid && !is_up && !is_down)
            {
                is_mid = false;
                GameObject.Find("Player").GetComponent<CharacterMovement>().moveSpeed = 5f;
                transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y);
            }

            if (is_right && is_jump)
            {
                transform.position = new Vector2(transform.position.x + 1f, transform.position.y);
                is_right = false;
                is_left = true;
            }
        }
    }
}


