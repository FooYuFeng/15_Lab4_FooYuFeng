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
    public float timer;

    public AudioSource soundAudio;
    public AudioClip collectSound;

    public Text scoreText;
    public Text timerText;

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

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene(switcSceneLose);
        }
        else
        {
            timerText.text = "Time Left: " + (int)timer;
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
            else
            {
                soundAudio.PlayOneShot(collectSound);
            }

            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Unhealthy")
        {
            SceneManager.LoadScene(switcSceneLose);
        }
    }
}
