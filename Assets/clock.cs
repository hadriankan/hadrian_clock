using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
	Transform hoursPivot, minutesPivot, secondsPivot;


    void Awake()
    {
        // Debug.Log(DateTime.Now);
        // hoursPivot.localRotation = Quaternion.Euler(0f, 0f, -30f * DateTime.Now.Hour);
        // minutesPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * DateTime.Now.Minute);
        // secondsPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * DateTime.Now.Second);
    } 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, -30f * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * (float)time.TotalSeconds);
        
    }
}
