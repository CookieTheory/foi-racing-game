using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteBoxBest;
    public GameObject SecondBoxBest;
    public GameObject MiliBoxBest;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;

    public float RawTime;

    public GameObject RaceFinish;

    void Update()
    {
        if(LapsDone == 2)
        {
            RaceFinish.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlayerCar")
        {
            LapsDone += 1;
            RawTime = PlayerPrefs.GetFloat("RawTime");
            if (LapTimeManager.RawTime <= RawTime)
            {
                MinuteBoxBest.GetComponent<Text>().text = LapTimeBox.GetComponent<LapTimeManager>().MinuteBox.GetComponent<Text>().text;
                SecondBoxBest.GetComponent<Text>().text = LapTimeBox.GetComponent<LapTimeManager>().SecondBox.GetComponent<Text>().text;
                MiliBoxBest.GetComponent<Text>().text = LapTimeBox.GetComponent<LapTimeManager>().MiliBox.GetComponent<Text>().text;
                PlayerPrefs.SetInt("MinuteSave", LapTimeManager.MinuteCount);
                PlayerPrefs.SetInt("SecondSave", LapTimeManager.SecondCount);
                PlayerPrefs.SetFloat("MiliSave", LapTimeManager.MiliCount);
                PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);
            }

            LapTimeManager.MinuteCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MiliCount = 0;
            LapTimeManager.RawTime = 0;
            LapCounter.GetComponent<Text>().text = "" + LapsDone;

            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    }
}
