using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlendtree : MonoBehaviour
{
    Vector2 movement;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        anim.SetFloat("MoveX", movement.x);
        anim.SetFloat("MoveY", movement.y);
    }
}