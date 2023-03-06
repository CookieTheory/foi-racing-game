using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject GreenBody;
    public GameObject RedBody;
    public GameObject BlueBody;
    public int CarImport;

    void Start()
    {
        CarImport = Select.CarType;
        if(CarImport == 0)
        {
            GreenBody.SetActive(true);
        }
        else if (CarImport == 1)
        {
            RedBody.SetActive(true);
        }
        else if(CarImport == 2)
        {
            BlueBody.SetActive(true);
        }
    }


}
