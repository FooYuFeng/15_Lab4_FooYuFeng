using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketMovementScript : MonoBehaviour
{
    public string switcSceneWin;
    public string switcSceneLose;
    public int scoreToWin;

    public Text scoreText;

    public float speed;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score + " / " + scoreToWin;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Healthy")
        {
            score += 10;
            scoreText.text = "Score: " + score + " / " + scoreToWin;

            if (score >= scoreToWin)
            {
                SceneManager.LoadScene(switcSceneWin);
                return;
            }

            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Unhealthy")
        {
            SceneManager.LoadScene(switcSceneLose);
        }
    }
}
