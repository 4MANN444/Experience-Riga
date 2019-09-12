using UnityEngine;
using System.Collections;

public class prefs : MonoBehaviour
{
    public float offtime;        //time before quit button is active
    public float fadetime;       //time it takes to fade out scenes
    public float filltime;       //time to fill a slider or picture  
	void Start ()
    {
        PlayerPrefs.SetFloat("offtime", offtime);
        PlayerPrefs.SetFloat("fadetime", fadetime);
        PlayerPrefs.SetFloat("filltime", filltime);
        PlayerPrefs.Save();
    }
	
	
}
