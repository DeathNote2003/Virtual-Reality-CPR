using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) // Press C to continue
        {
            SceneManager.LoadScene(0);
        }
    }
}