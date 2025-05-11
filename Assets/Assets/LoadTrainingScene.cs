using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTrainingScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) 
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.P)) 
        {
            SceneManager.LoadScene(2);
        }
    }
}