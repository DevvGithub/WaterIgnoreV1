using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uppgrades : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")// Om en uppgrade som O2 nuddar "Player" så försvinner den.
        {
            Destroy(this.gameObject);
        }
    }
    //cod av William

}
