using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeSaver : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI time;
    void Start()
    {
        time.text = $"time : {TimeManager.time_current}";
    }
}
