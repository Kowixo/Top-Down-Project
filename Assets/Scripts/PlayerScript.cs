using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator anim;
    [SerializeField] float speed;

    Vector3 move;

    private void Update()
    {
        move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized;
        anim.SetFloat("horizontal", move.x);
        anim.SetFloat("vertical", move.y);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + (move * speed * Time.fixedDeltaTime));
    }
}
