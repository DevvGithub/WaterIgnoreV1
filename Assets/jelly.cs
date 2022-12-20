using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jelly : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            hitpoints += -1;
        }
    }
    private int hitpoints = 2; 
    private float time = 0;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(hitpoints <= 0)
        {
            Destroy(this.gameObject);
        }
        
        time += Time.deltaTime;
        if (time <= 2)
        {
            transform.position += new Vector3(0, -1, 0) * Time.deltaTime;
        }
        if(time >= 2)
        {
            transform.position += new Vector3(0, 4, 0) * Time.deltaTime;
        }
        if(time >= 2.5)
        {
            time = 0;
        }
    }
}
