using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpScriptPractice : MonoBehaviour
{
    public int countPump = 0;
    float time = 0;
    public int timeInSec = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse click to increment pump count
        {
            countPump++;
            Debug.Log("PumpCount:" + countPump);
        }

        if (countPump >= 1)
        {
            time += Time.deltaTime;
            timeInSec = (int)time;
            Debug.Log(timeInSec);
        }
        if (timeInSec == 6)
        {
            time = 0;
            countPump = 0;
        }
    }
}