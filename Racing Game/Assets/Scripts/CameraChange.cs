using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCamera;
    public GameObject FarCamera;
    public GameObject HoodCamera;
    public int CameraMode;

    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            if (CameraMode == 2)
            {
                CameraMode = 0;
            }
            else CameraMode++;
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(CameraMode == 0)
        {
            NormalCamera.SetActive(true);
            HoodCamera.SetActive(false);
        }
        else if(CameraMode == 1)
        {
            FarCamera.SetActive(true);
            NormalCamera.SetActive(false);
        }
        else if(CameraMode == 2)
        {
            HoodCamera.SetActive(true);
            FarCamera.SetActive(false);
        }
    }
}
