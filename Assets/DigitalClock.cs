using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DigitalClock : MonoBehaviour
{
    TimeManager tm;
    TMP_Text clockDisplay;
    void Start()
    {
        tm = FindObjectOfType<TimeManager>();
        clockDisplay = GetComponent<TMP_Text>();
    }

    void Update()
    {
        clockDisplay.text = tm.Clock24Hours();
    }
}
