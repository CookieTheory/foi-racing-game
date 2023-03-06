using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver01Track : MonoBehaviour
{
    public GameObject Tracker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public GameObject Mark08;
    public int Counter;

    void Update()
    {
        if(Counter == 0)
        {
            Tracker.transform.position = Mark01.transform.position;
        }
        else if(Counter == 1)
        {
            Tracker.transform.position = Mark02.transform.position;
        }
        else if (Counter == 2)
        {
            Tracker.transform.position = Mark03.transform.position;
        }
        else if (Counter == 3)
        {
            Tracker.transform.position = Mark04.transform.position;
        }
        else if (Counter == 4)
        {
            Tracker.transform.position = Mark05.transform.position;
        }
        else if (Counter == 5)
        {
            Tracker.transform.position = Mark06.transform.position;
        }
        else if (Counter == 6)
        {
            Tracker.transform.position = Mark07.transform.position;
        }
        else if (Counter == 7)
        {
            Tracker.transform.position = Mark08.transform.position;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Driver01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            Counter++;
            if(Counter == 8)
            {
                Counter = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
