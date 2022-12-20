using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearThrow : MonoBehaviour
{
    [SerializeField]
    GameObject thingToSpawn;

    [SerializeField]
    Transform spawnpoint;

    private Vector3 mousePos;
    private Camera mainCam;
    private float timer;
    public float timeBetween;
    public bool canThrow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (!canThrow)
        {
            timer += Time.deltaTime;
            if (timer > timeBetween)
            {
                canThrow = true;
                timer = 0;
            }
        }

        if (Input.GetKeyUp(KeyCode.F) && canThrow)
        {
            canThrow = false;
            Instantiate(thingToSpawn, spawnpoint.position, Quaternion.identity);
        }
    }
}
