using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class infade : MonoBehaviour
{
    public float transitiontime;
    float transitiontimer;
    public Image black;


    void Start()
    {

    }
    void Update()
    {
        fadein();
    }
    void fadein()
    {
        if (transitiontimer / transitiontime <= 1)
        {
            transitiontimer += Time.deltaTime;
            black.color = new Color(0, 0, 0, 1 - transitiontimer / transitiontime);
        }
    }

}
