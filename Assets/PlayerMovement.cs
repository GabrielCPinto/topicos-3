using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {

        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(10f * dirX, rb.velocity.y);

        if(Input.GetButtonDown("Jump")){
            rb.velocity = new Vector2(rb.velocity.x, 14f);
        }
    }
}
