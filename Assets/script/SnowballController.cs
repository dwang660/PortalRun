using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballController : MonoBehaviour
{
    public Animator myAnimator;
    private Rigidbody2D rigidBody2D;
    public PlayerController playController;
    public bool isMeltable = false;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.name);

        if (collision.collider.name == "enemy")
        {
            rigidBody2D.velocity = new Vector2(0, 0);

            rigidBody2D.freezeRotation = true;
            
            Debug.Log("Hit the ball");

            //myAnimator.enabled = true;
            //myAnimator.SetBool("isHit", true);
            //Destroy(this.GetComponent<Collider2D>());
            //this.gameObject.AddComponent<PolygonCollider2D>();
            playController = collision.gameObject.GetComponent<PlayerController>();
            Debug.Log("Speed before :" + playController.speed);

            playController.speed = playController.speed * 0.5f;
            Debug.Log("Speed after :" + playController.speed);
            Destroy(this.gameObject);
        }

        if (collision.collider.name == "ground" && isMeltable)
        {
            rigidBody2D.velocity = new Vector2(0, 0);

            rigidBody2D.freezeRotation = true;

            Debug.Log("Hit the ball");

            //myAnimator.enabled = true;
            myAnimator.SetBool("isHit", true);
            Destroy(this.GetComponent<Collider2D>());
            this.gameObject.AddComponent<PolygonCollider2D>();
        }

    }

}
