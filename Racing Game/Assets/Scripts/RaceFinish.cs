using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject Player;
    public GameObject Driver01;
    public GameObject FinishCamera;
    public GameObject Viewmodes;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;

    void OnTriggerEnter()
    {
        if(ModeTime.TimeMode == true)
        {
            //time attack mode
        }
        else
        {
            this.GetComponent<BoxCollider>().enabled = false;
            Player.SetActive(false);
            Driver01.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            Player.GetComponent<CarController>().enabled = false;
            Driver01.GetComponent<CarController>().enabled = false;
            Player.GetComponent<CarUserControl>().enabled = false;
            Driver01.GetComponent<CarAIControl>().enabled = false;
            Player.SetActive(true);
            Driver01.SetActive(true);
            Player.GetComponent<CarAudio>().StopSound();
            Player.GetComponent<CarAudio>().enabled = false;
            Driver01.GetComponent<CarAudio>().StopSound();
            Driver01.GetComponent<CarAudio>().enabled = false;
            FinishCamera.SetActive(true);
            LevelMusic.SetActive(false);
            Viewmodes.SetActive(false);
        }
    }
}
