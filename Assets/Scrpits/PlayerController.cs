using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float jumpHeight = 5f;
    bool onGround = true;
    float speed = 10;
    int doubleJumpCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue value) //control type: Vector 2 --> {x,y}
    {
        Vector2 input = value.Get<Vector2>();

        Debug.Log(input);

        //transform.position, transform.rotation, transform.forward, transfrom.right
        rb.velocity = input.y * transform.forward + input.x * transform.right;
        rb.velocity *= speed;
    }

    void OnJump()
    {
        if(doubleJumpCount < 1)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
            doubleJumpCount++;
        }
        else if(onGround)
        {
            Debug.Log("JUMPING");
            doubleJumpCount = 0;
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            //our feet are touching the ground
            onGround = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            //our feet are no longer touching the ground
            onGround = false;
        }
    }

}
