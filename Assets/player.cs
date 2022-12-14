using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{
    [SerializeField]
    float time;
    
    float O2timer;
    [SerializeField]
    TextMeshProUGUI o2;

    // Start is called before the first frame update
    void Start()
    {
      O2timer = time;
    }

    // Update is called once per frame
    void Update()
    {
        string timeString = time.ToString();
        timeString = timeString.Split(',')[0];
        o2.text = "02 "+timeString+" / "+O2timer;
        time -= Time.deltaTime;
        if (time <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            time = O2timer;
        }
    }
       
}
