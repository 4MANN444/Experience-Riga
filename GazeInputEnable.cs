using UnityEngine;
using System.Collections;

public class GazeInputEnable : MonoBehaviour {

    void Start()
    {
        gameObject.GetComponent<GazeInputModule>().enabled = true;      //simply makes sure gazeinput is enabled
    }
    
}
