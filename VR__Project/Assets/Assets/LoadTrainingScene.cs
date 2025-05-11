using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTrainingScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) // Press T to load training scene
        {
            SceneManager.LoadScene(1);
        }
    }
}