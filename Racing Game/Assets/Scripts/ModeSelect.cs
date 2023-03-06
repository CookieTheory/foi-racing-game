using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    public static int RaceMode; //0 = race, 1 = time attack
    public GameObject TrackSelect;

    public void Race()
    {
        RaceMode = 0;
        TrackSelect.SetActive(true);
    }

    public void TimeAttack()
    {
        RaceMode = 1;
        TrackSelect.SetActive(true);
    }
}
