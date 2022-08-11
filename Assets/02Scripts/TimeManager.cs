using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI TMPUGUI_Time;
    private float time_start;
    public static float time_current;
    private float time_Max = 100f;
    private bool isEnded;

    private void Start()
    {
        Reset_Timer();
    }
    void Update()
    {
        if (isEnded)
            return;

        Check_Timer();
    }

    private void Check_Timer()
    {
        time_current = Time.time - time_start;
        if (time_current < time_Max)
        {
            TMPUGUI_Time.text = $"{time_current:N2}";
        }
        else if (!isEnded)
        {
            End_Timer();
        }
    }

    private void End_Timer()
    {
        
        time_current = time_Max;
        TMPUGUI_Time.text = $"{time_current:N2}";
        isEnded = true;
    }


    private void Reset_Timer()
    {
        time_start = Time.time;
        time_current = 0;
        TMPUGUI_Time.text = $"{time_current:N2}";
        isEnded = false;
    }
}