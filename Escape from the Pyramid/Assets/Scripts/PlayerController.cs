using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rigidBody;
    public Animator animator;
    Vector2 movement;
    

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frameko
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movement.y = 1;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement.y = -1;

        }
        else
        {
            movement.y = 0;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -1;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement.x = 1;

        }
        else
        {
            movement.x = 0;
        }
        
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movement * speed * Time.fixedDeltaTime);
    }
}
