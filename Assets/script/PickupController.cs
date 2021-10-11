using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;

    public KeyCode pickupBtn;
    public KeyCode throwBtn;

    float throwForce = 300;
    Vector3 objectPos;
    float distance;

    public bool canHold = false;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;
    public Transform grabPoint;

    public SnowballController sbCrl;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        //item.GetComponent<Rigidbody2D>().isKinematic = false;\
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(item.transform.position, tempParent.transform.position);
        //Debug.Log("distance is " + distance);

        if (Input.GetKeyDown(pickupBtn))
        {
            if (distance < 1f)
            {
                isHolding = true;
                item.GetComponent<Rigidbody2D>().gravityScale = 0;
                //item.GetComponent<Rigidbody2D>().collisionDetectionMode 
                Debug.Log("Is Holding");
                sbCrl = item.GetComponent<SnowballController>();
                sbCrl.isMeltable = true;

                item.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
                //item.GetComponent<Rigidbody2D>().angularVelocity = ;
                item.transform.SetParent(tempParent.transform);
                item.transform.position = grabPoint.position;
                //item.transform.position = tempParent.transform.position;
            }
        }

        if (Input.GetKeyDown(throwBtn))
        {
            if (isHolding)
            {
                Debug.Log("Throw");
                //objectPos = item.transform.position;
                item.transform.SetParent(null);
                //.transform.position = objectPos;

                item.GetComponent<Rigidbody2D>().gravityScale = 1;
                //tempParent.GetComponent<Rigidbody2D>().velocity =                
                item.GetComponent<Rigidbody2D>().isKinematic = false;
                item.GetComponent<Rigidbody2D>().AddForce(new Vector3(2,1,5) * throwForce);
                isHolding = false;
            }
        }
    }
}
