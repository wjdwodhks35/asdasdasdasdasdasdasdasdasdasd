using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public const float moveSpeed = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        moveControl();
        //�������� ��ȭ �� �� ���� �������� �����ϴ� �Լ� ȣ��
    }

    void moveControl()
    {
        float distanceY = moveSpeed * Time.deltaTime;
        //������ �Ÿ��� ������ݴϴ�.
        this.gameObject.transform.Translate(0, -1 * distanceY, 0);
        //�������� �ݿ��մϴ�
    }
}
