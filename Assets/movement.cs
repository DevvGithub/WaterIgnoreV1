using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float jumpforce;
    Rigidbody2D rb;
    bool canJump;
    bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="floor")
        {
            canJump = true;
        }
        if (collision.gameObject.tag == "spawn")
        {
            canMove = true;
        }
        

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag=="floor")
        {
            canJump = false;
        }
    }
    void Update()
    {
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(5, 0) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-5, 0) * Time.deltaTime;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpforce*Time.deltaTime, ForceMode2D.Impulse);
            }
        }
        if (canMove == false)
        {
            transform.position += new Vector3(0, -3)*Time.deltaTime;
        }
    }

}
