using UnityEngine;
using System.Collections;

public class cameraposfollow : MonoBehaviour
{
    public GameObject camera;
    
	void LateUpdate()
    {
       transform.Rotate(0,0, transform.eulerAngles.y - camera.transform.eulerAngles.y);
    }
}
