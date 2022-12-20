using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
    }
}
