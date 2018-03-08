using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float PlayerSpeed = 10.0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            
        //Controls
        var horizontal = Input.GetAxis("Horizontal");

        gameObject.GetComponent<Animator>().SetBool("isWalking", Input.GetButtonDown("Horizontal"));
        
        //Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(horizontal * PlayerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
}
