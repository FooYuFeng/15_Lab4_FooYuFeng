using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnee;
    public AudioSource soundAudio;
    public AudioClip spawnSound;
    public float spawnDelay;
    public float fallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawnobject");
    }

    IEnumerator spawnobject()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            transform.position = new Vector3(Random.Range(8f, -8f), transform.position.y, transform.position.z);
            Instantiate(spawnee[Random.Range(0, spawnee.Length)], transform.position, transform.rotation).GetComponent<ObjectMovement>().speed = fallSpeed;
            soundAudio.PlayOneShot(spawnSound, 1.35f);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
