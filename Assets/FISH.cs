using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FISH : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    Transform fish;
    [SerializeField]
    float speed;

    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir = (player.transform.position - fish.transform.position).normalized;
        transform.position += dir * speed *Time.deltaTime;
    }
}





//W
