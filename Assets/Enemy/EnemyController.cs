using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform startPoint; // 시작지점
    public Transform endPoint;   // 끝지점
    public float moveSpeed = 2f; // 이동속도

    private bool movingToEndPoint = true; // 시작지점에서 끝지점으로 이동 중인가?

    void Update()
    {
        // 적이 시작지점에서 끝지점으로 이동하는 경우
        if (movingToEndPoint)
        {
            transform.position = Vector2.MoveTowards(transform.position, endPoint.position, moveSpeed * Time.deltaTime);

            // 적이 끝지점에 도착한 경우
            if (transform.position == endPoint.position)
            {
                movingToEndPoint = false;
            }
        }
        // 적이 끝지점에서 시작지점으로 이동하는 경우
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, startPoint.position, moveSpeed * Time.deltaTime);

            // 적이 시작지점에 도착한 경우
            if (transform.position == startPoint.position)
            {
                movingToEndPoint = true;
            }
        }
    }
}