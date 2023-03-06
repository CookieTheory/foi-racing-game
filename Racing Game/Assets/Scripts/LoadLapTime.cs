using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int MinuteCount;
    public int SecondCount;
    public float MiliCount;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MiliDisplay;

    void Start()
    {
        MinuteCount = PlayerPrefs.GetInt("MinuteSave");
        SecondCount = PlayerPrefs.GetInt("SecondSave");
        MiliCount = PlayerPrefs.GetFloat("MiliSave");

        MinDisplay.GetComponent<Text>().text = "" + MinuteCount + ":";
        SecDisplay.GetComponent<Text>().text = "" + SecondCount + ".";
        MiliDisplay.GetComponent<Text>().text = "" + MiliCount;
    }

    
}
