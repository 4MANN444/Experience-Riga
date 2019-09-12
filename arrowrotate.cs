using UnityEngine;
using System.Collections;

public class arrowrotate : MonoBehaviour {
    public float speed;
    void LateUpdate()
    {
        transform.Rotate(0, 0, -Time.deltaTime * speed);
    }
}
