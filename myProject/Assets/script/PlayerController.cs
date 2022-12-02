using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb2D;
    public float moveSpeed;
    private Vector2 moveDirection;

   

    // Start is called before the first frame update
    void Start()
    {

        

    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {

        rb2D.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

    }





    // Update is called once per frame
    void Update()
    {

        ProcessInputs();

    }

    private void FixedUpdate()
    {

        Move();
        
    }
}