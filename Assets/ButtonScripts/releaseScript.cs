using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class releaseScript : MonoBehaviour
{

    public void changeScene()
    {
        if (holdCount.time > 2.0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        holdCount.time = 0;

    }
}