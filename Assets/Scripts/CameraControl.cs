using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    Vector3 CurrentPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentPosition = GameObject.Find("Main Circle").transform.position;
        CurrentPosition.z = -10;
        transform.position = CurrentPosition;

    }
}
