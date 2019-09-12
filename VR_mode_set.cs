using UnityEngine;
using System.Collections;

public class VR_mode_set : MonoBehaviour
{


    void Start()
    {
        if (PlayerPrefs.GetInt("VRMode") == 1)          //If the player pref is 1(set in main menu)
        {
            GvrViewer.Instance.VRModeEnabled = true;    //VR mode enabled       
        }
        if (PlayerPrefs.GetInt("VRMode") == 0)          //If the player pref is 0(set in main menu)
        {
            GvrViewer.Instance.VRModeEnabled = false;   //VR mode disabled
        }
        Debug.Log("VR MODE"+PlayerPrefs.GetInt("VRMode"));        //debugs variable
    }
}
