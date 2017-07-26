using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class holdCount : MonoBehaviour
{

    public static float time = 0;

    void Update()
    {
        time += Time.deltaTime;

    }

}