using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnee;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnobject", 1, 1);
    }

    void spawnobject()
    {
        transform.position = new Vector3(Random.Range(8f, -8f), transform.position.y , transform.position.z);
        Instantiate(spawnee[Random.Range(0, spawnee.Length)], transform.position, transform.rotation);
    }
}
