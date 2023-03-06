using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapStable : MonoBehaviour
{
    public GameObject Car;
    public float CarY;

    void Update()
    {
        CarY = Car.transform.eulerAngles.y;

        transform.eulerAngles = new Vector3(0, CarY, 0);
    }
}