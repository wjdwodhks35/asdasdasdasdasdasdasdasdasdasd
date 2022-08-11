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
        //프레임이 변화 할 때 마다 움직임을 관리하는 함수 호출
    }

    void moveControl()
    {
        float distanceY = moveSpeed * Time.deltaTime;
        //움직일 거리를 계산해줍니다.
        this.gameObject.transform.Translate(0, -1 * distanceY, 0);
        //움직임을 반영합니다
    }
}
