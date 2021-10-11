using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mainCam;

    public BoxCollider2D ground;
    public Transform bullet;

    void Start()
    {
        ground.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        ground.transform.position = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
