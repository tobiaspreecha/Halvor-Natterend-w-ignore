using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float PlayerSpeed = 10.0f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Controls
        #region Horizontal - Vertical
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        gameObject.GetComponent<Animator>().SetBool("isWalking", Input.GetButtonDown("Horizontal"));
        gameObject.GetComponent<Animator>().SetBool("isWalking", Input.GetButtonDown("Vertical"));
        #endregion
        #region Flip
        //Animations
        if (horizontal < -0.1f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (horizontal > 0.1f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (vertical < -0.1f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipY = true;
        }
        else if (vertical > 0.1f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipY = false;
        }
        #endregion

        //Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(horizontal * PlayerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(vertical * PlayerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.x);
    }
}
