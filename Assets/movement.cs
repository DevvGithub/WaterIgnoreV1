using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    float jumpforce = 5;
    bool canJump;
    bool canMove;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="floor")
        {
            canJump = true;
            canMove = true;
            //man kan bara hoppa och gå när man nuddat marken
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
            
        }
        if (canJump == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
                canJump = false;
            }
        }


        if (canMove == false)
        {
            transform.position += new Vector3(0, -3)*Time.deltaTime;
            //så att man inte kan gå i början när man sjunker från båten
        }
        //Kod av Albin
    }

}
