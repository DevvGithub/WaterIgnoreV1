using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jelly : MonoBehaviour
{
    private float time = 0;
    private float timer = 2;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,-1,0) * Time.deltaTime;
        time += Time.deltaTime;
        if (time >= timer)
        {
            transform.position += new Vector3(0, 1, 0);
            transform.position += new Vector3(0, 1, 0);

            time = 0;
        }
    }
}
