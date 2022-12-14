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
    TextMeshProUGUI TM;

    // Start is called before the first frame update
    void Start()
    {
      O2timer = time;// så det står 10/10 O2
    }

    // Update is called once per frame
    void Update()
    {
        string timeString = time.ToString();
        timeString = timeString.Split(',')[0];
        //så man inte ser 15 decimaler
        TM.text = "O2: " + timeString+" / "+O2timer;//vad som ska stå på TM
        time -= Time.deltaTime;// så att luften går ned över tid.
        if (time <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")//så O2 timmern resetas
        {
            time = O2timer;
        }
        //cod av William
    }
       
}
