using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FISH : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    Transform fish;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(player.transform.position.x - fish.transform.position.x, player.transform.position.y - fish.transform.position.y, 0)*Time.deltaTime;
    }
}





//W
