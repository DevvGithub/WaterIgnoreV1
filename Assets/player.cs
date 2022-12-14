using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{
    [SerializeField]
    float o2;

    float O2timer;
    [SerializeField]
    TextMeshProUGUI o2TM;
    [SerializeField]
    TextMeshProUGUI HpTM;
    [SerializeField]
    int MaxHP;
    int MaxHPsave;

    // Start is called before the first frame update
    void Start()
    {
      O2timer = o2;// s� det st�r 10/10 O2
      MaxHPsave = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        string timeString = o2.ToString();
        timeString = timeString.Split(',')[0];
        //s� man inte ser 15 decimaler
        o2TM.text = "O2: " + timeString+" / "+O2timer;//vad som ska st� p� TM
        o2 -= Time.deltaTime;// s� att luften g�r ned �ver tid.
        if (o2 <= 0)
        {
            Destroy(this.gameObject);
        }
        HpTM.text = "Hp:"+MaxHP+"/"+MaxHPsave;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")//s� O2 timmern resetas
        {
            o2 = O2timer;
        }
        if (collision.gameObject.tag == "jellyfish")
        {
            Destroy(this.gameObject);
        }
        //cod av William
    }
       
}
