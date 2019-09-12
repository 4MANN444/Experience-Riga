using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Main_scene_Btns : MonoBehaviour {
    public GameObject menuCnvs;
    public GameObject thanksCnvs;
    public GameObject aboutCnvs;
    bool submenuactive;                  //if user is on the thanks screen

    //for out transition
    public float transitiontime;
    float transitiontimer;
    bool begintransition = false;
    public Image black;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (submenuactive)                   //if on the thanks or about screen, android back button does not quit app
            {
                back_to_mainmenu();
            }
            else
            {
                Application.Quit();
            }
        }
        transition();
    }


    public void VRstart()                   //when vr button is pressed
        {
        PlayerPrefs.SetInt("VRMode", 1);    //sets vr mode player pref
        PlayerPrefs.Save();                 //saves it^
        loadnextscene();          //loading 360 menu
        }
    public void nonVRstart()                //when non Vr mode is pressed
    {
        PlayerPrefs.SetInt("VRMode", 0);    //sets vr mode player pref
        PlayerPrefs.Save();                 //saves it^
        loadnextscene();          //loading 360 menu
    }
    public void thanksbtn()                 //when special thanks is pressed
    {
        menuCnvs.SetActive(false);          //deactivate main canvas
        thanksCnvs.SetActive(true);         //enable thanks canvas
        submenuactive = true;
    }
    public void aboutbtn()                 //when special thanks is pressed
    {
        menuCnvs.SetActive(false);          //deactivate main canvas
        aboutCnvs.SetActive(true);         //enable about canvas
        submenuactive = true;
    }
    public void back_to_mainmenu()          //when special thanks back button is pressed
    {
        thanksCnvs.SetActive(false);        //deactivate thanks canvas
        aboutCnvs.SetActive(false);         //deactivate about canvas
        menuCnvs.SetActive(true);           //enable main canvas
        submenuactive = false;
    }
    public void quitbtn()                   //when quit is pressed
    {
        Application.Quit();                 //quits
    }
    //code for out transition:
    void loadnextscene()
    {
        begintransition = true;
    }

    void transition()
    {
        if (begintransition)
        {
            transitiontimer += Time.deltaTime;
            black.color = new Color(0, 0, 0, transitiontimer / transitiontime);


        }
        if (transitiontimer / transitiontime >= 1)
        {
            SceneManager.LoadScene(1);
        }
    }
}
