using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField]
    float speed;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //가로로 이동하는 
        this.transform.Translate(new Vector2(x, 0));  //이동
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0.09f) pos.x = 0.09f;
        if (pos.x > 0.92f) pos.x = 0.92f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}