using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    public const int hoursInDay = 24, minutesInHour = 60;
    public float dayDuration = 30f;
    private float totalTime = 0;
    private float currentTime = 0;

    void Update()
    {
        totalTime += Time.deltaTime;
        currentTime = totalTime % dayDuration;
    }

    public float GetHour()
    {
        return currentTime * hoursInDay / dayDuration;
    }

    public float GetMinutes()
    {
        return (currentTime * hoursInDay * minutesInHour / dayDuration) % minutesInHour;
    }

    public string Clock24Hours()
    {
        return Mathf.FloorToInt(GetHour()).ToString("00") + ":" + Mathf.FloorToInt(GetMinutes()).ToString("00");
    }
}
