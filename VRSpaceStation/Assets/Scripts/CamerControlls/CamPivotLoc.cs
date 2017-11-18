using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPivotLoc : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        transform.position = GameObject.FindGameObjectWithTag("Vrss").transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
