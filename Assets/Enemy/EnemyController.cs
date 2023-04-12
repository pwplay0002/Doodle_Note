using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform startPoint; // ��������
    public Transform endPoint;   // ������
    public float moveSpeed = 2f; // �̵��ӵ�

    private bool movingToEndPoint = true; // ������������ ���������� �̵� ���ΰ�?

    void Update()
    {
        // ���� ������������ ���������� �̵��ϴ� ���
        if (movingToEndPoint)
        {
            transform.position = Vector2.MoveTowards(transform.position, endPoint.position, moveSpeed * Time.deltaTime);

            // ���� �������� ������ ���
            if (transform.position == endPoint.position)
            {
                movingToEndPoint = false;
            }
        }
        // ���� ���������� ������������ �̵��ϴ� ���
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, startPoint.position, moveSpeed * Time.deltaTime);

            // ���� ���������� ������ ���
            if (transform.position == startPoint.position)
            {
                movingToEndPoint = true;
            }
        }
    }
}