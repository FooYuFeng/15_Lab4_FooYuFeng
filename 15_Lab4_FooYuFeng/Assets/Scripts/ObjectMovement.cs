using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, -speed * Time.deltaTime, 0f);
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}
