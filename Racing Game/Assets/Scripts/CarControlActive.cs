using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject Driver01;

    // Start is called before the first frame update
    void Start()
    {
        CarControl.GetComponent<CarUserControl>().enabled = true;
        Driver01.GetComponent<CarAIControl>().enabled = true;
    }
}
