using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject HoursArrow;
    [SerializeField]
    GameObject MinutesArrow;
    [SerializeField]
    GameObject SecondsArrow;

    // Update is called once per frame
    void Update()
    {

        HoursArrow.transform.localRotation = Quaternion.Euler(30 * DateTime.Now.Hour, 0, 0);
        MinutesArrow.transform.localRotation =  Quaternion.Euler(6 * DateTime.Now.Minute, 0, 0);
        SecondsArrow.transform.localRotation = Quaternion.Euler(6 * DateTime.Now.Second, 0, 0);
    }
}
