using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeTime : MonoBehaviour
{
    public int ModeSelection;
    public GameObject AICar;
    public GameObject RacePanels;

    public static bool TimeMode = false;

    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;

        if(ModeSelection == 1)
        {
            TimeMode = true;
            AICar.SetActive(false);
            RacePanels.SetActive(false);
        }
    }
}
