using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public static int CarType;
    public GameObject TrackWindow;

    public void GreenCar()
    {
        CarType = 0;
        TrackWindow.SetActive(true);
    }

    public void RedCar()
    {
        CarType = 1;
        TrackWindow.SetActive(true);
    }

    public void BlueCar()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    }
}
