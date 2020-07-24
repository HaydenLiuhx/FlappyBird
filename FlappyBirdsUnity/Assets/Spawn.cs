using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Pillars;

    public float colddown = 2f;
    float nextSpawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + colddown;

            Vector3 spawN = transform.position;
            spawN.y += Random.Range(-2.5f, 2.5f);
            Instantiate(Pillars, spawN, transform.rotation);
        }
    }
}
 