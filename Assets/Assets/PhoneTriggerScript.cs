using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneTriggerScript : MonoBehaviour
{
    public bool isPhonePicked = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) // Press F to pick up the phone
        {
            isPhonePicked = true;
        }
    }
}