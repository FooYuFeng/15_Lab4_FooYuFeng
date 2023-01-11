using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        if (transform.position.x > 7)
        {
            transform.position = new Vector3(7, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -7)
        {
            transform.position = new Vector3(-7, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Healthy")
        {
            Debug.Log("hit H");
        }
        else if (other.gameObject.tag == "Unhealthy")
        {
            Debug.Log("hit U");
        }
    }
}