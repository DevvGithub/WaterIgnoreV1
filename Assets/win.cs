using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class win : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI GM;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            print("kaka");
            GM.text = "You Win";
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
