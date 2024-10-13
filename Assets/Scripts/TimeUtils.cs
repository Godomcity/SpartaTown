using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUtils : MonoBehaviour
{
    [SerializeField] Text timeText;

    private void Update()
    {
        timeText.text = GetCurrentData();
    }

    public static string GetCurrentData()
    {
        return DateTime.Now.ToString(("HH:MM"));
    }
}
