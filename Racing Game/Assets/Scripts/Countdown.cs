using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject Count;
    public AudioSource Ready;
    public AudioSource Go;
    public GameObject LapTimer;
    public GameObject CarControl;
    public AudioSource LevelMusic;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        Count.GetComponent<Text>().text = "3";
        Ready.Play();
        Count.SetActive(true);
        yield return new WaitForSeconds(1);
        Count.SetActive(false);
        Count.GetComponent<Text>().text = "2";
        Ready.Play();
        Count.SetActive(true);
        yield return new WaitForSeconds(1);
        Count.SetActive(false);
        Count.GetComponent<Text>().text = "1";
        Ready.Play();
        Count.SetActive(true);
        yield return new WaitForSeconds(1);
        Count.SetActive(false);
        Go.Play();
        LevelMusic.Play();
        LapTimer.SetActive(true);
        CarControl.SetActive(true);
    }
}
