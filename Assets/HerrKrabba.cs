using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerrKrabba : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            hitpoints += -1;
        }
    }
    private int hitpoints = 1;
    private float time = 0;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hitpoints <= 0)
        {
            Destroy(this.gameObject);
        }

        time += Time.deltaTime;
        if (time <= 3)
        {
            transform.position += new Vector3(-2, 0, 0) * Time.deltaTime;
        }
        if (time >= 3)
        {
            transform.position += new Vector3(2, 0, 0) * Time.deltaTime;
        }
        if (time >= 6)
        {
            time = 0;
        }
    }
}
