using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rigidBody2D;

    public KeyCode leftbtn;
    public KeyCode rightbtn;
    public KeyCode upbtn;
    public KeyCode downbtn;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(rightbtn))
        {
            rigidBody2D.velocity = new Vector2(speed, rigidBody2D.velocity.y);

        }
        else if (Input.GetKeyDown(leftbtn))
        {
            rigidBody2D.velocity = new Vector2(-speed, rigidBody2D.velocity.y);

        }

        if (Input.GetKeyDown(upbtn))
        {
            rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, speed);

        }
        else if (Input.GetKeyDown(downbtn))
        {
            rigidBody2D.velocity = new Vector2(rigidBody2D.velocity.x, -speed);

        }

    }
}
