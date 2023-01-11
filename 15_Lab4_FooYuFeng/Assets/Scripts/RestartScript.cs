using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public void restartButton(string sceneLoader)
    {
        SceneManager.LoadScene(sceneLoader);
    }
}
